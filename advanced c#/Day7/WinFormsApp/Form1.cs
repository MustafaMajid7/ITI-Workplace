namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click_MouseClick(object sender, MouseEventArgs e)
        {
            ShowDialog.Show("can you hit me");
        }
    }
}