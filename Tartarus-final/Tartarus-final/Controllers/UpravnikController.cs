using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tartarus_final.Controllers
{
    public class UpravnikController : Controller
    {
        [Authorize(Roles = "Upravnik")]
        public IActionResult Index()
        {
            return View();
        }
    }
}