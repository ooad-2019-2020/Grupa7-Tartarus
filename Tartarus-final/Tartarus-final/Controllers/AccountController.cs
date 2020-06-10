using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tartarus_final.Models;

namespace Tartarus_final.Controllers
{
    public class AccountController : Controller
    {
        private  UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager) 
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
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);

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
                //dodati username prilikom kreiranj
               
  
                if(model.Type == "Cuvar")
                {
                    var user = new ApplicationUser { UserName = model.Username, PasswordHash = model.Password, Email = model.Email, RegistrationType = RegistrationTypes.Cuvar };
                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("index", "home");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                else if(model.Type == "Upravnik")
                {
                    var user = new ApplicationUser { UserName = model.Username, PasswordHash = model.Password, Email = model.Email, RegistrationType = RegistrationTypes.Upravnik };
                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("index", "home");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                else if (model.Type == "Pravnik")
                {
                    var user = new ApplicationUser { UserName = model.Username, PasswordHash = model.Password, Email = model.Email, RegistrationType = RegistrationTypes.Pravnik };
                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("index", "home");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

                

            }
            return View(model);
        }



    }
}