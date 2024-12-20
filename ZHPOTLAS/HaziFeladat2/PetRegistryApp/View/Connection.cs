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
	public partial class Connection : Form
	{

		public string ConnectionString { get; private set; }

		public Connection()
		{
			InitializeComponent();
			var connectionParts = ConnectionManager.ConnectionString.Split(';');
			foreach (var part in connectionParts)
			{
				if (part.StartsWith("Data Source", StringComparison.OrdinalIgnoreCase))
				{
					connectionTextBox.Text = part.Replace("Data Source=", "").Trim();
					break;
				}
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			string newPath = connectionTextBox.Text.Trim(); // Get the new path from the TextBox
			ConnectionManager.UpdateDatabasePath(newPath);  // Update only the Data Source part
			DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
