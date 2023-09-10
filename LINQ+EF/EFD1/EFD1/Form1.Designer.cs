namespace EFD1
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
            dgv_student = new DataGridView();
            btn_Add = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_Delete = new Button();
            label5 = new Label();
            btn_Update = new Button();
            label3 = new Label();
            label4 = new Label();
            txt_Name = new TextBox();
            txt_Address = new TextBox();
            nud_ID = new NumericUpDown();
            nud_Age = new NumericUpDown();
            cmbx_supervisor = new ComboBox();
            cmbx_department = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_ID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Age).BeginInit();
            SuspendLayout();
            // 
            // dgv_student
            // 
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(12, 119);
            dgv_student.Name = "dgv_student";
            dgv_student.RowTemplate.Height = 25;
            dgv_student.Size = new Size(776, 211);
            dgv_student.TabIndex = 0;
            dgv_student.RowHeaderMouseDoubleClick += dgv_student_RowHeaderMouseDoubleClick;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(672, 12);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 87);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Supervisor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 46);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(122, 12);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 87);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 10;
            label5.Text = "Age";
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(405, 12);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 2;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 46);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(594, 46);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Address";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(391, 44);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(124, 23);
            txt_Name.TabIndex = 5;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(659, 44);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(114, 23);
            txt_Address.TabIndex = 6;
            // 
            // nud_ID
            // 
            nud_ID.Location = new Point(107, 41);
            nud_ID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_ID.Name = "nud_ID";
            nud_ID.Size = new Size(140, 23);
            nud_ID.TabIndex = 4;
            // 
            // nud_Age
            // 
            nud_Age.Location = new Point(107, 79);
            nud_Age.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Age.Name = "nud_Age";
            nud_Age.Size = new Size(140, 23);
            nud_Age.TabIndex = 7;
            // 
            // cmbx_supervisor
            // 
            cmbx_supervisor.FormattingEnabled = true;
            cmbx_supervisor.Location = new Point(391, 81);
            cmbx_supervisor.Name = "cmbx_supervisor";
            cmbx_supervisor.Size = new Size(124, 23);
            cmbx_supervisor.TabIndex = 8;
            // 
            // cmbx_department
            // 
            cmbx_department.FormattingEnabled = true;
            cmbx_department.Location = new Point(659, 81);
            cmbx_department.Name = "cmbx_department";
            cmbx_department.Size = new Size(114, 23);
            cmbx_department.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(583, 87);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 8;
            label6.Text = "Department";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 342);
            Controls.Add(cmbx_department);
            Controls.Add(cmbx_supervisor);
            Controls.Add(nud_Age);
            Controls.Add(nud_ID);
            Controls.Add(txt_Address);
            Controls.Add(txt_Name);
            Controls.Add(label5);
            Controls.Add(btn_Update);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Delete);
            Controls.Add(label1);
            Controls.Add(btn_Add);
            Controls.Add(dgv_student);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_ID).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_student;
        private Button btn_Add;
        private Label label1;
        private Label label2;
        private Button btn_Delete;
        private Label label5;
        private Button btn_Update;
        private Label label3;
        private Label label4;
        private TextBox txt_Name;
        private TextBox txt_Address;
        private NumericUpDown nud_ID;
        private NumericUpDown nud_Age;
        private ComboBox cmbx_supervisor;
        private ComboBox cmbx_department;
        private Label label6;
    }
}