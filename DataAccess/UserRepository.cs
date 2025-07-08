using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopProject.DataAccess
{
    public static class UserRepository
    {
        public class User
        {
            public string UserName { get; set; }
            public string Pwd { get; set; }
            public string EmployeeName { get; set; }
            public string Address { get; set; }
            public string MobileNo { get; set; }
            public string Hint { get; set; }
        }
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

        public static int AddUser(User user)
        {
            var cmd = "INSERT INTO [User] (UserName, Pwd, EmployeeName, Address, MobileNo, Hint) VALUES (@user, @pwd, @employeeName, @address, @mobileNo, @hint)";

            return DbHelper.ExecuteNonQuery(cmd,
                new SqlParameter("@user", user.UserName),
                new SqlParameter("@pwd", user.Pwd),
                new SqlParameter("@employeeName", user.EmployeeName),
                new SqlParameter("@address", user.Address),
                new SqlParameter("@mobileNo", user.MobileNo),
                new SqlParameter("@hint", user.Hint));
        }
    }
}
