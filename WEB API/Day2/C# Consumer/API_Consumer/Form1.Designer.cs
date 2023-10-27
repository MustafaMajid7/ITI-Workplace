namespace API_Consumer
{
	partial class Form1
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
			dgv_AllData = new DataGridView();
			btn_getStudents = new Button();
			btn_getDepartments = new Button();
			btn_AddStudent = new Button();
			NUD_STID = new NumericUpDown();
			label7 = new Label();
			btn_deleteST = new Button();
			btn_deleteDepart = new Button();
			label1 = new Label();
			NUD_DeptID = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)dgv_AllData).BeginInit();
			((System.ComponentModel.ISupportInitialize)NUD_STID).BeginInit();
			((System.ComponentModel.ISupportInitialize)NUD_DeptID).BeginInit();
			SuspendLayout();
			// 
			// dgv_AllData
			// 
			dgv_AllData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_AllData.Location = new Point(43, 166);
			dgv_AllData.Name = "dgv_AllData";
			dgv_AllData.RowTemplate.Height = 25;
			dgv_AllData.Size = new Size(709, 213);
			dgv_AllData.TabIndex = 0;
			dgv_AllData.RowHeaderMouseDoubleClick += dgv_AllData_RowHeaderMouseDoubleClick;
			// 
			// btn_getStudents
			// 
			btn_getStudents.Location = new Point(43, 129);
			btn_getStudents.Name = "btn_getStudents";
			btn_getStudents.Size = new Size(122, 31);
			btn_getStudents.TabIndex = 1;
			btn_getStudents.Text = "Get All Students";
			btn_getStudents.UseVisualStyleBackColor = true;
			btn_getStudents.Click += btn_getStudents_Click;
			// 
			// btn_getDepartments
			// 
			btn_getDepartments.Location = new Point(613, 129);
			btn_getDepartments.Name = "btn_getDepartments";
			btn_getDepartments.Size = new Size(139, 31);
			btn_getDepartments.TabIndex = 1;
			btn_getDepartments.Text = "Get All Departments";
			btn_getDepartments.UseVisualStyleBackColor = true;
			btn_getDepartments.Click += btn_getDepartments_Click;
			// 
			// btn_AddStudent
			// 
			btn_AddStudent.Location = new Point(344, 129);
			btn_AddStudent.Name = "btn_AddStudent";
			btn_AddStudent.Size = new Size(122, 31);
			btn_AddStudent.TabIndex = 1;
			btn_AddStudent.Text = "Add Student";
			btn_AddStudent.UseVisualStyleBackColor = true;
			btn_AddStudent.Click += btn_AddStudent_Click;
			// 
			// NUD_STID
			// 
			NUD_STID.Location = new Point(202, 22);
			NUD_STID.Name = "NUD_STID";
			NUD_STID.Size = new Size(132, 23);
			NUD_STID.TabIndex = 8;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(106, 24);
			label7.Name = "label7";
			label7.Size = new Size(59, 15);
			label7.TabIndex = 9;
			label7.Text = "StudentID";
			// 
			// btn_deleteST
			// 
			btn_deleteST.Location = new Point(487, 16);
			btn_deleteST.Name = "btn_deleteST";
			btn_deleteST.Size = new Size(122, 31);
			btn_deleteST.TabIndex = 10;
			btn_deleteST.Text = "Delete";
			btn_deleteST.UseVisualStyleBackColor = true;
			btn_deleteST.Click += btn_deleteST_Click;
			// 
			// btn_deleteDepart
			// 
			btn_deleteDepart.Location = new Point(487, 68);
			btn_deleteDepart.Name = "btn_deleteDepart";
			btn_deleteDepart.Size = new Size(122, 31);
			btn_deleteDepart.TabIndex = 10;
			btn_deleteDepart.Text = "Delete";
			btn_deleteDepart.UseVisualStyleBackColor = true;
			btn_deleteDepart.Click += btn_deleteDepart_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(106, 76);
			label1.Name = "label1";
			label1.Size = new Size(81, 15);
			label1.TabIndex = 9;
			label1.Text = "DepartmentID";
			// 
			// NUD_DeptID
			// 
			NUD_DeptID.Location = new Point(202, 74);
			NUD_DeptID.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			NUD_DeptID.Name = "NUD_DeptID";
			NUD_DeptID.Size = new Size(132, 23);
			NUD_DeptID.TabIndex = 8;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(NUD_DeptID);
			Controls.Add(NUD_STID);
			Controls.Add(label1);
			Controls.Add(label7);
			Controls.Add(btn_deleteDepart);
			Controls.Add(btn_deleteST);
			Controls.Add(btn_getDepartments);
			Controls.Add(btn_AddStudent);
			Controls.Add(btn_getStudents);
			Controls.Add(dgv_AllData);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dgv_AllData).EndInit();
			((System.ComponentModel.ISupportInitialize)NUD_STID).EndInit();
			((System.ComponentModel.ISupportInitialize)NUD_DeptID).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgv_AllData;
		private Button btn_getStudents;
		private Button btn_getDepartments;
		private Button btn_AddStudent;
		private NumericUpDown NUD_STID;
		private Label label7;
		private Button btn_deleteST;
		private Button btn_deleteDepart;
		private Label label1;
		private NumericUpDown NUD_DeptID;
	}
}