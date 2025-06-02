using MbaLesson07.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MbaLesson07.Models;

namespace MbaLesson07.Controllers
{
    public class MbaHomeController : Controller
    {
        private readonly ILogger<MbaHomeController> _logger;

        public MbaHomeController(ILogger<MbaHomeController> logger)
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
