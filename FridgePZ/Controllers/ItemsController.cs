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
    public class ItemsController : Controller
    {
        private readonly fridgepzContext _context;

        public ItemsController(fridgepzContext context)
        {
            _context = context;
        }

        
        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }

        public User returnUser()
        {
            String email = User.Identity.Name;
            fridgepzContext db = new fridgepzContext();
            var query = from p in db.User where p.Email.Equals(email) select p;
            User user = query.Single();
            return user;
        }

        public async Task<IActionResult> Status()
        {
            User cur_user = returnUser();
            var query = from itempattern in _context.Itempattern
                        join item in _context.Item on itempattern.ItemPatternId equals item.ItemPatternId
                        join shelf in _context.Shelf on item.ShelfId equals shelf.ShelfId
                        join storage in _context.Storage on shelf.StorageId equals storage.StorageId
                        join privelege in _context.Privilege on storage.StorageId equals privelege.StorageId
                        join user in _context.User on privelege.UserId equals user.UserId
                        where user == cur_user && item.NotificationId == 1
                        select itempattern;
            return View(await query.ToListAsync());
        }
    }
}
