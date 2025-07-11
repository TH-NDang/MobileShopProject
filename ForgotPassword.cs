using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MobileShopProject.DataAccess;
using System.Data.SqlClient;

namespace MobileShopProject
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername; // Set focus to username field when form loads
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Prevent form from closing after submit
            this.DialogResult = DialogResult.None;
            
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHint.Text))
            {
                MessageBox.Show("Vui lòng nhập gợi ý mật khẩu", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHint.Focus();
                return;
            }

            try
            {
                string sql = @"
                    SELECT Pwd 
                    FROM [User] 
                    WHERE UserName = @Username 
                    AND Hint = @Hint";

                SqlParameter[] parameters = {
                    new SqlParameter("@Username", txtUsername.Text.Trim()),
                    new SqlParameter("@Hint", txtHint.Text.Trim())
                };

                object result = DbHelper.ExecuteScalar(sql, parameters);

                if (result != null)
                {
                    lblResult.Text = $"Mật khẩu của bạn là: {result}";
                    lblResult.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResult.Text = "Tên đăng nhập hoặc gợi ý không chính xác";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Set dialog result to Cancel and close the form when user clicks back
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If user closes the form with X button, set dialog result to Cancel
            if (this.DialogResult == DialogResult.None)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
