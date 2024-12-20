using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistryApp.DAO
{
	public class PetsMemoryDao : IPets //CTRL+. implement interfaces
	{

		private IList<Pet> petsList = new List<Pet>();

		public bool AddPet(Pet pet)
		{
			if(pet == null)
				return false;
			petsList.Add(pet);
			return true;
		}

		//not used
		public Pet GetPet(int petID)
		{
			return petsList.FirstOrDefault(x => x.ID == petID);
		}

		public IEnumerable<Pet> GetPets()
		{
			return petsList;
		}

		public bool ModifyPet(Pet pet)
		{
			int storedIndex = petsList.IndexOf(GetPet(unchecked((int)pet.ID)));
			if (storedIndex == -1)
				return false;
			petsList[storedIndex] = pet;
			return true;
		}

		public bool DeletePet(Pet pet) {
			return false;
		}

		//not used
		/*public int PetsCount()
		{
			return petsList.Count;
		}*/
	}
}
