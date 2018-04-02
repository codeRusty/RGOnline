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
    public class MProductCategoriesController : Controller
    {
        private readonly RGOnlineContext _context;

        public MProductCategoriesController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: MProductCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.MProductCategory.ToListAsync());
        }

        // GET: MProductCategories/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mProductCategory = await _context.MProductCategory
                .SingleOrDefaultAsync(m => m.Id == id);
            if (mProductCategory == null)
            {
                return NotFound();
            }

            return View(mProductCategory);
        }

        // GET: MProductCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MProductCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreatedBy,CreatedOn,Description,IsActive,ProductCategory,UpdatedBy,UpdatedOn")] MProductCategory mProductCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mProductCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mProductCategory);
        }

        // GET: MProductCategories/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mProductCategory = await _context.MProductCategory.SingleOrDefaultAsync(m => m.Id == id);
            if (mProductCategory == null)
            {
                return NotFound();
            }
            return View(mProductCategory);
        }

        // POST: MProductCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,CreatedBy,CreatedOn,Description,IsActive,ProductCategory,UpdatedBy,UpdatedOn")] MProductCategory mProductCategory)
        {
            if (id != mProductCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mProductCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MProductCategoryExists(mProductCategory.Id))
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
            return View(mProductCategory);
        }

        // GET: MProductCategories/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mProductCategory = await _context.MProductCategory
                .SingleOrDefaultAsync(m => m.Id == id);
            if (mProductCategory == null)
            {
                return NotFound();
            }

            return View(mProductCategory);
        }

        // POST: MProductCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var mProductCategory = await _context.MProductCategory.SingleOrDefaultAsync(m => m.Id == id);
            _context.MProductCategory.Remove(mProductCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MProductCategoryExists(long id)
        {
            return _context.MProductCategory.Any(e => e.Id == id);
        }
    }
}
