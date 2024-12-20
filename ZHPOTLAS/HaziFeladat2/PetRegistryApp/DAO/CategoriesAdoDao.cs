using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistryApp.DAO
{
	internal class CategoriesAdoDao : ICategories
	{
		//private const string CONNECTION_STRING = @"Data Source=../../../DB/pets.db;";
		private string CONNECTION_STRING = ConnectionManager.ConnectionString;
		public bool AddCategory(Category category)
		{
			using SQLiteConnection connection = new SQLiteConnection(ConnectionManager.ConnectionString);
			connection.Open();

			SQLiteCommand command = connection.CreateCommand();
			//update Pets Set ... where ID 
			command.CommandText = "INSERT OR IGNORE INTO Categories "
				+ "(CategoryName) values "
				+ "(@name);";

			command.Parameters.Add("name", System.Data.DbType.String).Value = category.CategoryName;
			

			bool ret = true;
			if (command.ExecuteNonQuery() != 1)
				ret = false;

			connection.Close();
			return ret;
			//throw new NotImplementedException();
		}

		public IEnumerable<Category> GetCategories()
		{
			List<Category> categories = new List<Category>();	

			using SQLiteConnection connection = new SQLiteConnection(ConnectionManager.ConnectionString);
			connection.Open();

			SQLiteCommand command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM Categories";

			using var reader = command.ExecuteReader();

			while (reader.Read()) 
			{
				//reader.GetOrdinal("oszlop nev");
				categories.Add(new Category { 
					CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
				});
			}
			connection.Close();
			return categories;
		}

		public bool ModifyCategory(Category category)
		{
			throw new NotImplementedException();
		}
	}
}
