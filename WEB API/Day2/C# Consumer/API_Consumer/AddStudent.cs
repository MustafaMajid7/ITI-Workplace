using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Consumer
{
	public partial class AddStudent : Form
	{
		HttpClient httpClient;
		int student_numbers, id;
		public AddStudent(int id)
		{
			InitializeComponent();
			httpClient = new HttpClient();
			httpClient.BaseAddress = new Uri("https://localhost:7081");
			this.id = id;
		}
		private void AddStudent_Load(object sender, EventArgs e)
		{
			var resp = httpClient.GetAsync("/api/department").Result;

			if (resp.IsSuccessStatusCode)
			{
				List<Department> departments = resp.Content.ReadAsAsync<List<Department>>().Result;
				CMB_Department.DataSource = departments;
				CMB_Department.ValueMember = "Dept_Id";
				CMB_Department.DisplayMember = "Dept_Name";
			}
			else
			{
				MessageBox.Show("error in loading departments");
			}

			resp = httpClient.GetAsync("/api/student").Result;

			if (resp.IsSuccessStatusCode)
			{
				List<Student> students = resp.Content.ReadAsAsync<List<Student>>().Result;
				var stds = students.Where(x => x.St_Lname != null && x.St_Fname != null).Select(x => new { x.St_Id, FullName = x.St_Fname + " " + x.St_Lname }).ToList();
				student_numbers = students.Count * 10 + 1;
				CMB_Supervisor.DataSource = stds;
				CMB_Supervisor.ValueMember = "St_Id";
				CMB_Supervisor.DisplayMember = "FullName";
			}
			else
			{
				MessageBox.Show("error in loading students");
			}
			if (id != 0)
			{
				resp = httpClient.GetAsync("/api/student/" + id).Result;
				if (resp.IsSuccessStatusCode)
				{
					Student student = resp.Content.ReadAsAsync<Student>().Result;
					txt_Fname.Text = student.St_Fname;
					txt_Lname.Text = student.St_Lname;
					txt_Address.Text = student.St_Address;
					NUD_Age.Value = student.St_Age.Value;
					CMB_Department.SelectedValue = student.Dept_Id;
					CMB_Supervisor.SelectedValue = student.St_super;
				}
			}
		}

		private void btn_submit_Click(object sender, EventArgs e)
		{
			Student student = new Student();
			student.St_Fname = txt_Fname.Text;
			student.St_Lname = txt_Lname.Text;
			student.St_Address = txt_Address.Text;
			student.St_Age = (int)NUD_Age.Value;
			student.Dept_Id = (int)CMB_Department.SelectedValue;
			student.St_super = (int)CMB_Supervisor.SelectedValue;
			student.St_Id = student_numbers;

			if (id == 0)
			{
				var resp = httpClient.PostAsJsonAsync("/api/student", student).Result;
				if (resp.IsSuccessStatusCode)
				{
					MessageBox.Show("successfully added");
					this.Close();
					Application.OpenForms[0].Show();
				}
				else
				{
					MessageBox.Show(resp.StatusCode.ToString());
				}
			}
			else
			{
				student.St_Id = id;
				var resp = httpClient.PutAsJsonAsync("/api/student/" + id, student).Result;
				if (resp.IsSuccessStatusCode)
				{
					MessageBox.Show("successfully Updated");
					this.Close();
					Application.OpenForms[0].Show();
				}
				else
				{
					MessageBox.Show(resp.StatusCode.ToString());
				}
			}
		}

		private void btn_GoHome_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.OpenForms[0].Show();
		}
	}
}
