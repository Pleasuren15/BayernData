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

        public AdminController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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

        public IActionResult Add()
        {
            return View();
        }
    }
}
