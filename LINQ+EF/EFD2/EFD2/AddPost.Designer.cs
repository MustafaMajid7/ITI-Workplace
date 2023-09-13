namespace EFD2
{
	partial class AddPost
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
			txt_title = new TextBox();
			label1 = new Label();
			btn_addPost = new Button();
			label2 = new Label();
			label3 = new Label();
			label5 = new Label();
			cmb_cats = new ComboBox();
			txt_brf = new TextBox();
			txt_desc = new TextBox();
			dtp_postDate = new DateTimePicker();
			label4 = new Label();
			btn_goBack = new Button();
			SuspendLayout();
			// 
			// txt_title
			// 
			txt_title.Location = new Point(147, 30);
			txt_title.Name = "txt_title";
			txt_title.Size = new Size(100, 23);
			txt_title.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(73, 33);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 1;
			label1.Text = "Title";
			// 
			// btn_addPost
			// 
			btn_addPost.Location = new Point(297, 234);
			btn_addPost.Name = "btn_addPost";
			btn_addPost.Size = new Size(111, 45);
			btn_addPost.TabIndex = 3;
			btn_addPost.Text = "Add Post";
			btn_addPost.UseVisualStyleBackColor = true;
			btn_addPost.Click += btn_addPost_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(73, 105);
			label2.Name = "label2";
			label2.Size = new Size(31, 15);
			label2.TabIndex = 1;
			label2.Text = "Brief";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(73, 178);
			label3.Name = "label3";
			label3.Size = new Size(67, 15);
			label3.TabIndex = 1;
			label3.Text = "Description";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(485, 41);
			label5.Name = "label5";
			label5.Size = new Size(63, 15);
			label5.TabIndex = 1;
			label5.Text = "Categories";
			// 
			// cmb_cats
			// 
			cmb_cats.FormattingEnabled = true;
			cmb_cats.Location = new Point(577, 33);
			cmb_cats.Name = "cmb_cats";
			cmb_cats.Size = new Size(121, 23);
			cmb_cats.TabIndex = 2;
			// 
			// txt_brf
			// 
			txt_brf.Location = new Point(147, 97);
			txt_brf.Name = "txt_brf";
			txt_brf.Size = new Size(100, 23);
			txt_brf.TabIndex = 0;
			// 
			// txt_desc
			// 
			txt_desc.Location = new Point(147, 170);
			txt_desc.Name = "txt_desc";
			txt_desc.Size = new Size(100, 23);
			txt_desc.TabIndex = 0;
			// 
			// dtp_postDate
			// 
			dtp_postDate.Location = new Point(498, 131);
			dtp_postDate.Name = "dtp_postDate";
			dtp_postDate.Size = new Size(200, 23);
			dtp_postDate.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(400, 137);
			label4.Name = "label4";
			label4.Size = new Size(71, 15);
			label4.TabIndex = 1;
			label4.Text = "Date of Post";
			// 
			// btn_goBack
			// 
			btn_goBack.Location = new Point(663, 235);
			btn_goBack.Name = "btn_goBack";
			btn_goBack.Size = new Size(92, 42);
			btn_goBack.TabIndex = 5;
			btn_goBack.Text = "Go Back";
			btn_goBack.UseVisualStyleBackColor = true;
			btn_goBack.Click += btn_goBack_Click;
			// 
			// AddPost
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_goBack);
			Controls.Add(dtp_postDate);
			Controls.Add(btn_addPost);
			Controls.Add(cmb_cats);
			Controls.Add(label4);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txt_desc);
			Controls.Add(txt_brf);
			Controls.Add(txt_title);
			Name = "AddPost";
			Text = "AddPost";
			Load += AddPost_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txt_title;
		private Label label1;
		private Button btn_addPost;
		private Label label2;
		private Label label3;
		private Label label5;
		private ComboBox cmb_cats;
		private TextBox txt_brf;
		private TextBox txt_desc;
		private DateTimePicker dtp_postDate;
		private Label label4;
		private Button btn_goBack;
	}
}