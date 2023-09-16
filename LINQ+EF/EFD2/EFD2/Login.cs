namespace EFD2
{
	public partial class Login : Form
	{
		dbContext dbContext;
		public Login()
		{
			InitializeComponent();
			dbContext = new dbContext();
		}

		private void Login_Load(object sender, EventArgs e)
		{
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			if (txt_userName.Text == "" || txt_password.Text == "")
				MessageBox.Show($"you should enter username and password");
			else
			{
				Author? author = dbContext.Authors.Where(x => x.username == txt_userName.Text &&
					x.password == txt_password.Text).FirstOrDefault();
				if (author != null)
				{
					Home home = new Home(author.id);
					this.Hide();
					home.Show();
				}
				else
					MessageBox.Show("username or password is wrong");
			}
		}

		private void btn_register_Click(object sender, EventArgs e)
		{
			clearInputs();
			Register register = new Register();
			this.Hide();
			register.Show();
		}

		private void clearInputs()
		{
			txt_userName.Text = string.Empty;
			txt_password.Text = string.Empty;
		}

		private void btn_editProfile_Click(object sender, EventArgs e)
		{
			if (txt_userName.Text != string.Empty && txt_password.Text != string.Empty)
			{
				Author? author = dbContext.Authors.Where(x => x.username == txt_userName.Text &&
						x.password == txt_password.Text).FirstOrDefault();
				if (author != null)
				{
					clearInputs();
					Profile profile = new Profile(author.id, false);
					this.Hide();
					profile.Show();
					dbContext.SaveChanges();
				}
				else
					MessageBox.Show("you must enter correct username and password");
			}
			else
				MessageBox.Show("you must enter username and password");
		}

		private void btn_chgpass_Click(object sender, EventArgs e)
		{
			if (txt_userName.Text != string.Empty && txt_password.Text != string.Empty)
			{
				Author? author = dbContext.Authors.Where(x => x.username == txt_userName.Text &&
						x.password == txt_password.Text).FirstOrDefault();
				if (author != null)
				{
					clearInputs();
					Profile profile = new Profile(author.id, true);
					this.Hide();
					profile.Show();
					dbContext.SaveChanges();
				}
				else
					MessageBox.Show("you must enter correct username and password");
			}
			else
				MessageBox.Show("you must enter username and password");
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			Application.OpenForms[0].Close();
		}
	}
}