using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLAB5.Models;

namespace NetCoreMVCLAB5.Controllers
{
    public class MbaAccountController : Controller
    {
        // GET: MbaAccountCo/ntroller
        public ActionResult MbaIndex()
        {
            List<MbaAccount> MbaAccounts = new List<MbaAccount>();
            return View(MbaAccounts);
        }

        // GET: MbaAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MbaAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MbaAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MbaAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MbaAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MbaAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MbaAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
