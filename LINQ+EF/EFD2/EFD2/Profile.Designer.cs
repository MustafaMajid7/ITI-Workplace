namespace EFD2
{
	partial class Profile
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
			lbl_email = new Label();
			txt_email = new TextBox();
			btn_confirm = new Button();
			label2 = new Label();
			txt_password = new TextBox();
			lbl_age = new Label();
			nud_age = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
			SuspendLayout();
			// 
			// lbl_email
			// 
			lbl_email.AutoSize = true;
			lbl_email.Location = new Point(55, 86);
			lbl_email.Name = "lbl_email";
			lbl_email.Size = new Size(36, 15);
			lbl_email.TabIndex = 0;
			lbl_email.Text = "Email";
			// 
			// txt_email
			// 
			txt_email.Location = new Point(125, 83);
			txt_email.Name = "txt_email";
			txt_email.Size = new Size(123, 23);
			txt_email.TabIndex = 1;
			// 
			// btn_confirm
			// 
			btn_confirm.Location = new Point(368, 174);
			btn_confirm.Name = "btn_confirm";
			btn_confirm.Size = new Size(102, 39);
			btn_confirm.TabIndex = 4;
			btn_confirm.Text = "Confirm";
			btn_confirm.UseVisualStyleBackColor = true;
			btn_confirm.Click += btn_confirm_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(302, 86);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 0;
			label2.Text = "Password";
			// 
			// txt_password
			// 
			txt_password.Location = new Point(388, 83);
			txt_password.Name = "txt_password";
			txt_password.Size = new Size(123, 23);
			txt_password.TabIndex = 2;
			// 
			// lbl_age
			// 
			lbl_age.AutoSize = true;
			lbl_age.Location = new Point(586, 86);
			lbl_age.Name = "lbl_age";
			lbl_age.Size = new Size(28, 15);
			lbl_age.TabIndex = 0;
			lbl_age.Text = "Age";
			// 
			// nud_age
			// 
			nud_age.Location = new Point(640, 84);
			nud_age.Name = "nud_age";
			nud_age.Size = new Size(120, 23);
			nud_age.TabIndex = 3;
			// 
			// Profile
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 296);
			Controls.Add(nud_age);
			Controls.Add(btn_confirm);
			Controls.Add(lbl_age);
			Controls.Add(txt_password);
			Controls.Add(label2);
			Controls.Add(txt_email);
			Controls.Add(lbl_email);
			Name = "Profile";
			Text = "Profile";
			((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbl_email;
		private TextBox txt_email;
		private Button btn_confirm;
		private Label label2;
		private TextBox txt_password;
		private Label lbl_age;
		private NumericUpDown nud_age;
	}
}