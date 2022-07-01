using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Controllers
{
    public class HomeController : Controller
    {
        InventoryContext db = new InventoryContext();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = "Muhammad Rameez";
            return View();
        }
        public ActionResult Display(Product product)
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }
        [HttpPost]
        public ActionResult Product(Product product)
        {
            //string filename = DateTime.UtcNow.Ticks + ".jpg";
            //file.SaveAs(Server.MapPath("~/productImage/") + filename);
            //product.Image = filename;
            db.Products.Add(product);
            db.SaveChanges();
            return Redirect("/Home/Table");
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult ProductImages()
        {
            return View();
        }
        public ActionResult User()
        {
            List<User> users = db.Users.ToList();
            return View(users);
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Customer()
        {
            List<User> customers = db.Users.Where(x => x.RoleId == 2).ToList();
            return View(customers);
        }
        public ActionResult Seller()
        {
            List<User> sellers = db.Users.Where(x => x.RoleId == 3).ToList();
            return View(sellers);
        }
        public ActionResult Table()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

    }
}