using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FridgePZ.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using FridgePZ.ViewModels; // пространство имен моделей RegisterModel и LoginModel
using FridgePZ.Models; // пространство имен UserContext и класса User
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using MySql.Data.MySqlClient;


namespace FridgePZ.Controllers
{
    public class HomeController : Controller
    {

        private readonly fridgepzContext _context;

        public HomeController(fridgepzContext context)
        {
            _context = context;
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

        public User returnUser()
        {
            String email = User.Identity.Name;
            fridgepzContext db = new fridgepzContext();
            var query = from p in db.User where p.Email.Equals(email) select p;
            User user = query.Single();
            return user;
        }
     

        public async Task<IActionResult> Index()
        {
            try
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
            catch (Exception e)
            {
                return RedirectToAction("Login", "Account");
            }
            
        }

        public IActionResult Index2()
        {
            return View();

        }

        public IActionResult IndexItem()
        {
            return RedirectToAction("Index", "Itempatterns");

        }

        public IActionResult CreateItem()
        {
            return RedirectToAction("Create", "Itempatterns");
        }

        public IActionResult ExpItems()
        {
            return RedirectToAction("Status", "Items");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
