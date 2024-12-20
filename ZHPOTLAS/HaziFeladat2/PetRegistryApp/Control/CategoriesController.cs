using PetRegistryApp.DAO;
using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistryApp.Control
{
	public class CategoriesController
	{
		private readonly ICategories dao;
		public CategoriesController(ICategories categoriesDao)
		{
			dao = categoriesDao;
		}

		public bool AddCategory(Category category)
		{
			if(String.IsNullOrEmpty(category.CategoryName))
				return false;
			return dao.AddCategory(category);
		}

		public IEnumerable<Category> GetCategories()
		{
			return dao.GetCategories();
		}

		public bool ModifyCategory(Category category)
		{
			return dao.ModifyCategory(category);
		}

		

	}
}
