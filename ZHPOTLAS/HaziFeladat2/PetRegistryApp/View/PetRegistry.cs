using PetRegistryApp.Control;
using PetRegistryApp.DAO;
using PetRegistryApp.Model;
using PetRegistryApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetRegistryApp.View
{
	public partial class PetRegistry : Form
	{
		private PetsController petsController;
		private CategoriesController categoriesController;
		public PetRegistry()
		{
			InitializeComponent();
			petsController = new PetsController(new PetsAdoDao());
			categoriesController = new CategoriesController(new CategoriesAdoDao());
		}

		private void loadPets()
		{
			dataGridView.Columns.Clear();
			dataGridView.DataSource = null;
			dataGridView.DataSource = this.petsController.GetPets().ToList();
			dataGridView.Columns[0].Visible = false;

			DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
			DeleteBtn.HeaderText = "Delete";
			DeleteBtn.Text = "Delete";
			DeleteBtn.UseColumnTextForButtonValue = true;
			dataGridView.Columns.Add(DeleteBtn);
		}

		private void listPetsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dataGridView.DataSource = null;
			dataGridView.Visible = true;
			this.loadPets();
		}

		private void itemClicked(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dataGridView.CurrentRow != null &&
				e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				Pet pet = (Pet)dataGridView.CurrentRow.DataBoundItem;

				if (dataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
				{
					var result = MessageBox.Show("Are you sure?", "Confirmation",
							MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (result == DialogResult.Yes)
					{
						petsController.DeletePet(pet);
						this.loadPets();
					}
				}
				else
				{
					using AddOrModifyPet addPetForm = new AddOrModifyPet(petsController, categoriesController, pet);//open window with a pet obj
					addPetForm.ShowDialog();
					this.loadPets();
				}
			}
		}

		private void addPetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using AddOrModifyPet addpetform = new AddOrModifyPet(petsController, categoriesController);
			DialogResult res = addpetform.ShowDialog();
			if (res == DialogResult.OK)
			{
				this.loadPets();
			}
		}

		private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddCategory addcategoryform = new AddCategory(categoriesController);
			addcategoryform.ShowDialog();
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
				saveFileDialog.Title = "SavedPetData";

				// Show the dialog and check if the user selected a file
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						// Open streamWriter to write to the file
						using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
						{
							// getting the list of pets
							IEnumerable<Pet> pets = petsController.GetPets();

							foreach (Pet pet in pets)
							{
								writer.WriteLine($"ID: {pet.ID}");
								writer.WriteLine($"Name: {pet.Name}");
								writer.WriteLine($"Gender: {pet.Gender}");
								writer.WriteLine($"Age: {pet.Age}");
								writer.WriteLine($"Weight: {pet.Weight} kg");
								writer.WriteLine($"Category: {pet.Category}");
								writer.WriteLine();
							}

							MessageBox.Show("Pet data saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		//private string _connectionString = @"Data Source=../../../DB/pets.db;";
		//private string _connectionString = @"Data Source="+ conn + ";";

		private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var connectionForm = new Connection())
			{
				if (connectionForm.ShowDialog() == DialogResult.OK)
				{
					MessageBox.Show("Connection string updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
