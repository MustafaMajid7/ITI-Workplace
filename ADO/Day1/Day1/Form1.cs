using System.Data;
using Microsoft.Data.SqlClient;

namespace Day1
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        int id;
        public Form1()
        {
            InitializeComponent();
            string connectionStr = "server=MOSTAFAMAGED\\SQLEXPRESS;Database=iti;Trusted_Connection=true;TrustServerCertificate=true";

            // define connection
            connection = new SqlConnection(connectionStr);
            //connection.ConnectionString = connectionStr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllCourses();
            GetTopics();
        }
        void GetAllCourses()
        {
            SqlCommand cmd = new SqlCommand("select [Crs_Id], [Crs_Name], [Crs_Duration], [Top_Id] from course;", connection);

            DataTable dt = new DataTable();
            try
            {
                connection.Open();

                // execute command

                SqlDataReader reader = cmd.ExecuteReader();

                // retrieve data

                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close connection
                connection.Close();
            }
            // display data

            btn_add.Visible = true;
            btn_delete.Visible = true;
            btn_update.Visible = true;

            dgv_courses.DataSource = dt;
        }
        void GetTopics()
        {
            //define command 
            SqlCommand cmd = new SqlCommand("select [Top_Id],[Top_Name] from Topic", connection);

            // open connection
            connection.Open();
            // execute command
            SqlDataReader reader = cmd.ExecuteReader();

            // retrieve data
            DataTable dt = new DataTable();
            dt.Load(reader);

            // close connection
            connection.Close();

            // display data
            cb_topID.DataSource = dt;

            cb_topID.DisplayMember = "Top_Name";
            cb_topID.ValueMember = "Top_id";
        }
        void ClearInputs()
        {
            txt_crs_name.Text = "";
            NUD_duration.Value = 0;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            //define command
            SqlCommand cmd = new SqlCommand($"insert into Course " +
                $"values(@courseName,@courseDuration,@TopID)", connection);
            cmd.Parameters.AddWithValue("courseName", txt_crs_name.Text);
            cmd.Parameters.AddWithValue("courseDuration", NUD_duration.Value);
            cmd.Parameters.AddWithValue("TopID", cb_topID.SelectedValue);
            int rowsEffected = 0;
            try
            {
                //open connection
                connection.Open();
                // execute command
                rowsEffected = cmd.ExecuteNonQuery();
                // retrieve data
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close connection
                connection.Close();
            }

            // display data
            if (rowsEffected > 0)
            {
                MessageBox.Show("Data added.");
                GetAllCourses();
            }
            ClearInputs();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Course set [Crs_Name] = @crs_name," +
                " [Crs_Duration] = @crs_duration,[Top_Id] = @top_id where Crs_Id = @crs_id;", connection);
            cmd.Parameters.AddWithValue("crs_name", txt_crs_name.Text);
            cmd.Parameters.AddWithValue("crs_duration", NUD_duration.Value);
            cmd.Parameters.AddWithValue("top_id", cb_topID.SelectedValue);
            cmd.Parameters.AddWithValue("crs_id", id);

            connection.Open();

            int rowsEffected = cmd.ExecuteNonQuery();

            connection.Close();

            if (rowsEffected > 0)
            {
                MessageBox.Show("Edit was done");
                GetAllCourses();
            }

            ClearInputs();
            //btn_add.Visible = true;
            //btn_delete.Visible = false;
            //btn_update.Visible = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Course where Crs_Id= @crs_id;", connection);

            cmd.Parameters.AddWithValue("crs_id", id);

            connection.Open();

            int rowsEffected = cmd.ExecuteNonQuery();

            connection.Close();

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data deleted");
                GetAllCourses();
            }
            ClearInputs();
            //btn_add.Visible = true;
            //btn_delete.Visible = false;
            //btn_edit.Visible = false;
        }

        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_courses.Rows[e.RowIndex];

            id = (int)row.Cells[0].Value;
            txt_crs_name.Text = row.Cells[1].Value as string;
            NUD_duration.Value = (int)row.Cells[2].Value;
            //cb_topID.SelectedValue = (int)((row.Cells[3].Value == DBNull.Value) ? 0 : row.Cells[3].Value);
            cb_topID.SelectedValue = row.Cells[3].Value ?? default;


            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            btn_add.Visible = true;
            btn_delete.Visible = true;
            btn_update.Visible = true;
            txt_crs_name.Text = "";
            NUD_duration.Value = 0;
            cb_topID.SelectedValue=0;
        }
    }
}