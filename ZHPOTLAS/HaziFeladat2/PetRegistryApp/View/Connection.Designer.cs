namespace PetRegistryApp.View
{
	partial class Connection
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
			connectionTextBox = new TextBox();
			label1 = new Label();
			okButton = new Button();
			cancelButton = new Button();
			SuspendLayout();
			// 
			// connectionTextBox
			// 
			connectionTextBox.BackColor = Color.Aquamarine;
			connectionTextBox.Location = new Point(164, 49);
			connectionTextBox.Name = "connectionTextBox";
			connectionTextBox.Size = new Size(209, 23);
			connectionTextBox.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 52);
			label1.Name = "label1";
			label1.Size = new Size(128, 15);
			label1.TabIndex = 5;
			label1.Text = "Add ConnectionString:";
			// 
			// okButton
			// 
			okButton.BackColor = Color.PaleTurquoise;
			okButton.DialogResult = DialogResult.OK;
			okButton.Location = new Point(30, 106);
			okButton.Name = "okButton";
			okButton.Size = new Size(101, 34);
			okButton.TabIndex = 6;
			okButton.Text = "OK";
			okButton.UseVisualStyleBackColor = false;
			okButton.Click += okButton_Click;
			// 
			// cancelButton
			// 
			cancelButton.AccessibleRole = AccessibleRole.None;
			cancelButton.BackColor = Color.PaleTurquoise;
			cancelButton.DialogResult = DialogResult.Cancel;
			cancelButton.FlatAppearance.BorderColor = Color.LightGreen;
			cancelButton.Location = new Point(272, 106);
			cancelButton.Name = "cancelButton";
			cancelButton.Size = new Size(101, 34);
			cancelButton.TabIndex = 8;
			cancelButton.Text = "Cancel";
			cancelButton.UseVisualStyleBackColor = false;
			cancelButton.Click += cancelButton_Click;
			// 
			// Connection
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(408, 183);
			Controls.Add(connectionTextBox);
			Controls.Add(label1);
			Controls.Add(okButton);
			Controls.Add(cancelButton);
			Name = "Connection";
			Text = "Connection";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox connectionTextBox;
		private Label label1;
		private Button okButton;
		private Button cancelButton;
	}
}