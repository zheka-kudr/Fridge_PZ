using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FridgePZ.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace FridgePZ.Controllers
{
    public class ItempatternsController : Controller
    {

        private readonly fridgepzContext _context;

        public ItempatternsController(fridgepzContext context)
        {
            _context = context;
        }

        // GET: Itempatterns
        public async Task<IActionResult> Index()
        {
            var fridgepzContext = _context.Itempattern.Include(i => i.CategoryItemPattern);
            return View(await fridgepzContext.ToListAsync());
        }
        

      

        // GET: Itempatterns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itempattern = await _context.Itempattern
                .Include(i => i.CategoryItemPattern)
                .FirstOrDefaultAsync(m => m.ItemPatternId == id);
            if (itempattern == null)
            {
                return NotFound();
            }

            return View(itempattern);
        }

        // GET: Itempatterns/Create
        public IActionResult Create()
        {
            ViewData["CategoryItemPatternId"] = new SelectList(_context.Categoryitempattern, "CategoryItemPatternId", "Name");
            return View();
        }

        // POST: Itempatterns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemPatternId,CategoryItemPatternId,BarCode,Unit,Size,Name,PhotoName,SeverityLevel,Capacity,LongLife")] Itempattern itempattern, IFormFile PhotoName)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itempattern);

                if (PhotoName == null)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", PhotoName.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    await PhotoName.CopyToAsync(stream);
                    itempattern.PhotoName = Path.GetFileNameWithoutExtension(PhotoName.FileName);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryItemPatternId"] = new SelectList(_context.Categoryitempattern, "CategoryItemPatternId", "Name", itempattern.CategoryItemPatternId);
            return View(itempattern);
        }

        // GET: Itempatterns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itempattern = await _context.Itempattern.FindAsync(id);
            if (itempattern == null)
            {
                return NotFound();
            }
            ViewData["CategoryItemPatternId"] = new SelectList(_context.Categoryitempattern, "CategoryItemPatternId", "Name", itempattern.CategoryItemPatternId);
            return View(itempattern);
        }

        // POST: Itempatterns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemPatternId,CategoryItemPatternId,BarCode,Unit,Size,Name,Capacity,LongLife,PhotoName")] Itempattern itempattern)
        {
            if (id != itempattern.ItemPatternId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itempattern);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItempatternExists(itempattern.ItemPatternId))
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
            ViewData["CategoryItemPatternId"] = new SelectList(_context.Categoryitempattern, "CategoryItemPatternId", "Name", itempattern.CategoryItemPatternId);
            return View(itempattern);
        }

        // GET: Itempatterns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itempattern = await _context.Itempattern
                .Include(i => i.CategoryItemPattern)
                .FirstOrDefaultAsync(m => m.ItemPatternId == id);
            if (itempattern == null)
            {
                return NotFound();
            }

            return View(itempattern);
        }

        // POST: Itempatterns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itempattern = await _context.Itempattern.FindAsync(id);
            _context.Itempattern.Remove(itempattern);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> UpdateStatus()
        {
                  
            return Redirect("/Home/Index");
        }


        private bool ItempatternExists(int id)
        {
            return _context.Itempattern.Any(e => e.ItemPatternId == id);
        }


        public List<Item> returnItems()
        {
            var query = from _item in _context.Item
                        join _itempattern in _context.Itempattern
                        on _item.ItemPatternId equals _itempattern.ItemPatternId
                        select _item;
            List<Item> item = query.ToList();
            return item;
        }

        public User returnUser()
        {
            String email = User.Identity.Name;
            fridgepzContext db = new fridgepzContext();
            var query = from p in db.User where p.Email.Equals(email) select p;
            User user = query.Single();
            return user;
        }

       

       
    }
}
