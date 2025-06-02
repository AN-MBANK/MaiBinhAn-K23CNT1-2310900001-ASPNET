using Microsoft.AspNetCore.Mvc;
using MbaLesson07.Models;

namespace MbaLesson07.Controllers
{
    public class MbaEmployeeController : Controller
    {
        private static List<MbaEmployee> mbaListEmployees = new List<MbaEmployee>
        {
            new MbaEmployee { MbaId = 230001122, MbaName = "Chung Trịnh", MbaBirthDay = new DateTime(1979, 5, 25), MbaEmail = "chungtrinhj@gmail.com", MbaPhone = "0978611889", MbaSalary = 12000000, MbaStatus = true },
            new MbaEmployee { MbaId = 2, MbaName = "Trần Thị B", MbaBirthDay = new DateTime(1992, 5, 15), MbaEmail = "b@example.com", MbaPhone = "0912233445", MbaSalary = 15000000, MbaStatus = true },
            new MbaEmployee { MbaId = 3, MbaName = "Lê Văn C", MbaBirthDay = new DateTime(1988, 9, 20), MbaEmail = "c@example.com", MbaPhone = "0922123456", MbaSalary = 11000000, MbaStatus = false },
            new MbaEmployee { MbaId = 4, MbaName = "Phạm Thị D", MbaBirthDay = new DateTime(1995, 3, 10), MbaEmail = "d@example.com", MbaPhone = "0933445566", MbaSalary = 13000000, MbaStatus = true },
            new MbaEmployee { MbaId = 5, MbaName = "Đỗ Văn E", MbaBirthDay = new DateTime(1991, 7, 25), MbaEmail = "e@example.com", MbaPhone = "0944567890", MbaSalary = 10000000, MbaStatus = false }
        };

        public IActionResult MbaIndex()
        {
            return View(mbaListEmployees);
        }

        // GET: /MbaEmployee/MbaCreate
        public IActionResult MbaCreate()
        {
            var model = new MbaEmployee();
            return View(model);
        }

        // POST: /MbaEmployee/MbaCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MbaCreate(MbaEmployee model)
        {
            try
            {
                if (model.MbaId == 0)
                {
                    model.MbaId = mbaListEmployees.Max(e => e.MbaId) + 1;
                }
                mbaListEmployees.Add(model);
                return RedirectToAction(nameof(MbaIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: /MbaEmployee/MbaEdit/id?
        public IActionResult MbaEdit(int id)
        {
            var model = mbaListEmployees.FirstOrDefault(x => x.MbaId == id);
            return View(model);
        }
    }
}
