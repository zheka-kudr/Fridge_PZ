using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FridgePZ.Models;
using MySql.Data.MySqlClient;
using System.Data;

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
            checkExpirationDate();
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

        public List<Item> returnItems()
        {
            var query = from _item in _context.Item
                        join _itempattern in _context.Itempattern
                        on _item.ItemPatternId equals _itempattern.ItemPatternId
                        select _item;
            List<Item> item = query.ToList();
            return item;
        }
        public void checkExpirationDate()
        {
            string constr = "Server=fridge-database.mysql.database.azure.com;Port=3306;Database=fridgepz;Uid=PZadmin@fridge-database;Pwd=Qwerty1!;";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("chceckExpirationDate", con))
                {
                    List<Item> item = returnItems();
                    User user = returnUser();

                    foreach (Item _item in item)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("itemIdT", _item.ItemId);
                        cmd.Parameters.AddWithValue("loginUser", user.Login);
                        cmd.Connection.Open();
                        var result = cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        cmd.Parameters.Clear();//<--clear all the parameters.
                    }
                }
            }
        }
    }
}
