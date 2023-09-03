using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class DataModel
    {
        SqlConnection connection;
        public DataModel()
        {
            connection = new SqlConnection("Server=MOSTAFAMAGED\\SQLEXPRESS;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DataTable queryFunc(string command)
        {
            SqlCommand cmd = new SqlCommand(command,connection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

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

    }
}