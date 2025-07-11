using System;
using System.Windows.Forms;
using MobileShopProject;

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

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open ForgotPassword form
            var forgotPasswordForm = new ForgotPassword();
            
            // Center the forgot password form relative to the parent form
            var parentForm = this.FindForm();
            if (parentForm != null)
            {
                forgotPasswordForm.StartPosition = FormStartPosition.Manual;
                forgotPasswordForm.Left = parentForm.Left + (parentForm.Width - forgotPasswordForm.Width) / 2;
                forgotPasswordForm.Top = parentForm.Top + (parentForm.Height - forgotPasswordForm.Height) / 2;
            }
            else
            {
                forgotPasswordForm.StartPosition = FormStartPosition.CenterScreen;
            }

            // Show the form as a dialog
            forgotPasswordForm.ShowDialog();
        }
    }
}
