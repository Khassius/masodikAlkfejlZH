namespace PetRegistryApp.View
{
	partial class AddOrModifyPet
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
			okButton = new Button();
			cancelButton = new Button();
			defaultButton = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			petNameTextBox = new TextBox();
			maleRadioButton = new RadioButton();
			femaleRadioButton = new RadioButton();
			weightNumericUpDown = new NumericUpDown();
			categoryComboBox = new ComboBox();
			ageNumericUpDown = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)weightNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
			SuspendLayout();
			// 
			// okButton
			// 
			okButton.BackColor = Color.Turquoise;
			okButton.Location = new Point(10, 235);
			okButton.Name = "okButton";
			okButton.Size = new Size(101, 37);
			okButton.TabIndex = 7;
			okButton.Text = "OK";
			okButton.UseVisualStyleBackColor = false;
			okButton.Click += okButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.BackColor = Color.Turquoise;
			cancelButton.DialogResult = DialogResult.Cancel;
			cancelButton.Location = new Point(224, 235);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(101, 37);
			cancelButton.TabIndex = 9;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = false;
			// 
			// defaultButton
			// 
			defaultButton.BackColor = Color.Turquoise;
			defaultButton.Location = new Point(117, 235);
			defaultButton.Name = "defaultButton";
			defaultButton.Size = new Size(101, 37);
			defaultButton.TabIndex = 8;
			defaultButton.Text = "Default";
			defaultButton.UseVisualStyleBackColor = false;
			defaultButton.Click += defaultButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(26, 27);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 1;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(26, 54);
			label2.Name = "label2";
			label2.Size = new Size(45, 15);
			label2.TabIndex = 1;
			label2.Text = "Gender";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(26, 82);
			label3.Name = "label3";
			label3.Size = new Size(28, 15);
			label3.TabIndex = 1;
			label3.Text = "Age";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(26, 113);
			label4.Name = "label4";
			label4.Size = new Size(69, 15);
			label4.TabIndex = 1;
			label4.Text = "Weight (kg)";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(26, 142);
			label5.Name = "label5";
			label5.Size = new Size(55, 15);
			label5.TabIndex = 1;
			label5.Text = "Category";
			// 
			// petNameTextBox
			// 
			petNameTextBox.BackColor = Color.Aquamarine;
			petNameTextBox.Location = new Point(119, 24);
			petNameTextBox.Name = "petNameTextBox";
			petNameTextBox.Size = new Size(194, 23);
			petNameTextBox.TabIndex = 1;
			// 
			// maleRadioButton
			// 
			maleRadioButton.AutoSize = true;
			maleRadioButton.Location = new Point(119, 53);
			maleRadioButton.Name = "maleRadioButton";
			maleRadioButton.Size = new Size(51, 19);
			maleRadioButton.TabIndex = 2;
			maleRadioButton.TabStop = true;
			maleRadioButton.Text = "Male";
			maleRadioButton.UseVisualStyleBackColor = true;
			// 
			// femaleRadioButton
			// 
			femaleRadioButton.AutoSize = true;
			femaleRadioButton.Location = new Point(219, 53);
			femaleRadioButton.Name = "femaleRadioButton";
			femaleRadioButton.Size = new Size(63, 19);
			femaleRadioButton.TabIndex = 3;
			femaleRadioButton.TabStop = true;
			femaleRadioButton.Text = "Female";
			femaleRadioButton.UseVisualStyleBackColor = true;
			// 
			// weightNumericUpDown
			// 
			weightNumericUpDown.BackColor = Color.Aquamarine;
			weightNumericUpDown.DecimalPlaces = 1;
			weightNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
			weightNumericUpDown.Location = new Point(119, 107);
			weightNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			weightNumericUpDown.Minimum = new decimal(new int[] { 1316134911, 2328, 0, int.MinValue });
			weightNumericUpDown.Name = "weightNumericUpDown";
			weightNumericUpDown.Size = new Size(194, 23);
			weightNumericUpDown.TabIndex = 5;
			// 
			// categoryComboBox
			// 
			categoryComboBox.BackColor = Color.Aquamarine;
			categoryComboBox.FormattingEnabled = true;
			categoryComboBox.Items.AddRange(new object[] { "Default" });
			categoryComboBox.Location = new Point(118, 136);
			categoryComboBox.Name = "categoryComboBox";
			categoryComboBox.Size = new Size(195, 23);
			categoryComboBox.TabIndex = 6;
			// 
			// ageNumericUpDown
			// 
			ageNumericUpDown.BackColor = Color.Aquamarine;
			ageNumericUpDown.Location = new Point(118, 78);
			ageNumericUpDown.Minimum = new decimal(new int[] { 276447231, 23283, 0, int.MinValue });
			ageNumericUpDown.Name = "ageNumericUpDown";
			ageNumericUpDown.Size = new Size(195, 23);
			ageNumericUpDown.TabIndex = 4;
			// 
			// AddOrModifyPet
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Bisque;
			CancelButton = cancelButton;
			ClientSize = new Size(332, 288);
			Controls.Add(categoryComboBox);
			Controls.Add(ageNumericUpDown);
			Controls.Add(weightNumericUpDown);
			Controls.Add(femaleRadioButton);
			Controls.Add(maleRadioButton);
			Controls.Add(petNameTextBox);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(defaultButton);
			Controls.Add(cancelButton);
			Controls.Add(okButton);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AddOrModifyPet";
			StartPosition = FormStartPosition.CenterParent;
			Text = "AddOrModifyPet";
			Load += AddOrModifyPet_Load;
			((System.ComponentModel.ISupportInitialize)weightNumericUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button okButton;
		private Button cancelButton;
		private Button defaultButton;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox petNameTextBox;
		private RadioButton maleRadioButton;
		private RadioButton femaleRadioButton;
		private NumericUpDown weightNumericUpDown;
		private ComboBox categoryComboBox;
		private NumericUpDown ageNumericUpDown;
	}
}