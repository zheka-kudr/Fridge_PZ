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

        public void checkAwarenessDate()
        {
            string constr = "Server=fridge-database.mysql.database.azure.com;Port=3306;Database=fridgepz;Uid=PZadmin@fridge-database;Pwd=Qwerty1!;";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("checkProductAttention", con))
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
                checkAwarenessDate();
                return View();
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

        public IActionResult CatIndexItem()
        {
            return RedirectToAction("Index", "Categoryitempatterns");

        }

        public IActionResult CatCreateItem()
        {
            return RedirectToAction("Create", "Categoryitempatterns");
        }

        public IActionResult ExpItems()
        {
            return RedirectToAction("Status", "Items");
        }

        public IActionResult UserItems()
        {
            return RedirectToAction("Index","UserItems");
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
