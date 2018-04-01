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
    public class CartItemsController : Controller
    {
        private readonly RGOnlineContext _context;

        public CartItemsController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: CartItems
        public async Task<IActionResult> Index()
        {
            var rGOnlineContext = _context.CartItem.Include(c => c.Cart).Include(c => c.Product);
            return View(await rGOnlineContext.ToListAsync());
        }

        // GET: CartItems/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItem
                .Include(c => c.Cart)
                .Include(c => c.Product)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View(cartItem);
        }

        // GET: CartItems/Create
        public IActionResult Create()
        {
            ViewData["CartId"] = new SelectList(_context.Cart, "Id", "Name");
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name");
            return View();
        }

        // POST: CartItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CartId,ProductId")] CartItem cartItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CartId"] = new SelectList(_context.Cart, "Id", "Name", cartItem.CartId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name", cartItem.ProductId);
            return View(cartItem);
        }

        // GET: CartItems/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItem.SingleOrDefaultAsync(m => m.Id == id);
            if (cartItem == null)
            {
                return NotFound();
            }
            ViewData["CartId"] = new SelectList(_context.Cart, "Id", "Name", cartItem.CartId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name", cartItem.ProductId);
            return View(cartItem);
        }

        // POST: CartItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,CartId,ProductId")] CartItem cartItem)
        {
            if (id != cartItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartItemExists(cartItem.Id))
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
            ViewData["CartId"] = new SelectList(_context.Cart, "Id", "Name", cartItem.CartId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Name", cartItem.ProductId);
            return View(cartItem);
        }

        // GET: CartItems/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartItem = await _context.CartItem
                .Include(c => c.Cart)
                .Include(c => c.Product)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cartItem == null)
            {
                return NotFound();
            }

            return View(cartItem);
        }

        // POST: CartItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var cartItem = await _context.CartItem.SingleOrDefaultAsync(m => m.Id == id);
            _context.CartItem.Remove(cartItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartItemExists(long id)
        {
            return _context.CartItem.Any(e => e.Id == id);
        }
    }
}
