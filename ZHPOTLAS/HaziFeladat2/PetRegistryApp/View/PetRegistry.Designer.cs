namespace PetRegistryApp.View
{
	partial class PetRegistry
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			menuStrip1 = new MenuStrip();
			listToolStripMenuItem = new ToolStripMenuItem();
			listPetsToolStripMenuItem = new ToolStripMenuItem();
			addToolStripMenuItem = new ToolStripMenuItem();
			addPetToolStripMenuItem = new ToolStripMenuItem();
			addCategoryToolStripMenuItem = new ToolStripMenuItem();
			exportToolStripMenuItem = new ToolStripMenuItem();
			connectionToolStripMenuItem = new ToolStripMenuItem();
			dataGridView = new DataGridView();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.Aquamarine;
			menuStrip1.Items.AddRange(new ToolStripItem[] { listToolStripMenuItem, addToolStripMenuItem, exportToolStripMenuItem, connectionToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// listToolStripMenuItem
			// 
			listToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listPetsToolStripMenuItem });
			listToolStripMenuItem.Name = "listToolStripMenuItem";
			listToolStripMenuItem.Size = new Size(37, 20);
			listToolStripMenuItem.Text = "&List";
			// 
			// listPetsToolStripMenuItem
			// 
			listPetsToolStripMenuItem.Name = "listPetsToolStripMenuItem";
			listPetsToolStripMenuItem.Size = new Size(96, 22);
			listPetsToolStripMenuItem.Text = "&Pets";
			listPetsToolStripMenuItem.Click += listPetsToolStripMenuItem_Click;
			// 
			// addToolStripMenuItem
			// 
			addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPetToolStripMenuItem, addCategoryToolStripMenuItem });
			addToolStripMenuItem.Name = "addToolStripMenuItem";
			addToolStripMenuItem.Size = new Size(41, 20);
			addToolStripMenuItem.Text = "&Add";
			// 
			// addPetToolStripMenuItem
			// 
			addPetToolStripMenuItem.Name = "addPetToolStripMenuItem";
			addPetToolStripMenuItem.Size = new Size(122, 22);
			addPetToolStripMenuItem.Text = "&Pet";
			addPetToolStripMenuItem.Click += addPetToolStripMenuItem_Click;
			// 
			// addCategoryToolStripMenuItem
			// 
			addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
			addCategoryToolStripMenuItem.Size = new Size(122, 22);
			addCategoryToolStripMenuItem.Text = "&Category";
			addCategoryToolStripMenuItem.Click += addCategoryToolStripMenuItem_Click;
			// 
			// exportToolStripMenuItem
			// 
			exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			exportToolStripMenuItem.Size = new Size(53, 20);
			exportToolStripMenuItem.Text = "Export";
			exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
			// 
			// connectionToolStripMenuItem
			// 
			connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
			connectionToolStripMenuItem.Size = new Size(81, 20);
			connectionToolStripMenuItem.Text = "Connection";
			connectionToolStripMenuItem.Click += connectionToolStripMenuItem_Click;
			// 
			// dataGridView
			// 
			dataGridView.BackgroundColor = Color.Bisque;
			dataGridView.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Bisque;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = Color.LightSalmon;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.Salmon;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = Color.Bisque;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView.Dock = DockStyle.Fill;
			dataGridView.GridColor = Color.Coral;
			dataGridView.Location = new Point(0, 24);
			dataGridView.Name = "dataGridView";
			dataGridView.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.Bisque;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = Color.LightSalmon;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridView.Size = new Size(800, 426);
			dataGridView.TabIndex = 1;
			dataGridView.CellMouseClick += itemClicked;
			// 
			// PetRegistry
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Bisque;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridView);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "PetRegistry";
			Text = "PetRegistry";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem listToolStripMenuItem;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem exportToolStripMenuItem;
		private ToolStripMenuItem listPetsToolStripMenuItem;
		private ToolStripMenuItem addPetToolStripMenuItem;
		private ToolStripMenuItem addCategoryToolStripMenuItem;
		private DataGridView dataGridView;
		private ToolStripMenuItem connectionToolStripMenuItem;
	}
}