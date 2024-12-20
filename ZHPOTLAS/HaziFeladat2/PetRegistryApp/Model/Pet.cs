using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegistryApp.Model
{
	/// <summary>
	/// :)
	/// </summary>
	public class Pet
	{
		#region public Pet properties
		public long ID { get; set; }//prop+TAB+TAB
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public string Category { get; set; }
		#endregion
	}
}
