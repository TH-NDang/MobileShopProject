using System;
using System.Windows.Forms;

namespace MobileShopProject
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();

            loginControl.OnLoginClick += HandleLogin;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void HandleLogin(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Admin login failed");
            }
        }
    }
}
