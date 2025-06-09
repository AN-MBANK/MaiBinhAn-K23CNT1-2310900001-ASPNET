using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MbaNetCoreMVCLAB05.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MbaNetCoreMVCLAB05.Controllers
{
    public class MbaPeopleController : Controller
    {
        private readonly DataLocal _context;

        public MbaPeopleController(DataLocal context)
        {
            _context = context;
        }

        // GET: MbaPeopleController
        public ActionResult MbaIndex()
        {
            var peoples = _context.GetMbaPeoples();
            return View(peoples);
        }

        // GET: MbaPeopleController/MbaDetails/5
        public ActionResult MbaDetails(int id)
        {
            var people = _context.GetMbaPeopleByMbaID(id);
            if (people == null)
            {
                return NotFound();
            }
            return View(people);
        }

        // GET: MbaPeopleController/MbaCreate
        public ActionResult MbaCreate()
        {
            return View();
        }

        // POST: MbaPeopleController/MbaCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MbaCreate([Bind("MbaID,MbaName,MbaEmail,MbaPhone,MbaAddress,MbaAvatar,MbaBirthday,MbaBio,MbaGender")] MbaPeople model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count > 0 && files[0].Length > 0)
                    {
                        var file = files[0];
                        var fileName = $"{Guid.NewGuid()}_{file.FileName}";
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatar", fileName);
                        Directory.CreateDirectory(Path.GetDirectoryName(path));

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        model.MbaAvatar = $"/images/avatar/{fileName}";
                    }

                    _context.Add(model);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(MbaIndex));
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }

        // GET: MbaPeopleController/MbaEdit/5
        public ActionResult MbaEdit(int id)
        {
            var people = _context.GetMbaPeopleByMbaID(id);
            if (people == null)
            {
                return NotFound();
            }
            return View(people);
        }

        // POST: MbaPeopleController/MbaEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MbaEdit(int id, [Bind("MbaID,MbaName,MbaEmail,MbaPhone,MbaAddress,MbaAvatar,MbaBirthday,MbaBio,MbaGender")] MbaPeople model)
        {
            if (id != model.MbaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count > 0 && files[0].Length > 0)
                    {
                        var file = files[0];
                        var fileName = $"{Guid.NewGuid()}_{file.FileName}";
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatar", fileName);
                        Directory.CreateDirectory(Path.GetDirectoryName(path));

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        model.MbaAvatar = $"/images/avatar/{fileName}";
                    }

                    _context.Update(model);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(MbaIndex));
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }

        // GET: MbaPeopleController/MbaDelete/5
        public ActionResult MbaDelete(int id)
        {
            var people = _context.GetMbaPeopleByMbaID(id);
            if (people == null)
            {
                return NotFound();
            }
            return View(people);
        }

        // POST: MbaPeopleController/MbaDelete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MbaDeleteConfirmed(int id)
        {
            try
            {
                var people = _context.GetMbaPeopleByMbaID(id);
                if (people != null)
                {
                    _context.Remove(people);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(MbaIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
