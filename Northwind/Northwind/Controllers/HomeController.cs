using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "Your product page.";

            return View();
        }

        public ActionResult Account()
        {
            ViewBag.Message = "Your account page.";

            return View();
        }

        public ActionResult Cart()
        {
            ViewBag.Message = "Your cart page.";

            return View();
        }
    }
}