using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Tartarus.Controllers
{
    public class TartarusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Test " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}