using PetRegistryApp.Control;
using PetRegistryApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetRegistryApp.View
{
	public partial class AddCategory : Form
	{
		private CategoriesController controller;
		public AddCategory(CategoriesController controller)
		{
			InitializeComponent();
			this.controller = controller;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			string categoryName = categoryTextBox.Text;
			#region Validation
			if (categoryName == string.Empty)
			{
				MessageBox.Show("Please provide a category!");
				return;
			}

			#endregion

			Category category = new Category()
			{
				CategoryName = categoryName
			};

			bool categoryResult;
			categoryResult = controller.AddCategory(category);
			if (categoryResult)
			{
				okButton.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Can't add existing category!");
				DialogResult = DialogResult.Abort;
			}
		}

		private void defaultButton_Click(object sender, EventArgs e)
		{
			categoryTextBox.Text = "Default";
		}
	}
}
