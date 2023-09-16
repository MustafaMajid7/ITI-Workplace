namespace EFD2
{
	partial class Home
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
			dgv_posts = new DataGridView();
			btn_showAll = new Button();
			lbl_user = new Label();
			btn_addPost = new Button();
			btn_showMyP = new Button();
			btn_addCat = new Button();
			btn_showCat = new Button();
			PB_user = new PictureBox();
			btn_exit = new Button();
			((System.ComponentModel.ISupportInitialize)dgv_posts).BeginInit();
			((System.ComponentModel.ISupportInitialize)PB_user).BeginInit();
			SuspendLayout();
			// 
			// dgv_posts
			// 
			dgv_posts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgv_posts.Location = new Point(21, 108);
			dgv_posts.Name = "dgv_posts";
			dgv_posts.Size = new Size(454, 209);
			dgv_posts.TabIndex = 0;
			dgv_posts.RowHeaderMouseDoubleClick += dgv_posts_RowHeaderMouseDoubleClick;
			// 
			// btn_showAll
			// 
			btn_showAll.Location = new Point(29, 28);
			btn_showAll.Name = "btn_showAll";
			btn_showAll.Size = new Size(103, 34);
			btn_showAll.TabIndex = 1;
			btn_showAll.Text = "Show All Posts";
			btn_showAll.UseVisualStyleBackColor = true;
			btn_showAll.Click += btn_showAll_Click;
			// 
			// lbl_user
			// 
			lbl_user.AutoSize = true;
			lbl_user.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			lbl_user.Location = new Point(475, 9);
			lbl_user.Name = "lbl_user";
			lbl_user.Size = new Size(0, 22);
			lbl_user.TabIndex = 2;
			// 
			// btn_addPost
			// 
			btn_addPost.Location = new Point(345, 28);
			btn_addPost.Name = "btn_addPost";
			btn_addPost.Size = new Size(103, 34);
			btn_addPost.TabIndex = 1;
			btn_addPost.Text = "Add Post";
			btn_addPost.UseVisualStyleBackColor = true;
			btn_addPost.Click += btn_addPost_Click;
			// 
			// btn_showMyP
			// 
			btn_showMyP.Location = new Point(179, 28);
			btn_showMyP.Name = "btn_showMyP";
			btn_showMyP.Size = new Size(105, 34);
			btn_showMyP.TabIndex = 1;
			btn_showMyP.Text = "Show My Posts";
			btn_showMyP.UseVisualStyleBackColor = true;
			btn_showMyP.Click += btn_showMyP_Click;
			// 
			// btn_addCat
			// 
			btn_addCat.Location = new Point(255, 68);
			btn_addCat.Name = "btn_addCat";
			btn_addCat.Size = new Size(109, 34);
			btn_addCat.TabIndex = 3;
			btn_addCat.Text = "Add Catalog";
			btn_addCat.UseVisualStyleBackColor = true;
			btn_addCat.Click += btn_addCat_Click;
			// 
			// btn_showCat
			// 
			btn_showCat.Location = new Point(103, 68);
			btn_showCat.Name = "btn_showCat";
			btn_showCat.Size = new Size(115, 34);
			btn_showCat.TabIndex = 3;
			btn_showCat.Text = "Show All Catalogs";
			btn_showCat.UseVisualStyleBackColor = true;
			btn_showCat.Click += btn_showCat_Click;
			// 
			// PB_user
			// 
			PB_user.Location = new Point(557, 17);
			PB_user.Name = "PB_user";
			PB_user.Size = new Size(227, 208);
			PB_user.TabIndex = 4;
			PB_user.TabStop = false;
			// 
			// btn_exit
			// 
			btn_exit.BackColor = Color.Red;
			btn_exit.Location = new Point(491, 266);
			btn_exit.Name = "btn_exit";
			btn_exit.Size = new Size(77, 43);
			btn_exit.TabIndex = 10;
			btn_exit.Text = "Exit";
			btn_exit.UseVisualStyleBackColor = false;
			btn_exit.Click += btn_exit_Click;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 329);
			Controls.Add(btn_exit);
			Controls.Add(PB_user);
			Controls.Add(btn_addCat);
			Controls.Add(btn_showCat);
			Controls.Add(lbl_user);
			Controls.Add(btn_showMyP);
			Controls.Add(btn_addPost);
			Controls.Add(btn_showAll);
			Controls.Add(dgv_posts);
			Name = "Home";
			Text = "Home";
			((System.ComponentModel.ISupportInitialize)dgv_posts).EndInit();
			((System.ComponentModel.ISupportInitialize)PB_user).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgv_posts;
		private Button btn_showAll;
		private Label lbl_user;
		private Button btn_addPost;
		private Button btn_showMyP;
		private Button btn_addCat;
		private Button btn_showCat;
		private PictureBox PB_user;
		private Button btn_exit;
	}
}