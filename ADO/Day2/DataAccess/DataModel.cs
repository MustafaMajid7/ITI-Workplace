using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class DataModel
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        public DataModel()
        {
            adapter = new SqlDataAdapter();
            connection = new SqlConnection("Server=MOSTAFAMAGED\\SQLEXPRESS;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DataTable queryFunc(string command)
        {
            SqlCommand cmd = new SqlCommand(command,connection);

            adapter.SelectCommand = cmd;

            DataTable dt = new DataTable();
                
            adapter.Fill(dt);

            return dt;
        }

        public string queryFuncUsingID(string command,int id)
        {
            SqlCommand cmd = new SqlCommand(command, connection);

            cmd.Parameters.AddWithValue("id", id);

            connection.Open();

            string topic = cmd.ExecuteScalar().ToString();

            connection.Close();

            return topic;
        }

        public int nonqueryFunc(string command, SqlParameter[] ArrSqlParam)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            
            cmd.Parameters.AddRange(ArrSqlParam);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            connection.Open();
            
            int rowsEffected = cmd.ExecuteNonQuery();

            connection.Close();

            return rowsEffected;
        }

        public void adaptorUpdate(DataTable dataTable)
        {
            adapter.UpdateCommand = new SqlCommand("update Topic set Top_ID = @id, Top_Name= @name" +
                " where Top_Id = @id", connection);
            adapter.UpdateCommand.Parameters.Add("name", SqlDbType.NVarChar, 50, "Top_Name");
            adapter.UpdateCommand.Parameters.Add("id", SqlDbType.Int, 4, "Top_Id");

            adapter.InsertCommand = new SqlCommand("insert into Topic values(@id,@name)", connection);
            adapter.InsertCommand.Parameters.Add("name", SqlDbType.NVarChar, 50, "Top_Name");
            adapter.InsertCommand.Parameters.Add("id", SqlDbType.Int, 4, "Top_Id");

            adapter.DeleteCommand = new SqlCommand("delete from Topic where Top_Id = @id", connection);
            adapter.DeleteCommand.Parameters.Add("id", SqlDbType.Int, 4, "Top_Id");

            adapter.Update(dataTable);
        }

    }
}