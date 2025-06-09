using Microsoft.AspNetCore.Mvc;

namespace WebMBA.mvc.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
