using System.Collections.Generic;
using System.Web.Mvc;

namespace Balloons.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult ViewCart(FormCollection collection)
        {
            string[] keys = collection.AllKeys;
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            
            foreach(string key in keys)
            {
                keyValuePairs.Add(key, collection[key]);
            }

            ViewBag.FormResults = keyValuePairs;

            return View();
        }
    }
}