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
	public partial class Profile : Form
	{
		dbContext dbContext;
		int id;
		bool ChangePassword;
		public Profile()
		{
			InitializeComponent();
		}
		public Profile(int id, bool ChangePassword)
		{
			InitializeComponent();
			dbContext = new dbContext();
			this.id = id;
			this.ChangePassword = ChangePassword;
			if (ChangePassword)
			{
				txt_email.Visible = false;
				nud_age.Visible = false;
				lbl_age.Visible = false;
				lbl_email.Visible = false;
			}
		}

		private void btn_confirm_Click(object sender, EventArgs e)
		{
			Author author = dbContext.Authors.Where(x => x.id == id).SingleOrDefault();
			author.password = txt_password.Text;
			if (!ChangePassword) { 
				author.age = (int)nud_age.Value;
				author.email = txt_email.Text;
			}
			dbContext.SaveChanges();
			MessageBox.Show("changes are done successfully");
			Application.OpenForms[0].Show();
			this.Close();
		}
	}
}
