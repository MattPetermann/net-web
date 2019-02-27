using Northwind.Models;
using System.Collections.Generic;
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
            ViewBag.Products = new List<Product>
            {
                new Product(1000, 249.99, "Bike"),
                new Product(1001, 24.99, "Helmet"),
                new Product(1002, 11.99, "Knee Pads"),
            };

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