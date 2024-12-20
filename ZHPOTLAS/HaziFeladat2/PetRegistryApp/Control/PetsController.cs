using PetRegistryApp.DAO;
using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistryApp.Control
{
	public class PetsController
	{
		private readonly IPets dao;
        public PetsController(IPets petsDao)//ctor+TAB
        {
            dao = petsDao;
        }

        public bool AddPet(Pet pet) 
        {
            //if no Name was given then wont add
            if (String.IsNullOrEmpty(pet.Name))
                return false;
            return dao.AddPet(pet);
        }

        public IEnumerable<Pet> GetPets()
        {
            return dao.GetPets();
        }

        public Pet GetPet(int petID)
        { 
            return dao.GetPet(petID);
        }

        public bool ModifyPet(Pet pet)
        {
            return dao.ModifyPet(pet);
        }

        public bool DeletePet(Pet pet) 
        {
            return dao.DeletePet(pet);
        }

       /* public int GetPetsCount()
        {
            return dao.PetsCount();
        }*/
    }
}
