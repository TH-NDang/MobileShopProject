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
    public partial class SearchCustomerControl : UserControl
    {
        public SearchCustomerControl()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIMEI.Text == "")
            {
                MessageBox.Show("Vui lòng nhập IMEI.");
                return;
            }

            try
            {
                string sql = "SELECT CustName, MobileNo, MailId, Address FROM Customer JOIN Sales ON Customer.CustId = Sales.CustId WHERE IMEINo = @IMEINo";
                DataTable dt = DbHelper.ExecuteQuery(sql, new SqlParameter("@IMEINo", txtIMEI.Text));
                dgvCustomerSales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm khách hàng: {ex.Message}");
            }
        }

        private void LoadCustomers()
        {
            try
            {
                string sql = "SELECT CustId, CustName, MobileNo, MailId, Address FROM Customer";
                DataTable dt = DbHelper.ExecuteQuery(sql);
                dgvCustomerSales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khách hàng: {ex.Message}");
            }
        }
    }
}
