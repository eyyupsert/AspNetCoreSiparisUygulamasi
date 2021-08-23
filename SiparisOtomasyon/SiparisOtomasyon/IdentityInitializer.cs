using Microsoft.AspNetCore.Identity;
using SiparisOtomasyon.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiparisOtomasyon
{
    public class IdentityInitializer
    {
        public static void OlusturAdmin(UserManager<AppUser> userManager,RoleManager<IdentityRole>
            roleManager)
        {
            AppUser appUser = new AppUser
            {
                Name = "Eyyup",
                SurName = "Sert",
                UserName = "stiffman"
            };
            if(userManager.FindByNameAsync("eyyup").Result == null)
            {
                var identityResult = userManager.CreateAsync(appUser,"1").Result;
            }
            if(roleManager.FindByNameAsync("Admin").Result == null)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = "Admin"
                };
                var identityResult = roleManager.CreateAsync(role).Result;
                var result = userManager.AddToRoleAsync(appUser,role.Name).Result;
            }
        }
    }
}
