using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RGOnline.DataAccess;
using RGOnline.DataModels;

namespace RGOnline.Admin.Web.Controllers
{
    public class ProductSubCategoryController : Controller
    {
        private readonly RGOnlineContext _context;

        public ProductSubCategoryController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: ProductSubCategory
        public async Task<IActionResult> Index()
        {
            var rGOnlineContext = _context.M_ProductSubCategory.Include(m => m.M_ProductCategory);
            return View(await rGOnlineContext.ToListAsync());
        }

        // GET: ProductSubCategory/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_ProductSubCategory = await _context.M_ProductSubCategory
                .Include(m => m.M_ProductCategory)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (m_ProductSubCategory == null)
            {
                return NotFound();
            }

            return View(m_ProductSubCategory);
        }

        // GET: ProductSubCategory/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryID"] = new SelectList(_context.M_ProductCategory, "Id", "Id");
            return View();
        }

        // POST: ProductSubCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductSubCategory,Description,CreatedOn,UpdatedOn,CreatedBy,UpdatedBy,IsActive,ProductCategoryID")] M_ProductSubCategory m_ProductSubCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_ProductSubCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductCategoryID"] = new SelectList(_context.M_ProductCategory, "Id", "Id", m_ProductSubCategory.ProductCategoryID);
            return View(m_ProductSubCategory);
        }

        // GET: ProductSubCategory/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_ProductSubCategory = await _context.M_ProductSubCategory.SingleOrDefaultAsync(m => m.Id == id);
            if (m_ProductSubCategory == null)
            {
                return NotFound();
            }
            ViewData["ProductCategoryID"] = new SelectList(_context.M_ProductCategory, "Id", "Id", m_ProductSubCategory.ProductCategoryID);
            return View(m_ProductSubCategory);
        }

        // POST: ProductSubCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,ProductSubCategory,Description,CreatedOn,UpdatedOn,CreatedBy,UpdatedBy,IsActive,ProductCategoryID")] M_ProductSubCategory m_ProductSubCategory)
        {
            if (id != m_ProductSubCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_ProductSubCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_ProductSubCategoryExists(m_ProductSubCategory.Id))
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
            ViewData["ProductCategoryID"] = new SelectList(_context.M_ProductCategory, "Id", "Id", m_ProductSubCategory.ProductCategoryID);
            return View(m_ProductSubCategory);
        }

        // GET: ProductSubCategory/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_ProductSubCategory = await _context.M_ProductSubCategory
                .Include(m => m.M_ProductCategory)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (m_ProductSubCategory == null)
            {
                return NotFound();
            }

            return View(m_ProductSubCategory);
        }

        // POST: ProductSubCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_ProductSubCategory = await _context.M_ProductSubCategory.SingleOrDefaultAsync(m => m.Id == id);
            _context.M_ProductSubCategory.Remove(m_ProductSubCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_ProductSubCategoryExists(long id)
        {
            return _context.M_ProductSubCategory.Any(e => e.Id == id);
        }
    }
}
