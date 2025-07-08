using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace MobileShopProject.DataAccess
{
    internal class DbHelper
    {
       private static readonly string connectionString = 
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(connectionString);
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conn != null) conn.Dispose();
            }
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(connectionString);
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conn != null) conn.Dispose();
            }
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(connectionString);
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conn != null) conn.Dispose();
            }
        }
    }

}
