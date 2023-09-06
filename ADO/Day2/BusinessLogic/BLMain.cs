using System.Data;
using DataAccess;
using Microsoft.Data.SqlClient;

namespace BusinessLogic
{
    public class BLMain
    {
        DataModel model = new DataModel();

        //getAll

        public DataTable getTopicsV2()
        {
            string command = "select * from Topic";

            return model.queryFunc(command);
        }
        public List<Topic> getTopics()
        {
            string cmd = "select * from Topic";

            List<Topic> topic_list = new List<Topic>();
            
            DataTable dt =  model.queryFunc(cmd);

            foreach (DataRow dataRow in dt.Rows)
            {
                topic_list.Add(new Topic() { Id = (int)dataRow[0], Name = dataRow[1]?.ToString() });
            }

            return topic_list;
        }

        //getOne

        public string getTopic(int id)
        {
            string cmd = "select [Top_Name] from Topic where [Top_Id] = @id";

            return model.queryFuncUsingID(cmd,id);
            
        }

        //update

        public int updateTopic(string name , int id)
        {
            string cmd = "update Topic set [Top_Name] = @name where [Top_Id] = @id";
            
            SqlParameter[] sqlParam = new SqlParameter[2];

            sqlParam[0] = new SqlParameter("name", name);
            sqlParam[1] = new SqlParameter("id", id);

            return model.nonqueryFunc(cmd, sqlParam);
        }

        //insert

        public int insertTopic(string name, int id)
        {
            string cmd = "insert into Topic values (@id,@name)";

            SqlParameter[] sqlParam = new SqlParameter[2];

            sqlParam[0] = new SqlParameter("name", name);
            sqlParam[1] = new SqlParameter("id", id);

            return model.nonqueryFunc(cmd, sqlParam);
        }

        //delete

        public int deleteTopic(int id)
        {
            string cmd = "delete from Topic where [Top_Id] = @id";

            SqlParameter[] sqlParam = new SqlParameter[1];

            sqlParam[0] = new SqlParameter("id", id);

            return model.nonqueryFunc(cmd, sqlParam);
        }

        //updateV2

        public List<BusinessLogic.Topic> updateTopicV2(List<BusinessLogic.Topic> list_of_topics, string name, int id)
        {
            int index=0;
            foreach (Topic tp in list_of_topics)
            {
                if(tp.Id == id)
                    break;
                index++;
            }
            list_of_topics[index].Id = id;
            list_of_topics[index].Name = name;
            return list_of_topics;
        }

        //addV2

        public List<BusinessLogic.Topic> addTopicV2(List<BusinessLogic.Topic> list_of_topics, string name, int id)
        {
            int index = 0;
            foreach (Topic tp in list_of_topics)
            {
                if (tp.Id == id)
                    break;
                index++;
            }
            list_of_topics.Add(new Topic() { Id = id, Name = name });

            return list_of_topics;
        }

        //deleteV2

        public List<BusinessLogic.Topic> deleteTopicV2(List<BusinessLogic.Topic> list_of_topics, string name, int id)
        {
            int index = 0;
            foreach (Topic tp in list_of_topics)
            {
                if (tp.Id == id)
                    break;
                index++;
            }
            list_of_topics.RemoveAt(index);

            return list_of_topics;
        }
        public void SaveChanges(DataTable dataTable)
        {
            model.adaptorUpdate(dataTable);
        }
    }
}