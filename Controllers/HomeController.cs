using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_Management_System.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ItemImages()
        {
            return View();
        }
        public ActionResult Items()
        {
            return View();
        }
        public ActionResult OrderHistory()
        {
            return View();
        }
        public ActionResult Order()
        {
            return View();
        }
        public ActionResult OrderStatus()
        {
            return View();
        }
        public ActionResult ProductStatus()
        {
            return View();
        }
        public ActionResult Role()
        {
            return View();
        }
        public ActionResult User()
        {
            return View();
        }

    }
}