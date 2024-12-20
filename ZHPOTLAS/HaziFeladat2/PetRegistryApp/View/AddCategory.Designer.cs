namespace PetRegistryApp.View
{
	partial class AddCategory
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
			cancelButton = new Button();
			defaultButton = new Button();
			okButton = new Button();
			label1 = new Label();
			categoryTextBox = new TextBox();
			SuspendLayout();
			// 
			// cancelButton
			// 
			cancelButton.AccessibleRole = AccessibleRole.None;
			cancelButton.BackColor = Color.PaleTurquoise;
			cancelButton.DialogResult = DialogResult.Cancel;
			cancelButton.FlatAppearance.BorderColor = Color.LightGreen;
			cancelButton.Location = new Point(228, 93);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(101, 34);
			cancelButton.TabIndex = 3;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = false;
			// 
			// defaultButton
			// 
			defaultButton.BackColor = Color.PaleTurquoise;
			defaultButton.Location = new Point(119, 93);
			defaultButton.Name = "defaultButton";
			defaultButton.Size = new Size(101, 34);
			defaultButton.TabIndex = 2;
			defaultButton.Text = "Default";
			defaultButton.UseVisualStyleBackColor = false;
			defaultButton.Click += defaultButton_Click;
			// 
			// okButton
			// 
			okButton.BackColor = Color.PaleTurquoise;
			okButton.DialogResult = DialogResult.OK;
			okButton.Location = new Point(12, 93);
			okButton.Name = "okButton";
			okButton.Size = new Size(101, 34);
			okButton.TabIndex = 1;
			okButton.Text = "OK";
			okButton.UseVisualStyleBackColor = false;
			okButton.Click += okButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 39);
			label1.Name = "label1";
			label1.Size = new Size(58, 15);
			label1.TabIndex = 0;
			label1.Text = "Category:";
			// 
			// categoryTextBox
			// 
			categoryTextBox.BackColor = Color.Aquamarine;
			categoryTextBox.Location = new Point(120, 36);
			categoryTextBox.Name = "categoryTextBox";
			categoryTextBox.Size = new Size(209, 23);
			categoryTextBox.TabIndex = 0;
			// 
			// AddCategory
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Bisque;
			ClientSize = new Size(341, 172);
			Controls.Add(categoryTextBox);
			Controls.Add(label1);
			Controls.Add(okButton);
			Controls.Add(defaultButton);
			Controls.Add(cancelButton);
			ForeColor = SystemColors.ControlText;
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AddCategory";
			Text = "AddCategory";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button cancelButton;
		private Button defaultButton;
		private Button okButton;
		private Label label1;
		private TextBox categoryTextBox;
	}
}