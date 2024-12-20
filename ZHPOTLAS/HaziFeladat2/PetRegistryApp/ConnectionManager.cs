using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistryApp
{
	internal class ConnectionManager
	{
		private static string _connectionString = @"Data Source=../../../DB/pets.db;";

		public static string ConnectionString
		{
			get => _connectionString;
			set
			{
				if (!string.IsNullOrWhiteSpace(value))
				{
					_connectionString = value;
				}
			}
		}

		public static void UpdateDatabasePath(string newPath)
		{
			// Update only the Data Source part
			var connectionParts = _connectionString.Split(';');
			for (int i = 0; i < connectionParts.Length; i++)
			{
				if (connectionParts[i].StartsWith("Data Source", StringComparison.OrdinalIgnoreCase))
				{
					connectionParts[i] = $"Data Source={newPath}";
					break;
				}
			}

			_connectionString = string.Join(";", connectionParts);
		}
	}
}
