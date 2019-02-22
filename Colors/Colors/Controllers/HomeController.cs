using System.Web.Mvc;
using Colors.Helpers;

namespace Colors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(FormCollection Form)
        {
            ViewBag.Colors = new Color[] {
                new Color("red", "#e74c3c"),
                new Color("yellow", "#f1c40f"),
                new Color("blue", "#2980b9")
            };

            ViewBag.Color1 = Form["color1"] ?? "";
            ViewBag.Color2 = Form["color2"] ?? "";
            ViewBag.Result = "";

            if (ViewBag.Color1 == "RED")
            {
                if (ViewBag.Color2 == "RED")
                {
                    ViewBag.Result = "RED";
                }
                else if (ViewBag.Color2 == "BLUE")
                {
                    ViewBag.Result = "PURPLE";
                }
                else if (ViewBag.Color2 == "YELLOW")
                {
                    ViewBag.Result = "ORANGE";
                }
            }
            else if (ViewBag.Color1 == "BLUE")
            {
                if (ViewBag.Color2 == "RED")
                {
                    ViewBag.Result = "PURPLE";
                }
                else if (ViewBag.Color2 == "BLUE")
                {
                    ViewBag.Result = "BLUE";
                }
                else if (ViewBag.Color2 == "YELLOW")
                {
                    ViewBag.Result = "GREEN";
                }
            }
            else if (ViewBag.Color1 == "YELLOW")
            {
                if (ViewBag.Color2 == "RED")
                {
                    ViewBag.Result = "ORANGE";
                }
                else if (ViewBag.Color2 == "BLUE")
                {
                    ViewBag.Result = "GREEN";
                }
                else if (ViewBag.Color2 == "YELLOW")
                {
                    ViewBag.Result = "YELLOW";
                }
            }

            return View();
        }
    }
}