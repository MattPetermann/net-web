using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModelClasses.Models;

namespace DataModelClasses.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Products()
		{
			return View((new ProductContext()).GetProducts());
		}

		public ActionResult Product(int id)
		{
			return View((new ProductContext()).Find(id));
		}

		public ActionResult Categories()
		{
			return View((new CategoryContext()).GetCategories());
		}

		public ActionResult Index()
		{
			return View();
		}
	}
}