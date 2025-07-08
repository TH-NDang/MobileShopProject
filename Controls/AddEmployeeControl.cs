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

            string sql = "INSERT INTO [User] (UserName, Pwd, EmployeeName, Address, MobileNo, Hint) " +
                       "VALUES (@userName, @pwd, @employeeName, @address, @mobileNo, @hint)";
            int rows = DbHelper.ExecuteNonQuery(sql,
                new SqlParameter("@userName", txtUserName.Text),
                new SqlParameter("@pwd", txtPassword.Text),
                new SqlParameter("@employeeName", txtEmployeeName.Text),
                new SqlParameter("@address", txtAddress.Text),
                new SqlParameter("@mobileNo", txtMobile.Text),
                new SqlParameter("@hint", txtHint.Text));

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
