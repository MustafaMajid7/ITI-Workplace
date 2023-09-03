namespace Topic
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
            dgv_topic = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txt_TopicName = new TextBox();
            btn_add = new Button();
            btn_show = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            nud_topicID = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgv_topic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_topicID).BeginInit();
            SuspendLayout();
            // 
            // dgv_topic
            // 
            dgv_topic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_topic.Location = new Point(111, 136);
            dgv_topic.Name = "dgv_topic";
            dgv_topic.RowTemplate.Height = 25;
            dgv_topic.Size = new Size(327, 233);
            dgv_topic.TabIndex = 0;
            dgv_topic.RowHeaderMouseDoubleClick += dgv_topic_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(111, 35);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 2;
            label1.Text = "Topic_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(111, 85);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 2;
            label2.Text = "Topic_Name";
            // 
            // txt_TopicName
            // 
            txt_TopicName.Location = new Point(311, 85);
            txt_TopicName.Name = "txt_TopicName";
            txt_TopicName.Size = new Size(128, 23);
            txt_TopicName.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(531, 89);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(120, 23);
            btn_add.TabIndex = 3;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(531, 35);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(120, 23);
            btn_show.TabIndex = 3;
            btn_show.Text = "Show Topic Name";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += button_show_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(671, 89);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(117, 23);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(671, 35);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(117, 23);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // nud_topicID
            // 
            nud_topicID.Location = new Point(311, 37);
            nud_topicID.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            nud_topicID.Name = "nud_topicID";
            nud_topicID.Size = new Size(128, 23);
            nud_topicID.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            Controls.Add(nud_topicID);
            Controls.Add(btn_update);
            Controls.Add(btn_show);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_TopicName);
            Controls.Add(dgv_topic);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_topic).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_topicID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_topic;
        private Label label1;
        private Label label2;
        private TextBox txt_TopicName;
        private Button btn_add;
        private Button btn_show;
        private Button btn_delete;
        private Button btn_update;
        private NumericUpDown nud_topicID;
    }
}