using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormData.DataLayer;

namespace FormData.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Register([Bind(Include ="CompanyName,Email,Password")] Customer customer)
		{
			using (NorthwndEntities db = new NorthwndEntities())
			{
				db.Customers.Add(customer);
				db.SaveChanges();
				return Redirect("/");
			}
		}
    }
}