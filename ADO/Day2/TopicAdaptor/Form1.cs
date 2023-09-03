using BusinessLogic;
using Microsoft.Data.SqlClient;
using System.Data;

namespace TopicAdaptor
{
    public partial class Form1 : Form
    {
        BLMain bLMain;
        public Form1()
        {
            InitializeComponent();

            bLMain = new BLMain();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dgv_topic.DataSource = bLMain.getTopics();
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
            List<BusinessLogic.Topic> list_of_topics = (List<BusinessLogic.Topic>)dgv_topic.DataSource;

            dgv_topic.DataSource = bLMain.updateTopicV2(list_of_topics, txt_TopicName.Text, (int)nud_topicID.Value);
            
            clearInputs();
        }

        private void dgv_topic_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dgv_topic.Rows[e.RowIndex];
            nud_topicID.Value = (int)dr.Cells[0].Value;
            txt_TopicName.Text = dr.Cells[1].Value.ToString();
        }

        //private void btn_add_Click(object sender, EventArgs e)
        //{
        //    bLMain.insertTopic(txt_TopicName.Text, (int)nud_topicID.Value);

        //    List<BusinessLogic.Topic> ls = bLMain.getTopics();

        //    dgv_topic.DataSource = ls;
        //}

        //private void btn_delete_Click(object sender, EventArgs e)
        //{
        //    bLMain.deleteTopic((int)nud_topicID.Value);

        //    List<BusinessLogic.Topic> ls = bLMain.getTopics();

        //    dgv_topic.DataSource = ls;
        //}

        public void clearInputs()
        {
            nud_topicID.Value = 0;
            txt_TopicName.Text = "";
        }
    }
}