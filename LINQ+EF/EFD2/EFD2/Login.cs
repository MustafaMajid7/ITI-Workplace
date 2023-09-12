namespace EFD2
{
	public partial class Login : Form
	{
		dbContext dbContext;
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			using(dbContext = new dbContext()) { 
				if (txt_userName.Text == "" || txt_password.Text == "")
					MessageBox.Show($"you should enter username and password");
				else
				{
					Author? author = dbContext.Authors.Where(x => x.username == txt_userName.Text &&
						x.password == txt_password.Text).FirstOrDefault();
					if (author != null)
						MessageBox.Show("you will be directed to Home");
					else
						MessageBox.Show("username or password is wrong");
				}
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
			txt_userName.Text= string.Empty;
			txt_password.Text= string.Empty;
		}

	}
}