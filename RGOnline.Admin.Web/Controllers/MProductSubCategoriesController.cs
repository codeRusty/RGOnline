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
    public class MProductSubCategoriesController : Controller
    {
        private readonly RGOnlineContext _context;

        public MProductSubCategoriesController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: MProductSubCategories
        public async Task<IActionResult> Index()
        {
            var rGOnlineContext = _context.MProductSubCategory.Include(m => m.ProductCategory);
            return View(await rGOnlineContext.ToListAsync());
        }

        // GET: MProductSubCategories/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mProductSubCategory = await _context.MProductSubCategory
                .Include(m => m.ProductCategory)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (mProductSubCategory == null)
            {
                return NotFound();
            }

            return View(mProductSubCategory);
        }

        // GET: MProductSubCategories/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryId"] = new SelectList(_context.MProductCategory, "Id", "Id");
            return View();
        }

        // POST: MProductSubCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreatedBy,CreatedOn,Description,IsActive,ProductSubCategory,UpdatedBy,UpdatedOn,ProductCategoryId")] MProductSubCategory mProductSubCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mProductSubCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.MProductCategory, "Id", "Id", mProductSubCategory.ProductCategoryId);
            return View(mProductSubCategory);
        }

        // GET: MProductSubCategories/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mProductSubCategory = await _context.MProductSubCategory.SingleOrDefaultAsync(m => m.Id == id);
            if (mProductSubCategory == null)
            {
                return NotFound();
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.MProductCategory, "Id", "Id", mProductSubCategory.ProductCategoryId);
            return View(mProductSubCategory);
        }

        // POST: MProductSubCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,CreatedBy,CreatedOn,Description,IsActive,ProductSubCategory,UpdatedBy,UpdatedOn,ProductCategoryId")] MProductSubCategory mProductSubCategory)
        {
            if (id != mProductSubCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mProductSubCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MProductSubCategoryExists(mProductSubCategory.Id))
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
            ViewData["ProductCategoryId"] = new SelectList(_context.MProductCategory, "Id", "Id", mProductSubCategory.ProductCategoryId);
            return View(mProductSubCategory);
        }

        // GET: MProductSubCategories/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mProductSubCategory = await _context.MProductSubCategory
                .Include(m => m.ProductCategory)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (mProductSubCategory == null)
            {
                return NotFound();
            }

            return View(mProductSubCategory);
        }

        // POST: MProductSubCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var mProductSubCategory = await _context.MProductSubCategory.SingleOrDefaultAsync(m => m.Id == id);
            _context.MProductSubCategory.Remove(mProductSubCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MProductSubCategoryExists(long id)
        {
            return _context.MProductSubCategory.Any(e => e.Id == id);
        }
    }
}
