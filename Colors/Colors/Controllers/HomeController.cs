using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Colors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string color1, string color2)
        {
            ViewBag.Color1 = color1 ?? "";
            ViewBag.Color2 = color2 ?? "";
            return View();
        }
    }
}