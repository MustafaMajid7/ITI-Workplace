using System.Net;
using EFD1.Model;

namespace EFD1
{
    public partial class Form1 : Form
    {
        ItiContext db;
        public Form1()
        {
            InitializeComponent();
            db = new ItiContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgv_student.DataSource = db.Students.ToList();

            cmbx_department.DataSource = db.Departments.ToList();
            cmbx_department.DisplayMember = "DeptName";
            cmbx_department.ValueMember = "DeptId";

            cmbx_supervisor.DataSource = db.Students.ToList();
            cmbx_supervisor.DisplayMember = "StFname";
            cmbx_supervisor.ValueMember = "StId";
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void dgv_student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttons();
            nud_ID.Value = db.Students.ToList()[e.RowIndex].StId;
            nud_Age.Value = db.Students.ToList()[e.RowIndex].StAge==null?0: (int)db.Students.ToList()[e.RowIndex].StAge;
            txt_Address.Text = db.Students.ToList()[e.RowIndex].StAddress??"";
            txt_Name.Text = db.Students.ToList()[e.RowIndex].StFname??"";
            txt_Name.Text += " " + db.Students.ToList()[e.RowIndex].StLname??"";
            cmbx_supervisor.SelectedValue = db.Students.ToList()[e.RowIndex].StSuper??0;
            cmbx_department.SelectedValue = db.Students.ToList()[e.RowIndex].DeptId??0;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            db.Students.Add(new Student
            {
                StId = (int)nud_ID.Value,
                StAge = (int)nud_Age.Value,
                StAddress = txt_Address.Text,
                StFname = txt_Name.Text.Split(" ")[0],
                StLname = txt_Name.Text.Split(" ")[1],
                StSuper = (int)cmbx_supervisor.SelectedValue,
                DeptId = (int)cmbx_department.SelectedValue,

            });
            db.SaveChanges();
            clearinputs();
            dgv_student.DataSource = db.Students.ToList();
            MessageBox.Show("Insertion was done successfully");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var st = db.Students.Where(x => x.StId == nud_ID.Value).Single();
            foreach (var item in db.Students.Where(x=>x.StSuper==nud_ID.Value))
            {
                item.StSuper = null;
            }
            foreach (var item in db.StudCourses.Where(x => x.StId == nud_ID.Value))
            {
                db.StudCourses.Remove(item);
            }
            db.Students.Remove(st);
            db.SaveChanges();
            clearinputs();
            buttons();
            dgv_student.DataSource = db.Students.ToList();
            MessageBox.Show("Delete was done successfully");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var st = db.Students.Where(x => x.StId == nud_ID.Value).Single();
            st.StAge = (int)nud_Age.Value;
            st.StAddress = txt_Address.Text;
            st.StFname = txt_Name.Text.Split(" ")[0];
            st.StLname = txt_Name.Text.Split(" ")[1];
            st.StSuper = (int)cmbx_supervisor.SelectedValue;
            st.DeptId = (int)cmbx_department.SelectedValue;
            db.SaveChanges();
            clearinputs();
            buttons();
            dgv_student.DataSource = db.Students.ToList();
            MessageBox.Show("Update was done successfully");

        }
        private void buttons()
        {
            if (nud_ID.Value != 0)
                return;
            btn_Delete.Enabled = !btn_Delete.Enabled;
            btn_Update.Enabled = !btn_Update.Enabled;
            btn_Add.Enabled = !btn_Add.Enabled;

        }
        private void clearinputs()
        {
            nud_ID.Value = 0;
            nud_Age.Value = 0;
            txt_Address.Text = "";
            txt_Name.Text = "";
            cmbx_supervisor.SelectedValue = 0;
            cmbx_department.SelectedValue = 0;

        }
    }
}