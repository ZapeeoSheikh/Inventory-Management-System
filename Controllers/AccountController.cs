using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Controllers
{
    public class AccountController : Controller
    {
        InventoryContext db = new InventoryContext();
        // GET: Account
        public ActionResult Account()
        {
            return View();
        }
        public ActionResult History()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            User dbuser = db.Users.Where(m => m.email == user.email && m.password == user.password).FirstOrDefault();
            if (dbuser == null)
            {
                ViewBag.Error = "Your email or password is incorrect";
                return View();
            }
            HttpCookie mycookie = new HttpCookie("userCookie");
            mycookie.Value = dbuser.AccessToken;
            mycookie.Expires = DateTime.UtcNow.AddDays(5).AddHours(5);
            Response.Cookies.Remove("userCookie");
            Response.Cookies.Add(mycookie);
            return Redirect("/Home/Index");
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User user)
        {
            user.RoleId = 2;
            user.AccessToken = DateTime.UtcNow.Ticks.ToString();
            db.Users.Add(user);
            db.SaveChanges();

            HttpCookie myCookie = new HttpCookie("userCookie");
            myCookie.Value = user.AccessToken;
            myCookie.Expires = DateTime.UtcNow.AddDays(5).AddHours(5);
            Response.Cookies.Remove("userCookie");
            Response.Cookies.Add(myCookie);
            return Redirect("/Account/Login");
        }
        public ActionResult Return()
        {
            return View();
        }
    }
}



