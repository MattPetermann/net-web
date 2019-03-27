using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataModelClasses.Models
{
	public class ProductContext
	{
		List<Product> _products;

		public ProductContext()
		{
			_products = new List<Product>()
			{
				new Product { Id=100, Name="CD", Price=10.00m},
				new Product { Id=101, Name="Printer", Price=200.00m},
				new Product { Id=102, Name="Stuffed Animal", Price=5.00m}
			};
		}

		public List<Product> GetProducts()
		{
			return _products;
		}

		public Product Find(int id) => _products.FirstOrDefault(p => p.Id == id);
	}
}