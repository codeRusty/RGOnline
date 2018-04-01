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
    public class SeasonsController : Controller
    {
        private readonly RGOnlineContext _context;

        public SeasonsController(RGOnlineContext context)
        {
            _context = context;
        }

        // GET: Seasons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Season.ToListAsync());
        }

        // GET: Seasons/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var season = await _context.Season
                .SingleOrDefaultAsync(m => m.Id == id);
            if (season == null)
            {
                return NotFound();
            }

            return View(season);
        }

        // GET: Seasons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Seasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,IsActive")] Season season)
        {
            if (ModelState.IsValid)
            {
                _context.Add(season);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(season);
        }

        // GET: Seasons/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var season = await _context.Season.SingleOrDefaultAsync(m => m.Id == id);
            if (season == null)
            {
                return NotFound();
            }
            return View(season);
        }

        // POST: Seasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,Description,CreatedOn,CreatedBy,UpdatedOn,UpdatedBy,IsActive")] Season season)
        {
            if (id != season.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(season);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeasonExists(season.Id))
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
            return View(season);
        }

        // GET: Seasons/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var season = await _context.Season
                .SingleOrDefaultAsync(m => m.Id == id);
            if (season == null)
            {
                return NotFound();
            }

            return View(season);
        }

        // POST: Seasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var season = await _context.Season.SingleOrDefaultAsync(m => m.Id == id);
            _context.Season.Remove(season);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeasonExists(long id)
        {
            return _context.Season.Any(e => e.Id == id);
        }
    }
}
