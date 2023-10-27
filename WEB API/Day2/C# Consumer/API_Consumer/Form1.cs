

using System.Windows.Forms;
using System;

namespace API_Consumer
{
	public partial class Form1 : Form
	{
		HttpClient httpClient;
		System.Windows.Forms.Timer glowTime = new System.Windows.Forms.Timer();
		public Form1()
		{
			InitializeComponent();
			httpClient = new HttpClient();
			httpClient.BaseAddress = new Uri("https://localhost:7081");
			glowTime.Interval = 1000;
		}

		private void btn_getStudents_Click(object sender, EventArgs e)
		{
			var response = httpClient.GetAsync("/api/Student").Result;
			if (response.IsSuccessStatusCode)
			{
				List<Student> students = response.Content.ReadAsAsync<List<Student>>().Result;
				dgv_AllData.DataSource = students;
			}
		}

		private void btn_getDepartments_Click(object sender, EventArgs e)
		{
			var response = httpClient.GetAsync("/api/Department").Result;
			if (response.IsSuccessStatusCode)
			{
				List<Department> departments = response.Content.ReadAsAsync<List<Department>>().Result;
				dgv_AllData.DataSource = departments;
			}
		}

		private void btn_AddStudent_Click(object sender, EventArgs e)
		{
			AddStudent addStudent = new AddStudent(0);
			this.Hide();
			addStudent.Show();
		}

		private void btn_deleteST_Click(object sender, EventArgs e)
		{
			string url = "/api/student/" + NUD_STID.Value;
			var resp = httpClient.DeleteAsync(url).Result;

			if (resp.IsSuccessStatusCode)
			{
				var response = httpClient.GetAsync("/api/student").Result;
				List<Student> students = response.Content.ReadAsAsync<List<Student>>().Result;
				dgv_AllData.DataSource = students;
				MessageBox.Show("Student deleted successfully");
			}
			else
			{
				MessageBox.Show(resp.StatusCode.ToString());
			}
		}

		private void btn_deleteDepart_Click(object sender, EventArgs e)
		{
			DialogResult confirmResult = MessageBox.Show("Are you sure to delete this department??", "Confirm Delete!!", MessageBoxButtons.YesNo);

			if (confirmResult == DialogResult.Yes)
			{
				string url = "/api/department/" + NUD_DeptID.Value;
				var resp = httpClient.DeleteAsync(url).Result;

				if (resp.IsSuccessStatusCode)
				{
					MessageBox.Show("Department deleted successfully");
				}
				else
				{
					MessageBox.Show("Sorry, department has instructors in it!!");
				}
			}
			var response = httpClient.GetAsync("/api/department").Result;
			List<Department> departments = response.Content.ReadAsAsync<List<Department>>().Result;
			dgv_AllData.DataSource = departments;

		}

		private void dgv_AllData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			glowTime.Enabled = true;
			dgv_AllData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkViolet;

			var response = MessageBox.Show("do you want to edit this row?", "Editing Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
			if (response == DialogResult.Yes)
			{
				DataGridViewRow dr = dgv_AllData.Rows[e.RowIndex];
				AddStudent addStudent = new AddStudent((int)dr.Cells[0].Value);
				this.Hide();
				addStudent.ShowDialog();
				var resp = httpClient.GetAsync("/api/student").Result;
				List<Student> students = resp.Content.ReadAsAsync<List<Student>>().Result;
				dgv_AllData.DataSource = students;
				dgv_AllData.Rows[e.RowIndex].Selected = true;
				dgv_AllData.CurrentCell = dgv_AllData.Rows[e.RowIndex].Cells[0]; ;

			}
		}
	}
}