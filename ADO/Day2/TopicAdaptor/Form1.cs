using BusinessLogic;
using Microsoft.Data.SqlClient;
using System.Data;

namespace TopicAdaptor
{
    public partial class Form1 : Form
    {
        BLMain bLMain;
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();

            bLMain = new BLMain();
            dataTable = new DataTable();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataTable = bLMain.getTopicsV2();
            dgv_topic.DataSource = dataTable;

        }
        private void dgv_topic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgv_topic.Rows[e.RowIndex];
            nud_topicID.Value = (int)dr.Cells[0].Value;
            txt_TopicName.Text = dr.Cells[1].Value.ToString();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string name = bLMain.getTopic((int)nud_topicID.Value);

            MessageBox.Show($"the topic name is {name}");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            foreach (DataRow row in dataTable.Rows)
            {
                if ((int)row[0] == nud_topicID.Value)
                {
                    row[1] = txt_TopicName.Text;
                }
            }

            clearInputs();
        }

        private void dgv_topic_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgv_topic.Rows[e.RowIndex];
            nud_topicID.Value = (int)dr.Cells[0].Value;
            txt_TopicName.Text = dr.Cells[1].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            DataRow dataRow = dataTable.NewRow();

            dataRow[0] = nud_topicID.Value;
            dataRow[1] = txt_TopicName.Text;

            dataTable.Rows.Add(dataRow);

            clearInputs();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if ((int)row[0] == nud_topicID.Value)
                {
                    row.Delete();
                }
            }

            clearInputs();
        }

        public void clearInputs()
        {
            nud_topicID.Value = 0;
            txt_TopicName.Text = "";
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            bLMain.SaveChanges(dataTable);
        }
    }
}