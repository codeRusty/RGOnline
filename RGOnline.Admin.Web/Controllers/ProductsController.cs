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
    public class ProductsController : Controller
    {
        private readonly RGOnlineContext _context;

        public ProductsController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var rGOnlineContext = _context.Product.Include(p => p.ProductSubCategory).Include(p => p.Season).Include(p => p.Size);
            return View(await rGOnlineContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.ProductSubCategory)
                .Include(p => p.Season)
                .Include(p => p.Size)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["ProductSubCategoryId"] = new SelectList(_context.MProductSubCategory, "Id", "Id");
            ViewData["SeasonId"] = new SelectList(_context.Season, "Id", "Name");
            ViewData["SizeId"] = new SelectList(_context.Size, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,Sku,SalesFee,Quantity,IsActive,ProductSubCategoryId,SizeId,SeasonId")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductSubCategoryId"] = new SelectList(_context.MProductSubCategory, "Id", "Id", product.ProductSubCategoryId);
            ViewData["SeasonId"] = new SelectList(_context.Season, "Id", "Name", product.SeasonId);
            ViewData["SizeId"] = new SelectList(_context.Size, "Id", "Name", product.SizeId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductSubCategoryId"] = new SelectList(_context.MProductSubCategory, "Id", "Id", product.ProductSubCategoryId);
            ViewData["SeasonId"] = new SelectList(_context.Season, "Id", "Name", product.SeasonId);
            ViewData["SizeId"] = new SelectList(_context.Size, "Id", "Name", product.SizeId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Description,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,Sku,SalesFee,Quantity,IsActive,ProductSubCategoryId,SizeId,SeasonId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            ViewData["ProductSubCategoryId"] = new SelectList(_context.MProductSubCategory, "Id", "Id", product.ProductSubCategoryId);
            ViewData["SeasonId"] = new SelectList(_context.Season, "Id", "Name", product.SeasonId);
            ViewData["SizeId"] = new SelectList(_context.Size, "Id", "Name", product.SizeId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.ProductSubCategory)
                .Include(p => p.Season)
                .Include(p => p.Size)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var product = await _context.Product.SingleOrDefaultAsync(m => m.Id == id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(long id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
