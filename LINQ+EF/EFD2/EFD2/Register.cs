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
	public partial class Register : Form
	{
		dbContext dbContext;
		public Register()
		{
			InitializeComponent();
		}

		private void btn_Register_Click(object sender, EventArgs e)
		{
			using (dbContext = new dbContext())
			{
				var username = txt_userName.Text;
				var password = txt_password.Text;
				var email = txt_email.Text;
				var age = nud_age.Value;

				if (txt_userName.Text == "" || txt_password.Text == "")
					MessageBox.Show($"username and password must have values");
				else
				{
					var author = dbContext.Authors.Where(x => x.username == txt_userName.Text).FirstOrDefault();
					if (author == null)
					{
						dbContext.Authors.Add(new Author()
						{
							username = txt_userName.Text,
							password = txt_password.Text,
							email = txt_email.Text,
							age = (int)nud_age.Value,
							img = Path.GetFileName(OFD.FileName)
						});
						dbContext.SaveChanges();
						MessageBox.Show("successfully saved");
						Application.OpenForms[0].Show();
						this.Close();
					}
					else
						MessageBox.Show("this user is already taken, try another username");
				}
			}

		}

		private void btn_img_Click(object sender, EventArgs e)
		{
			OFD.Filter = "Images|*.png;*.jpg;*.jpeg";
			OFD.ShowDialog();
			lbl_img.Text = "Done";
		}
	}
}
