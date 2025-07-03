using System.Data.SqlClient;
using System.Configuration;


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
    }

}
