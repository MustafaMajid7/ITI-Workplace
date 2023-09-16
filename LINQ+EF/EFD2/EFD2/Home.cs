using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFD2
{
	public partial class Home : Form
	{
		dbContext dbContext;
		int id;
		string imgpath = @"E:\\ITI\\workplace\\LINQ+EF\\EFD2\\src\\";
		public Home()
		{
			InitializeComponent();
		}

		public Home(int id)
		{
			InitializeComponent();
			dbContext = new dbContext();
			this.id = id;
			Author author = dbContext.Authors.Where(x => x.id == id).FirstOrDefault();
			lbl_user.Text = "Hello " + author.username;
			string image = imgpath + author.username + ".jpg";
			Bitmap bm = new Bitmap(image);
			PB_user.Image = bm;
		}

		private void btn_showAll_Click(object sender, EventArgs e)
		{
			dgv_posts.DataSource = dbContext.Posts.ToList();
		}

		private void btn_showMyP_Click(object sender, EventArgs e)
		{
			dgv_posts.DataSource = dbContext.Posts.Where(x => x.AuthorID == id).ToList();

		}

		private void btn_addPost_Click(object sender, EventArgs e)
		{
			AddPost addPost = new AddPost(id);
			this.Hide();
			addPost.Show();
		}

		private void btn_showCat_Click(object sender, EventArgs e)
		{
			dgv_posts.DataSource = dbContext.Catalogs.ToList();
		}

		private void btn_addCat_Click(object sender, EventArgs e)
		{
			CatalogForm catalogForm = new CatalogForm();
			this.Hide();
			catalogForm.Show();
		}

		private void dgv_posts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewRow dr = dgv_posts.Rows[e.RowIndex];
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			Application.OpenForms[0].Close();
		}
	}
}
