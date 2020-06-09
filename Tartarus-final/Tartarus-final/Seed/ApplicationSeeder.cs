using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UE.Db.Main;
using UE.Models.Authentication;

namespace UE.Db.Seed
{
    public class ApplicationSeeder
    {
        private readonly UserManager<ApplicationUser> userManager;

        private readonly RoleManager<ApplicationRole> roleManager;

        private readonly UEDbContext context;

        public ApplicationSeeder(UserManager<ApplicationUser> _userManager, RoleManager<ApplicationRole> _roleManager, UEDbContext _context)
        {
            userManager = _userManager;
            roleManager = _roleManager;
            context = _context;
        }
        // kreiraj uloge ukoliko ne postoje 
        public async Task SeedData()
        {
            var roleUpravnik = await roleManager.FindByNameAsync("Upravnik");
            if (roleUpravnik == null)
                await roleManager.CreateAsync(new ApplicationRole() { Name = "Upravnik" });

            var roleCuvar = await roleManager.FindByNameAsync("Cuvar");
            if (roleCuvar == null)
                await roleManager.CreateAsync(new ApplicationRole() { Name = "Cuvar" });

            var rolePravnik = await roleManager.FindByNameAsync("Pravnik");
            if (rolePravnik == null)
                await roleManager.CreateAsync(new ApplicationRole() { Name = "Pravnik" });
        }
    }
}
