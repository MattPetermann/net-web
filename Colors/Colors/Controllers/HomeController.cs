using System.Collections.Generic;
using System.Web.Mvc;
using Colors.Models;

namespace Colors.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Controller for the Index view.
        /// </summary>
        /// <param name="Form">Form with dropdowns of Color names</param>
        /// <returns>Updated View</returns>
        public ActionResult Index(FormCollection Form)
        {
            //Build a dictionary of Color keyed by the Color name
            ViewBag.ColorOptions = new Dictionary<string, IColor>() {
                { "RED", new Red() },
                { "BLUE", new Blue() },
                { "YELLOW", new Yellow() }
            };

            //Grab the items and combine them or use default values
            ViewBag.Color1 = Form["color1"] ?? "RED";
            ViewBag.Color2 = Form["color2"] ?? "RED";
            ViewBag.Result = ViewBag.ColorOptions[ViewBag.Color1].Add(ViewBag.ColorOptions[ViewBag.Color2]);

            //Rerender the View
            return View();
        }
    }
}