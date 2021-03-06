﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModelClasses.Models;
using System.Data.Entity;
using DataModelClasses.DataLayer;

namespace DataModelClasses.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Products(int? id)
		{
			var products = (new ProductContext()).GetProducts();
			if (id == null)
				return View(products);
			else
				return View(products.Where(c => c.CategoryId == id));
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

		public ActionResult Category()
		{
			using (var db = new NorthwindEntities())
			{
				return View(db.Categories.OrderByDescending(c => c.CategoryName).ToList());
			}
		}
	}
}