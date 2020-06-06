using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tartarus_final.Controllers
{
    public class PravnikController : Controller
    {
        [Authorize(Roles = "Pravnik")]
        public IActionResult Index()
        {
            return View();
        }
    }
}