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

        //GET: Item
        public async Task<IActionResult> Index()
        {
            User cur_userid = ReturnUser();
            fridgepzContext db = new fridgepzContext();
            var query = from _item in _context.Item
                        join shelf in _context.Shelf on _item.ShelfId equals shelf.ShelfId
                        join storage in _context.Storage on shelf.StorageId equals storage.StorageId
                        join privilege in _context.Privilege on storage.StorageId equals privilege.StorageId
                        join user in _context.User on privilege.UserId equals user.UserId
                        join pattern in _context.Itempattern on _item.ItemPatternId equals pattern.ItemPatternId
                        where user.UserId == cur_userid.UserId
                        select _item;
            List< Item > item = query.ToList();
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
        public List<Item> returnItems()
        {
            User cur_userid = ReturnUser();
            fridgepzContext db = new fridgepzContext();
            var query = from _item in _context.Item
                        join shelf in _context.Shelf on _item.ShelfId equals shelf.ShelfId
                        join storage in _context.Storage on shelf.StorageId equals storage.StorageId
                        join privilege in _context.Privilege on storage.StorageId equals privilege.StorageId
                        join user in _context.User on privilege.UserId equals user.UserId
                        where user.UserId == cur_userid.UserId
                        select _item;
            List<Item> item = query.ToList();
            return item;
        }
    }
}