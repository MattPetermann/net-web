using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataModelClasses.Models
{
	public class CategoryContext
	{
		private List<Category> _categories;

		public CategoryContext()
		{
			_categories = new List<Category> {
				new Category { Id=1, Name="Music"},
				new Category { Id=2, Name="Electronics"},
				new Category { Id=3, Name="Toys"}
			};
		}

		public Category Find(int id) => _categories.FirstOrDefault(c => c.Id == id);

		public List<Category> GetCategories()
		{
			return _categories;
		}
	}
}