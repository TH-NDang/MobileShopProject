using MobileShopProject.DataAccess;
using System;
using System.Windows.Forms;

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
                this.Close();
            {
            }
        }

        private void HandleLogin(string username, string password)
        {
            // if (UserRepository.CheckLogin(username, password))
            if (username == "user" && password == "user")
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
