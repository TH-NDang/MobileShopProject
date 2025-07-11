using MobileShopProject.DataAccess;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShopProject
{
    public partial class UserLogin : Form
    {
        public bool IsAdmin = false;
        public UserLogin()
        {
            InitializeComponent();

            loginControl.OnLoginClick += HandleLogin;
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminLogin = new AdminLogin();
            var result = adminLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.IsAdmin = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (result == DialogResult.Retry)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void HandleLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE UserName = @user AND Pwd = @pass";
            SqlParameter[] parameters = {
                new SqlParameter("@user", username),
                new SqlParameter("@pass", password)
            };

            object result = DbHelper.ExecuteScalar(query, parameters);
            int count = Convert.ToInt32(result);

            if (count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
    }
}
