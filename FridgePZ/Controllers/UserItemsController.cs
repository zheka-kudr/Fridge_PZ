using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FridgePZ.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FridgePZ.Controllers
{
    public class UserItemsController : Controller
    {
        private readonly fridgepzContext _context;

        public UserItemsController(fridgepzContext context)
        {
            _context = context;
        }

        public User ReturnUser()
        {
            String email = User.Identity.Name;
            fridgepzContext db = new fridgepzContext();
            var query = from p in db.User where p.Email.Equals(email) select p;
            User user = query.Single();
            return user;
        }

        // GET: Itempatterns
        public async Task<IActionResult> Index()
        {
            User cur_userid = ReturnUser();
            var query = from _item in _context.Item
                        join _shelf in _context.Shelf on _item.ShelfId equals _shelf.ShelfId
                        join _storage in _context.Storage on _shelf.StorageId equals _storage.StorageId
                        join _privilege in _context.Privilege on _storage.StorageId equals _privilege.StorageId
                        join _user in _context.User on _privilege.UserId equals _user.UserId
                        where _user.UserId == cur_userid.UserId
                        select _item;
            List<Item> item = query.ToList();
            return View(item);

        }

        // GET: Itempatterns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Itempatterns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Item.FindAsync(id);
            _context.Item.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Itempatterns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemPatternId,CategoryItemPatternId,BarCode,Unit,Size,Name,PhotoName,SeverityLevel,Capacity,LongLife")] Item item, IFormFile photoName)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (photoName == null)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        /*var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", photoName.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        await photoName.CopyToAsync(stream);*/
                        //item.PhotoName = Path.GetFileName(photoName.FileName);
                    }
                    _context.Update(item);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItempatternExists(item.ItemId))
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
            return View(item);
        }



        private bool ItempatternExists(int id)
        {
            return _context.Itempattern.Any(e => e.ItemPatternId == id);
        }
    }
}