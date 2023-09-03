using System.Data;
using System.Data.Common;
using System.DirectoryServices.ActiveDirectory;
using BusinessLogic;
using Microsoft.Data.SqlClient;

namespace Topic
{
    public partial class Form1 : Form
    {
        BLMain bLMain;
        public Form1()
        {
            InitializeComponent();
            bLMain = new BLMain();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<BusinessLogic.Topic> ls = bLMain.getTopics();

            dgv_topic.DataSource = ls;

        }
        private void dgv_topic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgv_topic.Rows[e.RowIndex];
            nud_topicID.Value = (int)dr.Cells[0].Value;
            txt_TopicName.Text = dr.Cells[1].Value.ToString();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string name = bLMain.getTopic((int)nud_topicID.Value);

            MessageBox.Show($"the topic name is {name}");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bLMain.updateTopic(txt_TopicName.Text, (int)nud_topicID.Value);

            List<BusinessLogic.Topic> ls = bLMain.getTopics();

            dgv_topic.DataSource = ls;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bLMain.insertTopic(txt_TopicName.Text, (int)nud_topicID.Value);

            List<BusinessLogic.Topic> ls = bLMain.getTopics();

            dgv_topic.DataSource = ls;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bLMain.deleteTopic((int)nud_topicID.Value);

            List<BusinessLogic.Topic> ls = bLMain.getTopics();

            dgv_topic.DataSource = ls;
        }
    }
}