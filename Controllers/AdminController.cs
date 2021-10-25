using BayernData.Data;
using BayernData.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BayernData.Controllers
{
    public class AdminController : Controller
    {
        public UserManager<IdentityUser> _userManager { get; }
        public SignInManager<IdentityUser> _signInManager { get; }
        public IRepositoryWrapper _repositoryWrapper { get; }

        [TempData]
        public string Message { get; set; }

        public AdminController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IRepositoryWrapper repositoryWrapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByEmailAsync(loginViewModel.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Add", "Admin");
                    }
                }
                ModelState.AddModelError("", "Invalid email or password!");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewData["Message"] = Message;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Staff staff)
        {
            if (ModelState.IsValid)
            {
                _repositoryWrapper.staffRepository.Create(staff);
                _repositoryWrapper.staffRepository.Save();
                Message = $"{staff.StaffFirstName} {staff.StaffLastName} was successfully added as {staff.StaffPosition}";
                return RedirectToAction("Add", "Admin");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_repositoryWrapper.staffRepository.FindById(id));
        }

        [HttpPost]
        public IActionResult Edit(Staff staff)
        {
            if (ModelState.IsValid)
            {
                _repositoryWrapper.staffRepository.Update(staff);
                _repositoryWrapper.staffRepository.Save();
                return RedirectToAction("Players", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Staff staff = _repositoryWrapper.staffRepository.FindById(id);
            if (staff != null)
            {
                _repositoryWrapper.staffRepository.Delete(staff);
                _repositoryWrapper.staffRepository.Save();
                Message = $"{staff.StaffFirstName} {staff.StaffLastName} was successfully delete";
            }
            return RedirectToAction("Players", "Home");
        }
    }
}
