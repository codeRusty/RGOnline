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
    public class SupplierCategoryController : Controller
    {
        private readonly RGOnlineContext _context;

        public SupplierCategoryController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: SupplierCategory
        public async Task<IActionResult> Index()
        {
            return View(await _context.M_SupplierCategory.ToListAsync());
        }

        // GET: SupplierCategory/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_SupplierCategory = await _context.M_SupplierCategory
                .SingleOrDefaultAsync(m => m.Id == id);
            if (m_SupplierCategory == null)
            {
                return NotFound();
            }

            return View(m_SupplierCategory);
        }

        // GET: SupplierCategory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SupplierCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SupplierCategory,Description,CreatedOn,UpdatedOn,CreatedBy,UpdatedBy,IsActive")] M_SupplierCategory m_SupplierCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(m_SupplierCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(m_SupplierCategory);
        }

        // GET: SupplierCategory/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_SupplierCategory = await _context.M_SupplierCategory.SingleOrDefaultAsync(m => m.Id == id);
            if (m_SupplierCategory == null)
            {
                return NotFound();
            }
            return View(m_SupplierCategory);
        }

        // POST: SupplierCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,SupplierCategory,Description,CreatedOn,UpdatedOn,CreatedBy,UpdatedBy,IsActive")] M_SupplierCategory m_SupplierCategory)
        {
            if (id != m_SupplierCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(m_SupplierCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!M_SupplierCategoryExists(m_SupplierCategory.Id))
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
            return View(m_SupplierCategory);
        }

        // GET: SupplierCategory/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var m_SupplierCategory = await _context.M_SupplierCategory
                .SingleOrDefaultAsync(m => m.Id == id);
            if (m_SupplierCategory == null)
            {
                return NotFound();
            }

            return View(m_SupplierCategory);
        }

        // POST: SupplierCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var m_SupplierCategory = await _context.M_SupplierCategory.SingleOrDefaultAsync(m => m.Id == id);
            _context.M_SupplierCategory.Remove(m_SupplierCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool M_SupplierCategoryExists(long id)
        {
            return _context.M_SupplierCategory.Any(e => e.Id == id);
        }
    }
}
