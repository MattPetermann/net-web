using System.Collections.Generic;
using System.Web.Mvc;
using Colors.Models;

namespace Colors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(FormCollection Form)
        {
            ViewBag.ColorOptions = new Dictionary<string, IColor>() {
                { "RED", new Red() },
                { "BLUE", new Blue() },
                { "YELLOW", new Yellow() }
            };

            ViewBag.Color1 = Form["color1"] ?? "RED";
            ViewBag.Color2 = Form["color2"] ?? "RED";
            ViewBag.Result = ViewBag.ColorOptions[ViewBag.Color1].Add(ViewBag.ColorOptions[ViewBag.Color2]);

            return View();
        }
    }
}