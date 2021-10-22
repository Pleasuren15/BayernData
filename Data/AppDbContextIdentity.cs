using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace BayernData.Data
{
    public class AppDbContextIdentity : IdentityDbContext<IdentityUser>
    {
        public AppDbContextIdentity(DbContextOptions<AppDbContextIdentity> options) : base(options)
        {
        }

        public static async Task CreateAdminAccount(IServiceProvider _serviceProvider, IConfiguration _configuration)
        {
            UserManager<IdentityUser> _userManager = _serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            RoleManager<IdentityRole> _roleManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string Name = _configuration["Data:AdminUser:Name"];
            string Email = _configuration["Data:AdminUser:Email"];
            string Phone = _configuration["Data:AdminUser:Phone"];
            string Password = _configuration["Data:AdminUser:Password"];
            string Role = _configuration["Data:AdminUser:Role"];

            if (await _userManager.FindByNameAsync(Name) == null)
            {
                if (await _roleManager.FindByNameAsync(Role) == null)
                {
                    await _roleManager.CreateAsync(new IdentityRole(Role));
                }

                IdentityUser user = new IdentityUser()
                {
                    UserName = Name,
                    Email = Email,
                    PhoneNumber = Phone
                };

                IdentityResult result = await _userManager.CreateAsync(user, Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Role);
                }
            }
        }
    }
}
