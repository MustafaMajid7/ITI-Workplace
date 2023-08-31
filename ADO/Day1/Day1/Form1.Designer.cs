namespace Day1
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
            dgv_courses = new DataGridView();
            txt_crs_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_add = new Button();
            NUD_duration = new NumericUpDown();
            cb_topID = new ComboBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_reset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_duration).BeginInit();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(40, 159);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.RowTemplate.Height = 25;
            dgv_courses.Size = new Size(697, 239);
            dgv_courses.TabIndex = 0;
            dgv_courses.RowHeaderMouseDoubleClick += dgv_courses_RowHeaderMouseDoubleClick;
            // 
            // txt_crs_name
            // 
            txt_crs_name.Location = new Point(390, 37);
            txt_crs_name.Name = "txt_crs_name";
            txt_crs_name.Size = new Size(120, 23);
            txt_crs_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 42);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "CRS_Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 42);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Crs_Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(563, 45);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 2;
            label4.Text = "Top_ID";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(450, 112);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 3;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // NUD_duration
            // 
            NUD_duration.Location = new Point(139, 38);
            NUD_duration.Name = "NUD_duration";
            NUD_duration.Size = new Size(120, 23);
            NUD_duration.TabIndex = 4;
            // 
            // cb_topID
            // 
            cb_topID.FormattingEnabled = true;
            cb_topID.Location = new Point(616, 37);
            cb_topID.Name = "cb_topID";
            cb_topID.Size = new Size(121, 23);
            cb_topID.TabIndex = 5;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(245, 114);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_Delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(662, 112);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(40, 114);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 8;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(btn_reset);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(cb_topID);
            Controls.Add(NUD_duration);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_crs_name);
            Controls.Add(dgv_courses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_duration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_courses;
        private TextBox txt_crs_name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_add;
        private NumericUpDown NUD_duration;
        private ComboBox cb_topID;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_reset;
    }
}