namespace EFD2
{
	partial class Register
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
			btn_Register = new Button();
			label1 = new Label();
			nud_age = new NumericUpDown();
			txt_password = new TextBox();
			label2 = new Label();
			txt_email = new TextBox();
			label3 = new Label();
			txt_userName = new TextBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
			SuspendLayout();
			// 
			// btn_Register
			// 
			btn_Register.BackColor = SystemColors.ActiveCaption;
			btn_Register.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			btn_Register.ForeColor = Color.Black;
			btn_Register.Location = new Point(337, 128);
			btn_Register.Name = "btn_Register";
			btn_Register.Size = new Size(154, 46);
			btn_Register.TabIndex = 5;
			btn_Register.Text = "Register";
			btn_Register.UseVisualStyleBackColor = false;
			btn_Register.Click += btn_Register_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(483, 256);
			label1.Name = "label1";
			label1.Size = new Size(28, 15);
			label1.TabIndex = 1;
			label1.Text = "Age";
			// 
			// nud_age
			// 
			nud_age.Location = new Point(555, 253);
			nud_age.Name = "nud_age";
			nud_age.Size = new Size(153, 23);
			nud_age.TabIndex = 4;
			// 
			// txt_password
			// 
			txt_password.Location = new Point(555, 45);
			txt_password.Name = "txt_password";
			txt_password.Size = new Size(153, 23);
			txt_password.TabIndex = 2;
			txt_password.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(84, 256);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 1;
			label2.Text = "Email";
			// 
			// txt_email
			// 
			txt_email.Location = new Point(182, 253);
			txt_email.Name = "txt_email";
			txt_email.Size = new Size(153, 23);
			txt_email.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(84, 48);
			label3.Name = "label3";
			label3.Size = new Size(65, 15);
			label3.TabIndex = 1;
			label3.Text = "User Name";
			// 
			// txt_userName
			// 
			txt_userName.Location = new Point(182, 45);
			txt_userName.Name = "txt_userName";
			txt_userName.Size = new Size(153, 23);
			txt_userName.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(483, 48);
			label4.Name = "label4";
			label4.Size = new Size(57, 15);
			label4.TabIndex = 1;
			label4.Text = "Password";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(714, 32);
			label5.Name = "label5";
			label5.Size = new Size(17, 21);
			label5.TabIndex = 6;
			label5.Text = "*";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label6.Location = new Point(337, 32);
			label6.Name = "label6";
			label6.Size = new Size(17, 21);
			label6.TabIndex = 6;
			label6.Text = "*";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Firebrick;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(555, 139);
			label7.Name = "label7";
			label7.Size = new Size(130, 21);
			label7.TabIndex = 1;
			label7.Text = "* means required";
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(txt_userName);
			Controls.Add(txt_email);
			Controls.Add(txt_password);
			Controls.Add(label3);
			Controls.Add(nud_age);
			Controls.Add(label2);
			Controls.Add(label7);
			Controls.Add(label4);
			Controls.Add(label1);
			Controls.Add(btn_Register);
			Name = "Register";
			Text = "Register";
			((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_Register;
		private Label label1;
		private NumericUpDown nud_age;
		private TextBox txt_password;
		private Label label2;
		private TextBox txt_email;
		private Label label3;
		private TextBox txt_userName;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
	}
}