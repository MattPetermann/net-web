using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class FreeController : Controller
    {
        // GET: Free
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bird(string name, int? age, string color)
        {
            ViewBag.Name = name ?? "Unknown";
            ViewBag.Age = age ?? -1;
            ViewBag.Color = color  ?? "N/A";
            return View();
        }
    }
}