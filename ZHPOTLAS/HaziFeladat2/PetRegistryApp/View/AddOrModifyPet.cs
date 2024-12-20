using PetRegistryApp.Control;
using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdGen;


namespace PetRegistryApp.View
{

	public partial class AddOrModifyPet : Form
	{
		private PetsController petsController;
		private CategoriesController categoriesController;
		private IdGenerator generator = new IdGenerator(1);
		private readonly long petID;
		private readonly bool IsModify = false;
		public AddOrModifyPet(PetsController controller, CategoriesController categoriesController)
		{
			InitializeComponent();
			this.petsController = controller;
			this.categoriesController = categoriesController;
			LoadCategories();
		}

		public AddOrModifyPet(PetsController petsController, CategoriesController categoriesController, Pet pet) : this(petsController, categoriesController)
		{
			IsModify = true;
			petID = pet.ID;
			petNameTextBox.Text = pet.Name;
			ageNumericUpDown.Value = pet.Age;
			weightNumericUpDown.Value = pet.Weight;
			if (pet.Gender == "Male")
			{
				maleRadioButton.Checked = true;
			}
			else
			{
				femaleRadioButton.Checked = true;
			}
			categoryComboBox.SelectedIndex = categoryComboBox.Items.IndexOf(pet.Category);

		}

		private void okButton_Click(object sender, EventArgs e)
		{
			int ID = unchecked((int)generator.CreateId());
			string name = petNameTextBox.Text;
			string gender;
			int age = (int)ageNumericUpDown.Value;
			decimal weight = (decimal)weightNumericUpDown.Value;

			#region Validations
			if (name == string.Empty)
			{
				MessageBox.Show("Please provide the pets name!");
				return;
			}
			if (maleRadioButton.Checked)
			{
				gender = "Male";
			}
			else if (femaleRadioButton.Checked)
			{
				gender = "Female";
			}
			else
			{
				MessageBox.Show("Please select a gender!");
				return;
			}
			if (age < 0)
			{
				MessageBox.Show("The pet's age can't be negative, please check again!");
				return;
			}
			if (weight < 0)
			{
				MessageBox.Show("The pet can't weigh negative, please check again!");
				return;
			}
			if (weight == 0)
			{
				MessageBox.Show("The pet can't be 0 kgs, please check again!");
				return;
			}


			if (categoryComboBox.Items.Count == 0)
			{

				MessageBox.Show("There are no categories available, please add a category first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			#endregion
			string category = categoryComboBox.SelectedItem.ToString();

			Pet pet = new Pet()
			{
				ID = ID,
				Name = name,
				Gender = gender,
				Age = age,
				Weight = weight,
				Category = category
			};

			bool result = false;
			if (IsModify)
			{
				pet.ID = petID;
				result = petsController.ModifyPet(pet);
			}
			else
			{
				result = petsController.AddPet(pet);

			}

			if (!result)
			{
				MessageBox.Show("Couldn't add the pet!");
				DialogResult = DialogResult.Abort;
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void defaultButton_Click(object sender, EventArgs e)
		{
			petNameTextBox.Text = "Default";
			maleRadioButton.Checked = true;
			ageNumericUpDown.Value = 1;
			weightNumericUpDown.Value = 1;
			if (categoryComboBox.Items.Count > 0)
			{
				categoryComboBox.SelectedIndex = 0;
			}
			else
			{
				MessageBox.Show("There are no categories available, please add a category first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		private void LoadCategories()
		{
			IEnumerable<Category> categories = categoriesController.GetCategories();

			categoryComboBox.Items.Clear();

			foreach (var category in categories)
			{
				categoryComboBox.Items.Add(category.CategoryName);
			}

			if (categoryComboBox.Items.Count > 0)
			{
				categoryComboBox.SelectedIndex = 0;
			}
		}

		private void AddOrModifyPet_Load(object sender, EventArgs e)
		{

		}
	}
}
