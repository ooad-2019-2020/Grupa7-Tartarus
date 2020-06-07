using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Tartarus_final.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
                                 SignInManager<IdentityUser> signInManager) 
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        //veza sa register formom
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //upravlja kada se korisnik registruje (klikne dugme)
        [HttpPost]
        public async Task<IActionResult> Register(Models.RegisterViewModel model)
        {
            if (ModelState.IsValid) {
                var user = new IdentityUser { PasswordHash = model.Password, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded) {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                foreach (var error in result.Errors) {
                    ModelState.AddModelError("", error.Description);
                }

            }


            return View(model);
        }



    }
}