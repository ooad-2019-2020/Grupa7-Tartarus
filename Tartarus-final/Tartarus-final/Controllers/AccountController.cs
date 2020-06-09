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
        private  UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
                                 SignInManager<IdentityUser> signInManager) 
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        [HttpPost]
        public async Task<IActionResult> Logout() {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        public IActionResult Login()
        {
            return View();
        }


     //   public IActionResult Login(string returnUrl)
     //   {
     //       return LocalRedirect(returnUrl);
     //   }

        //upravlja kada se korisnik registruje (klikne dugme)
        [HttpPost]
        public async Task<IActionResult> Login(Models.LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {

                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    else
                    {
                      
                        return RedirectToAction("index", "home");
                    }
                }
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
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