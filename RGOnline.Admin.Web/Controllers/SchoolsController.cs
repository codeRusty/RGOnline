using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RGOnline.DataAccess;
using RGOnline.DataModels.Models;

namespace RGOnline.Admin.Web.Controllers
{
    public class SchoolsController : Controller
    {
        private readonly RGOnlineContext _context;

        public SchoolsController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: Schools
        public async Task<IActionResult> Index()
        {
            var rGOnlineContext = _context.School.Include(s => s.Address);
            return View(await rGOnlineContext.ToListAsync());
        }

        // GET: Schools/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School
                .Include(s => s.Address)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }

        // GET: Schools/Create
        public IActionResult Create()
        {
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Building");
            return View();
        }

        // POST: Schools/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,AddressId,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,IsActive")] School school)
        {
            if (ModelState.IsValid)
            {
                _context.Add(school);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Building", school.AddressId);
            return View(school);
        }

        // GET: Schools/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School.SingleOrDefaultAsync(m => m.Id == id);
            if (school == null)
            {
                return NotFound();
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Building", school.AddressId);
            return View(school);
        }

        // POST: Schools/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Description,AddressId,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,IsActive")] School school)
        {
            if (id != school.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(school);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchoolExists(school.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Building", school.AddressId);
            return View(school);
        }

        // GET: Schools/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var school = await _context.School
                .Include(s => s.Address)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (school == null)
            {
                return NotFound();
            }

            return View(school);
        }

        // POST: Schools/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var school = await _context.School.SingleOrDefaultAsync(m => m.Id == id);
            _context.School.Remove(school);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchoolExists(long id)
        {
            return _context.School.Any(e => e.Id == id);
        }
    }
}
