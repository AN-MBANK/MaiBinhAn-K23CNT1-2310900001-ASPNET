using Microsoft.AspNetCore.Mvc;

namespace WebMBA.mvc.Controllers
{
    public interface IHomeController
    {
        ActionResult About();
        ActionResult Contact();
        ActionResult Index();
    }
}