using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistryApp.DAO
{
	public interface ICategories
	{
		bool AddCategory(Category category);
		bool ModifyCategory(Category category);
		IEnumerable<Category> GetCategories();
	}
}
