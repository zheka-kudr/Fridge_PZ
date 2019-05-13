using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FridgePZ.Models;

namespace FridgePZ.Controllers
{
    public class CategoryitempatternsController : Controller
    {
        private readonly fridgepzContext _context;

        public CategoryitempatternsController(fridgepzContext context)
        {
            _context = context;
        }

        // GET: Categoryitempatterns
        public async Task<IActionResult> Index()
        {
            var fridgepzContext = _context.Categoryitempattern.Include(c => c.Notification).Include(c => c.Storage);
            return View(await fridgepzContext.ToListAsync());
        }

        // GET: Categoryitempatterns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryitempattern = await _context.Categoryitempattern
                .Include(c => c.Notification)
                .Include(c => c.Storage)
                .FirstOrDefaultAsync(m => m.CategoryItemPatternId == id);
            if (categoryitempattern == null)
            {
                return NotFound();
            }

            return View(categoryitempattern);
        }

        // GET: Categoryitempatterns/Create
        public IActionResult Create()
        {
            ViewData["NotificationId"] = new SelectList(_context.Notificationtype, "NotificationId", "Type");
            ViewData["StorageId"] = new SelectList(_context.Storage, "StorageId", "Name");
            return View();
        }

        // POST: Categoryitempatterns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryItemPatternId,StorageId,NotificationId,Name,Type,CurrentQuantity,ExpectedQuantity,ShopingFrequency")] Categoryitempattern categoryitempattern)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryitempattern);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NotificationId"] = new SelectList(_context.Notificationtype, "NotificationId", "Type", categoryitempattern.NotificationId);
            ViewData["StorageId"] = new SelectList(_context.Storage, "StorageId", "Name", categoryitempattern.StorageId);
            return View(categoryitempattern);
        }

        // GET: Categoryitempatterns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryitempattern = await _context.Categoryitempattern.FindAsync(id);
            if (categoryitempattern == null)
            {
                return NotFound();
            }
            ViewData["NotificationId"] = new SelectList(_context.Notificationtype, "NotificationId", "Type", categoryitempattern.NotificationId);
            ViewData["StorageId"] = new SelectList(_context.Storage, "StorageId", "Name", categoryitempattern.StorageId);
            return View(categoryitempattern);
        }

        // POST: Categoryitempatterns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryItemPatternId,StorageId,NotificationId,Name,Type,CurrentQuantity,ExpectedQuantity,ShopingFrequency")] Categoryitempattern categoryitempattern)
        {
            if (id != categoryitempattern.CategoryItemPatternId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryitempattern);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryitempatternExists(categoryitempattern.CategoryItemPatternId))
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
            ViewData["NotificationId"] = new SelectList(_context.Notificationtype, "NotificationId", "Type", categoryitempattern.NotificationId);
            ViewData["StorageId"] = new SelectList(_context.Storage, "StorageId", "Name", categoryitempattern.StorageId);
            return View(categoryitempattern);
        }

        // GET: Categoryitempatterns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryitempattern = await _context.Categoryitempattern
                .Include(c => c.Notification)
                .Include(c => c.Storage)
                .FirstOrDefaultAsync(m => m.CategoryItemPatternId == id);
            if (categoryitempattern == null)
            {
                return NotFound();
            }

            return View(categoryitempattern);
        }

        // POST: Categoryitempatterns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoryitempattern = await _context.Categoryitempattern.FindAsync(id);
            _context.Categoryitempattern.Remove(categoryitempattern);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryitempatternExists(int id)
        {
            return _context.Categoryitempattern.Any(e => e.CategoryItemPatternId == id);
        }
    }
}
