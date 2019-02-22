using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Colors.Helpers;

namespace Colors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string color1, string color2)
        {
            ViewBag.Colors = new Color[] {
                new Color("red"),
                new Color("yellow"),
                new Color("blue")
            };

            ViewBag.Color1 = color1 ?? "";
            ViewBag.Color2 = color2 ?? "";
            return View();
        }

        public ActionResult AddColors(FormCollection Form)
        {
            ViewBag.Color1 = Form["color1"];
            ViewBag.Color2 = Form["color2"];
            return View();
        }
    }
}