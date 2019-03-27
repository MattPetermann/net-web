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
			return View(ProductContext.GetProducts());
		}

		public ActionResult Index()
		{
			return View();
		}
	}
}