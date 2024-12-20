using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistryApp.DAO
{
	public interface IPets
	{
		#region Pet procedures
		bool AddPet(Pet pet);
		bool ModifyPet(Pet pet);
		IEnumerable<Pet> GetPets();
		Pet GetPet(int petID);
		//int PetsCount();not used

		bool DeletePet(Pet pet);
		#endregion
	}
}
