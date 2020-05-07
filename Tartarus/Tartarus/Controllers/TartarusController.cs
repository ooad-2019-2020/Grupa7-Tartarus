using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;

namespace Tartarus.Controllers
{
    public class TartarusController : Controller
    {
        public readonly ILogger<TartarusController> _logger;

        public TartarusController(ILogger<TartarusController> logger)
        {
            _logger = logger;
        }
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