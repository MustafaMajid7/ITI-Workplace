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
	public partial class CatalogForm : Form
	{
		public CatalogForm()
		{
			InitializeComponent();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if (txt_name.Text == string.Empty)
				MessageBox.Show("you must enter at least Catalog Name");
			else
			{
				dbContext dbContext = new dbContext();
				dbContext.Catalogs.Add(new Catalog()
				{
					name = txt_name.Text,
					desc = txt_desc.Text,
				});
				MessageBox.Show("a new catalog has been added");
				dbContext.SaveChanges();
				goback();
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
