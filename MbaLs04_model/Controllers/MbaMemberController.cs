using MbaLs04_model.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace MbaLs04_model.Controllers
{
    public class MbaMemberController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MbaGetMember()
        {
            List<MbaMember> MbaMembers = new List<MbaMember>()
            {
             new MbaMember{MbaMemberId = Guid.NewGuid().ToString(), MbaUserName = "mba", MbaFullName = "Mai binh an", MbaPassWord = "124128@", MbaEmail = "mba@gmail.com"}  ,

             new MbaMember{MbaMemberId = Guid.NewGuid().ToString(), MbaUserName = "user2", MbaFullName = "Nguyen Van B", MbaPassWord = "pass456", MbaEmail = "@gmail.com"}  ,

             new MbaMember{MbaMemberId = Guid.NewGuid().ToString(), MbaUserName = "user3", MbaFullName = "Nguyen Van C", MbaPassWord = "pass456", MbaEmail = "@gmail.com"}  ,

             new MbaMember{MbaMemberId = Guid.NewGuid().ToString(), MbaUserName = "user4", MbaFullName = "Nguyen Van D", MbaPassWord = "pass456", MbaEmail = "@gmail.com"}  ,

             new MbaMember{MbaMemberId = Guid.NewGuid().ToString(), MbaUserName = "user5", MbaFullName = "Nguyen Van E", MbaPassWord = "pass456", MbaEmail = "@gmail.com"}  ,

             };
            ViewBag.MbaGetMembers = mbaGetMembers;
            return View();
        }
    }
}

            

                