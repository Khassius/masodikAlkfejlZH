using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistryApp.DAO
{
	internal class CategoriesMemoryDao : ICategories
	{
		private IList<Category> categoriesList = new List<Category>();
		public bool AddCategory(Category category)
		{
			if (category == null)
				return false;
			//adding a category with same name is not allowed
			if (categoriesList.Any(x => x.CategoryName == category.CategoryName))
				return false;
			categoriesList.Add(category);
			return true;
		}

		public IEnumerable<Category> GetCategories()
		{
			return categoriesList;
		}

		public bool ModifyCategory(Category category)
		{
			int storedIndex = categoriesList.IndexOf(categoriesList.FirstOrDefault(x => x.CategoryName == category.CategoryName));
			if (storedIndex == -1)
				return false;
			categoriesList[storedIndex] = category;
			return true;
		}
	}
}
