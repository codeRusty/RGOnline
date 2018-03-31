using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RGOnline.DataModels;
using RGOnline.DataAccess;

namespace RGOnline.Admin.Web.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly RGOnlineContext _context;

        public ProductCategoryController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: ProductCategory
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_ProductCategory.ToListAsync());
        }

        // GET: ProductCategory/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_ProductCategory = await _context.M_ProductCategory
                .SingleOrDefaultAsync(m => m.Id == id);
            if (m_ProductCategory == null)
            {
                return NotFound();
            }

            return View(m_ProductCategory);
        }

        // GET: ProductCategory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductCategory,Description,CreatedOn,UpdatedOn,CreatedBy,UpdatedBy,IsActive")] M_ProductCategory m_ProductCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_ProductCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_ProductCategory);
        }

        // GET: ProductCategory/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_ProductCategory = await _context.M_ProductCategory.SingleOrDefaultAsync(m => m.Id == id);
            if (m_ProductCategory == null)
            {
                return NotFound();
            }
            return View(m_ProductCategory);
        }

        // POST: ProductCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,ProductCategory,Description,CreatedOn,UpdatedOn,CreatedBy,UpdatedBy,IsActive")] M_ProductCategory m_ProductCategory)
        {
            if (id != m_ProductCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_ProductCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_ProductCategoryExists(m_ProductCategory.Id))
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
            return View(m_ProductCategory);
        }

        // GET: ProductCategory/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_ProductCategory = await _context.M_ProductCategory
                .SingleOrDefaultAsync(m => m.Id == id);
            if (m_ProductCategory == null)
            {
                return NotFound();
            }

            return View(m_ProductCategory);
        }

        // POST: ProductCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_ProductCategory = await _context.M_ProductCategory.SingleOrDefaultAsync(m => m.Id == id);
            _context.M_ProductCategory.Remove(m_ProductCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_ProductCategoryExists(long id)
        {
            return _context.M_ProductCategory.Any(e => e.Id == id);
        }
    }
}
