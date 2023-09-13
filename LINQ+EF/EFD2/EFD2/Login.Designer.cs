namespace EFD2
{
	partial class Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btn_login = new Button();
			btn_register = new Button();
			label1 = new Label();
			txt_userName = new TextBox();
			txt_password = new TextBox();
			label2 = new Label();
			btn_editProfile = new Button();
			btn_chgpass = new Button();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btn_login
			// 
			btn_login.Location = new Point(443, 215);
			btn_login.Name = "btn_login";
			btn_login.Size = new Size(116, 35);
			btn_login.TabIndex = 0;
			btn_login.Text = "Login";
			btn_login.UseVisualStyleBackColor = true;
			btn_login.Click += btn_login_Click;
			// 
			// btn_register
			// 
			btn_register.Location = new Point(640, 216);
			btn_register.Name = "btn_register";
			btn_register.Size = new Size(116, 35);
			btn_register.TabIndex = 1;
			btn_register.Text = "Register";
			btn_register.UseVisualStyleBackColor = true;
			btn_register.Click += btn_register_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(356, 51);
			label1.Name = "label1";
			label1.Size = new Size(65, 15);
			label1.TabIndex = 2;
			label1.Text = "User Name";
			// 
			// txt_userName
			// 
			txt_userName.Location = new Point(436, 48);
			txt_userName.Name = "txt_userName";
			txt_userName.Size = new Size(209, 23);
			txt_userName.TabIndex = 3;
			// 
			// txt_password
			// 
			txt_password.Location = new Point(437, 121);
			txt_password.Name = "txt_password";
			txt_password.PasswordChar = '#';
			txt_password.Size = new Size(209, 23);
			txt_password.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(357, 124);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 4;
			label2.Text = "Password";
			// 
			// btn_editProfile
			// 
			btn_editProfile.Location = new Point(245, 213);
			btn_editProfile.Name = "btn_editProfile";
			btn_editProfile.Size = new Size(104, 38);
			btn_editProfile.TabIndex = 6;
			btn_editProfile.Text = "Edit My Profile";
			btn_editProfile.UseVisualStyleBackColor = true;
			btn_editProfile.Click += btn_editProfile_Click;
			// 
			// btn_chgpass
			// 
			btn_chgpass.Location = new Point(41, 214);
			btn_chgpass.Name = "btn_chgpass";
			btn_chgpass.Size = new Size(111, 39);
			btn_chgpass.TabIndex = 7;
			btn_chgpass.Text = "Change Password";
			btn_chgpass.UseVisualStyleBackColor = true;
			btn_chgpass.Click += btn_chgpass_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.img2;
			pictureBox1.Location = new Point(100, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(199, 175);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 8;
			pictureBox1.TabStop = false;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 355);
			Controls.Add(pictureBox1);
			Controls.Add(btn_chgpass);
			Controls.Add(btn_editProfile);
			Controls.Add(txt_password);
			Controls.Add(label2);
			Controls.Add(txt_userName);
			Controls.Add(label1);
			Controls.Add(btn_register);
			Controls.Add(btn_login);
			Name = "Login";
			Text = "Login";
			Load += Login_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_login;
		private Button btn_register;
		private Label label1;
		private TextBox txt_userName;
		private TextBox txt_password;
		private Label label2;
		private Button btn_editProfile;
		private Button btn_chgpass;
		private PictureBox pictureBox1;
	}
}