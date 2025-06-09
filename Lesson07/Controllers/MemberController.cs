using Lesson07.Models.DataModel;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace Lesson07.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> listmember = new List<Member>
        {


                new Member { MemberId = "M001", UserName = "user1", Fullname = "Nguyen Van A", password = "123456", Email = "user1@example.com" },
                new Member { MemberId = "M002", UserName = "user2", Fullname = "Tran Thi B", password = "abcdef", Email = "user2@example.com" },
                new Member { MemberId = "M003", UserName = "user3", Fullname = "Le Van C", password = "pass123", Email = "user3@example.com" },
                new Member { MemberId = "M004", UserName = "user4", Fullname = "Pham Thi D", password = "hello123", Email = "user4@example.com" },
                new Member { MemberId = "M005", UserName = "user5", Fullname = "Hoang Van E", password = "welcome", Email = "user5@example.com" },

        };

        public IActionResult MbaIndex()
        {
            return View();
        }
    }
}
