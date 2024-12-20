using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetRegistryApp.DAO
{
	

	internal class PetsAdoDao : IPets
	{

		//private const string CONNECTION_STRING = @"Data Source=../../../DB/pets.db;";
		private string CONNECTION_STRING = ConnectionManager.ConnectionString;
		public bool AddPet(Pet pet)
		{
			using SQLiteConnection connection = new SQLiteConnection(ConnectionManager.ConnectionString);
			connection.Open();

			SQLiteCommand command = connection.CreateCommand();
			//update Pets Set ... where ID 
			command.CommandText = "INSERT INTO Pets "
				+ "(Name, Gender, Age, Weight, Category) values "
				+ "(@name, @gender, @age, @weight, @category);";
			
			command.Parameters.Add("name", System.Data.DbType.String).Value = pet.Name;
			command.Parameters.Add("gender", System.Data.DbType.String).Value = pet.Gender;
			command.Parameters.Add("age", System.Data.DbType.Int32).Value = pet.Age;
			command.Parameters.Add("weight", System.Data.DbType.Decimal).Value = pet.Weight;
			command.Parameters.Add("category", System.Data.DbType.String).Value = pet.Category;

			bool ret = true;
			if (command.ExecuteNonQuery() != 1)
				ret = false;
			
			connection.Close();
			return ret;
			//throw new NotImplementedException();
		}

		public bool DeletePet(Pet pet)
		{
			using (SQLiteConnection connection = new SQLiteConnection(ConnectionManager.ConnectionString))
			{
				connection.Open();

				using (SQLiteCommand command = connection.CreateCommand())
				{
					command.CommandText = "DELETE FROM Pets WHERE id=@id";

					command.Parameters.Add("id", System.Data.DbType.Int32).Value = pet.ID;

					int rowsModified = command.ExecuteNonQuery();

					if (rowsModified > 0)
					{
						return true;
					}
					return false;
				}
			}
		}


		public Pet GetPet(int petID)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Pet> GetPets()
		{
			List<Pet> pets = new List<Pet>();	

			using SQLiteConnection connection = new SQLiteConnection(ConnectionManager.ConnectionString);
			connection.Open();

			SQLiteCommand command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM Pets";

			using var reader = command.ExecuteReader();

			while (reader.Read()) 
			{
				//reader.GetOrdinal("oszlop nev");
				pets.Add(new Pet { 
					ID = reader.GetInt32(reader.GetOrdinal("ID")),
					Name = reader.GetString(reader.GetOrdinal("Name")),
					Gender = reader.GetString(reader.GetOrdinal("Gender")),
					Age = reader.GetInt32(reader.GetOrdinal("Age")),
					Weight = reader.GetDecimal(reader.GetOrdinal("Weight")),
					Category = reader.GetString(reader.GetOrdinal("Category")),


				});
			}
			connection.Close();
			return pets;
			//throw new NotImplementedException();
		}

		public bool ModifyPet(Pet pet)
		{
			using SQLiteConnection connection = new SQLiteConnection(ConnectionManager.ConnectionString);
			connection.Open();

			SQLiteCommand command = connection.CreateCommand();
			command.CommandText = "UPDATE Pets SET "
				+ "Name=@name, Gender=@gender, Age=@age, Weight=@weight, Category=@category "
				+ "WHERE ID=@id";

			command.Parameters.Add("id", System.Data.DbType.Int32).Value = pet.ID;
			command.Parameters.Add("name", System.Data.DbType.String).Value = pet.Name;
			command.Parameters.Add("gender", System.Data.DbType.String).Value = pet.Gender;
			command.Parameters.Add("age", System.Data.DbType.Int32).Value = pet.Age;
			command.Parameters.Add("weight", System.Data.DbType.Decimal).Value = pet.Weight;
			command.Parameters.Add("category", System.Data.DbType.String).Value = pet.Category;

			bool ret = true;
			if (command.ExecuteNonQuery() != 1)
				ret = false;

			connection.Close();
			return ret;
		}
	}
}
