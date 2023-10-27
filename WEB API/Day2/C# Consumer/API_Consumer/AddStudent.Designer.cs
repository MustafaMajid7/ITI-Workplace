namespace API_Consumer
{
	partial class AddStudent
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
			CMB_Supervisor = new ComboBox();
			CMB_Department = new ComboBox();
			NUD_Age = new NumericUpDown();
			txt_Address = new TextBox();
			txt_Lname = new TextBox();
			label4 = new Label();
			txt_Fname = new TextBox();
			label3 = new Label();
			label6 = new Label();
			label5 = new Label();
			label2 = new Label();
			label1 = new Label();
			btn_submit = new Button();
			btn_GoHome = new Button();
			((System.ComponentModel.ISupportInitialize)NUD_Age).BeginInit();
			SuspendLayout();
			// 
			// CMB_Supervisor
			// 
			CMB_Supervisor.FormattingEnabled = true;
			CMB_Supervisor.Location = new Point(566, 121);
			CMB_Supervisor.Name = "CMB_Supervisor";
			CMB_Supervisor.Size = new Size(121, 23);
			CMB_Supervisor.TabIndex = 6;
			// 
			// CMB_Department
			// 
			CMB_Department.FormattingEnabled = true;
			CMB_Department.Location = new Point(566, 89);
			CMB_Department.Name = "CMB_Department";
			CMB_Department.Size = new Size(121, 23);
			CMB_Department.TabIndex = 5;
			// 
			// NUD_Age
			// 
			NUD_Age.Location = new Point(566, 48);
			NUD_Age.Name = "NUD_Age";
			NUD_Age.Size = new Size(121, 23);
			NUD_Age.TabIndex = 4;
			// 
			// txt_Address
			// 
			txt_Address.Location = new Point(213, 127);
			txt_Address.Name = "txt_Address";
			txt_Address.Size = new Size(132, 23);
			txt_Address.TabIndex = 3;
			// 
			// txt_Lname
			// 
			txt_Lname.Location = new Point(213, 86);
			txt_Lname.Name = "txt_Lname";
			txt_Lname.Size = new Size(132, 23);
			txt_Lname.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(114, 130);
			label4.Name = "label4";
			label4.Size = new Size(49, 15);
			label4.TabIndex = 7;
			label4.Text = "Address";
			// 
			// txt_Fname
			// 
			txt_Fname.Location = new Point(213, 48);
			txt_Fname.Name = "txt_Fname";
			txt_Fname.Size = new Size(132, 23);
			txt_Fname.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(114, 89);
			label3.Name = "label3";
			label3.Size = new Size(63, 15);
			label3.TabIndex = 8;
			label3.Text = "Last Name";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(470, 127);
			label6.Name = "label6";
			label6.Size = new Size(62, 15);
			label6.TabIndex = 9;
			label6.Text = "Supervisor";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(470, 92);
			label5.Name = "label5";
			label5.Size = new Size(70, 15);
			label5.TabIndex = 10;
			label5.Text = "Department";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(470, 52);
			label2.Name = "label2";
			label2.Size = new Size(28, 15);
			label2.TabIndex = 11;
			label2.Text = "Age";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(114, 51);
			label1.Name = "label1";
			label1.Size = new Size(64, 15);
			label1.TabIndex = 12;
			label1.Text = "First Name";
			// 
			// btn_submit
			// 
			btn_submit.Location = new Point(356, 173);
			btn_submit.Name = "btn_submit";
			btn_submit.Size = new Size(122, 31);
			btn_submit.TabIndex = 7;
			btn_submit.Text = "Submit";
			btn_submit.UseVisualStyleBackColor = true;
			btn_submit.Click += btn_submit_Click;
			// 
			// btn_GoHome
			// 
			btn_GoHome.Location = new Point(580, 287);
			btn_GoHome.Name = "btn_GoHome";
			btn_GoHome.Size = new Size(122, 31);
			btn_GoHome.TabIndex = 7;
			btn_GoHome.Text = "Go Home";
			btn_GoHome.UseVisualStyleBackColor = true;
			btn_GoHome.Click += btn_GoHome_Click;
			// 
			// AddStudent
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(CMB_Supervisor);
			Controls.Add(CMB_Department);
			Controls.Add(NUD_Age);
			Controls.Add(txt_Address);
			Controls.Add(txt_Lname);
			Controls.Add(label4);
			Controls.Add(txt_Fname);
			Controls.Add(label3);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btn_GoHome);
			Controls.Add(btn_submit);
			Name = "AddStudent";
			Text = "AddStudent";
			Load += AddStudent_Load;
			((System.ComponentModel.ISupportInitialize)NUD_Age).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox CMB_Supervisor;
		private ComboBox CMB_Department;
		private NumericUpDown NUD_Age;
		private TextBox txt_Address;
		private TextBox txt_Lname;
		private Label label4;
		private TextBox txt_Fname;
		private Label label3;
		private Label label6;
		private Label label5;
		private Label label2;
		private Label label1;
		private Button btn_submit;
		private Button btn_GoHome;
	}
}