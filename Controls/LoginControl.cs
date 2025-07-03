using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopProject.Controls
{
    public partial class LoginControl : UserControl
    {
        public event Action<string, string> OnLoginClick;
        public LoginControl()
        {
            InitializeComponent();
        }
        public string Username => txtUsername.Text;
        public string Password => txtPassword.Text;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OnLoginClick?.Invoke(Username, Password);
        }
    }
}
