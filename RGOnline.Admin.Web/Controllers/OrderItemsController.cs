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
    public class OrderItemsController : Controller
    {
        private readonly RGOnlineContext _context;

        public OrderItemsController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: OrderItems
        public async Task<IActionResult> Index()
        {
            var rGOnlineContext = _context.OrderItem.Include(o => o.Order).Include(o => o.Product);
            return View(await rGOnlineContext.ToListAsync());
        }

        // GET: OrderItems/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItem
                .Include(o => o.Order)
                .Include(o => o.Product)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return View(orderItem);
        }

        // GET: OrderItems/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.Order, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name");
            return View();
        }

        // POST: OrderItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SalesFee,Quantity,CreatedOn,CreatedBy,UpdatedOn,ProductId,OrderId")] OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "Id", "Id", orderItem.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name", orderItem.ProductId);
            return View(orderItem);
        }

        // GET: OrderItems/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItem.SingleOrDefaultAsync(m => m.Id == id);
            if (orderItem == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "Id", "Id", orderItem.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name", orderItem.ProductId);
            return View(orderItem);
        }

        // POST: OrderItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,SalesFee,Quantity,CreatedOn,CreatedBy,UpdatedOn,ProductId,OrderId")] OrderItem orderItem)
        {
            if (id != orderItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderItemExists(orderItem.Id))
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
            ViewData["OrderId"] = new SelectList(_context.Order, "Id", "Id", orderItem.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name", orderItem.ProductId);
            return View(orderItem);
        }

        // GET: OrderItems/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItem
                .Include(o => o.Order)
                .Include(o => o.Product)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return View(orderItem);
        }

        // POST: OrderItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var orderItem = await _context.OrderItem.SingleOrDefaultAsync(m => m.Id == id);
            _context.OrderItem.Remove(orderItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderItemExists(long id)
        {
            return _context.OrderItem.Any(e => e.Id == id);
        }
    }
}
