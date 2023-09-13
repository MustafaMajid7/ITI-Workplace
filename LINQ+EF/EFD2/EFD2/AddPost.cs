using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFD2
{
	public partial class AddPost : Form
	{
		dbContext dbContext;
		int id;
		public AddPost(int id)
		{
			InitializeComponent();
			dbContext = new dbContext();
			this.id = id;
		}

		private void AddPost_Load(object sender, EventArgs e)
		{
			cmb_cats.DataSource = dbContext.Catalogs.ToList();
			cmb_cats.DisplayMember = "name";
			cmb_cats.ValueMember = "id";
			cmb_cats.SelectedItem = 0;
		}
		private void btn_addPost_Click(object sender, EventArgs e)
		{
			if (txt_title.Text != string.Empty && txt_desc.Text != string.Empty)
			{
				dbContext.Posts.Add(new Post()
				{
					title = txt_title.Text,
					desc = txt_desc.Text,
					breif = txt_brf.Text,
					AuthorID = id,
					CatID = (int)cmb_cats.SelectedValue,
					date = dtp_postDate.Value,
				});
				dbContext.SaveChanges();
				MessageBox.Show("a new post is added");
				goback();
			}
			else
			{
				MessageBox.Show("you must fill required fields");
			}
		}

		private void btn_goBack_Click(object sender, EventArgs e)
		{
			goback();
		}
		public void goback()
		{
			Application.OpenForms[1].Show();
			this.Close();
		}
	}
}
