using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MbaLesson07.Controllers
{
    public class MbaMemberController : Controller
    {
        // GET: MbaMemberController
        public ActionResult MbaIndex()
        {
            return View();
        }

        // GET: MbaMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MbaMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MbaMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(MbaIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: MbaMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MbaMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(MbaIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: MbaMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MbaMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(MbaIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
