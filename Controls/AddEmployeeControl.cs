using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShopProject.DataAccess;
using System.Data.SqlClient;

namespace MobileShopProject.Controls
{
    public partial class AddEmployeeControl : UserControl
    {
        public AddEmployeeControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.");
                return;
            }

            if (txtPassword.Text != txtRetypePassword.Text)
            {
                MessageBox.Show("Mật khẩu không khớp.");
                return;
            }

            int rows = UserRepository.AddUser(new UserRepository.User
            {
                UserName = txtUserName.Text,
                Pwd = txtPassword.Text,
                EmployeeName = txtEmployeeName.Text,
                Address = txtAddress.Text,
                MobileNo = txtMobile.Text,
                Hint = txtHint.Text
            });

            if (rows > 0)
            {
                MessageBox.Show("Thêm thành công.");
                txtUserName.Clear();
                txtPassword.Clear();
                txtRetypePassword.Clear();
                txtEmployeeName.Clear();
                txtAddress.Clear();
                txtMobile.Clear();
                txtHint.Clear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }
    }
}
