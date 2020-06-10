using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tartarus_final.Models;

namespace Tartarus_final.Controllers
{
    public class UpravnikController : Controller
    {
        private readonly NasContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public UpravnikController(NasContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);

            if (RegistrationTypes.Upravnik != applicationUser?.RegistrationType || applicationUser?.RegistrationType == null)
            {
                return View("~/Views/Home/ErrorView.cshtml");
            }
            return View();
        }
    }
}