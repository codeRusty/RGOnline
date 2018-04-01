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
    public class SizesController : Controller
    {
        private readonly RGOnlineContext _context;

        public SizesController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: Sizes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Size.ToListAsync());
        }

        // GET: Sizes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var size = await _context.Size
                .SingleOrDefaultAsync(m => m.Id == id);
            if (size == null)
            {
                return NotFound();
            }

            return View(size);
        }

        // GET: Sizes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Length,Breath,Weight,Number,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,IsActive")] Size size)
        {
            if (ModelState.IsValid)
            {
                _context.Add(size);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(size);
        }

        // GET: Sizes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var size = await _context.Size.SingleOrDefaultAsync(m => m.Id == id);
            if (size == null)
            {
                return NotFound();
            }
            return View(size);
        }

        // POST: Sizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Description,Length,Breath,Weight,Number,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,IsActive")] Size size)
        {
            if (id != size.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(size);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SizeExists(size.Id))
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
            return View(size);
        }

        // GET: Sizes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var size = await _context.Size
                .SingleOrDefaultAsync(m => m.Id == id);
            if (size == null)
            {
                return NotFound();
            }

            return View(size);
        }

        // POST: Sizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var size = await _context.Size.SingleOrDefaultAsync(m => m.Id == id);
            _context.Size.Remove(size);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SizeExists(long id)
        {
            return _context.Size.Any(e => e.Id == id);
        }
    }
}
