using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMBA.mvc.Models;

namespace WebMBA.mvc.Controllers
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class HomeController : Controller, IHomeController
    {
        // Action trả về trang chủ
        public ActionResult Index()
        {
            return View();
        }

        // Action trả về trang About
        public ActionResult About()
        {
            ViewBag.Message = "Giới thiệu về chúng tôi.";
            return View();
        }

        // Action trả về trang Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Liên hệ với chúng tôi.";
            return View();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
