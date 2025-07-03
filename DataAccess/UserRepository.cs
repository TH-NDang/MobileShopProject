using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopProject.DataAccess
{
    internal class UserRepository
    {
        public static bool CheckLogin(string username, string password)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @user AND Password = @pass", conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
