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
            return View();
        }
        public ActionResult Display()
        {
            return View();
        }
        public ActionResult Product(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return View();
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
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Customer()
        {
            return View();
        }
        public ActionResult Seller()
        {
            return View();
        }
        public ActionResult Table()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

    }
}