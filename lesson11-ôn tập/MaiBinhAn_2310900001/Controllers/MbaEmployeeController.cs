using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MaiBinhAn_2310900001.Models;

namespace MaiBinhAn_2310900001.Controllers
{
    public class MbaEmployeeController : Controller
    {
        private readonly MbaDbContext _context;

        public MbaEmployeeController(MbaDbContext context)
        {
            _context = context;
        }

        // GET: MbaEmployee
        public async Task<IActionResult> MbaIndex(string? keyword)
        {
            var mbaEmployees = _context.MbaEmployee.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                mbaEmployees = mbaEmployees
                    .Where(e => e.MbaEmpName.Contains(keyword));
            }

            return View(await mbaEmployees.ToListAsync());
        }


        // GET: MbaEmployee/Details/5
        public async Task<IActionResult> MbaDetails(int? Mbaid)
        {
            if (Mbaid == null)
            {
                return NotFound();
            }

            var mbaEmployee = await _context.MbaEmployee
                .FirstOrDefaultAsync(m => m.MbaEmpId == Mbaid);
            if (mbaEmployee == null)
            {
                return NotFound();
            }

            return View(mbaEmployee);
        }

        // GET: MbaEmployee/Create
        public IActionResult MbaCreate()
        {
            return View();
        }

        // POST: MbaEmployee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MbaCreate([Bind("MbaEmpId,MbaEmpName,MbaEmpLevel,MbaEmpStartDate,MbaEmpStatus")] MbaEmployee mbaEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mbaEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MbaIndex));
            }
            return View(mbaEmployee);
        }

        // GET: MbaEmployee/Edit/5
        public async Task<IActionResult> MbaEdit(int? Mbaid)
        {
            if (Mbaid == null)
            {
                return NotFound();
            }

            var mbaEmployee = await _context.MbaEmployee.FindAsync(Mbaid);
            if (mbaEmployee == null)
            {
                return NotFound();
            }
            return View(mbaEmployee);
        }

        // POST: MbaEmployee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MbaEdit(int Mbaid, [Bind("MbaEmpId,MbaEmpName,MbaEmpLevel,MbaEmpStartDate,MbaEmpStatus")] MbaEmployee mbaEmployee)
        {
            if (Mbaid != mbaEmployee.MbaEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mbaEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MbaEmployeeExists(mbaEmployee.MbaEmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(MbaIndex));
            }
            return View(mbaEmployee);
        }

        // GET: MbaEmployee/Delete/5
        public async Task<IActionResult> MbaDelete(int? Mbaid)
        {
            if (Mbaid == null)
            {
                return NotFound();
            }

            var mbaEmployee = await _context.MbaEmployee
                .FirstOrDefaultAsync(m => m.MbaEmpId == Mbaid);
            if (mbaEmployee == null)
            {
                return NotFound();
            }

            return View(mbaEmployee);
        }

        // POST: MbaEmployee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MbaDeleteConfirmed(int Mbaid)
        {
            var mbaEmployee = await _context.MbaEmployee.FindAsync(Mbaid);
            if (mbaEmployee != null)
            {
                _context.MbaEmployee.Remove(mbaEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MbaIndex));
        }

        private bool MbaEmployeeExists(int Mbaid)
        {
            return _context.MbaEmployee.Any(e => e.MbaEmpId == Mbaid);
        }
    }
}
