using System.Diagnostics;
using Mbalss04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mbalss04.Controllers
{
    public class MbahomeController : Controller
    {
        private readonly ILogger<MbahomeController> _logger;

        public MbahomeController(ILogger<MbahomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult MbaIndex()
        {
            return View();
        }

        public IActionResult MbaAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
