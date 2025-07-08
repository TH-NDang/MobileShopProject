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
    public partial class SalesControl : UserControl
    {
        public SalesControl()
        {
            InitializeComponent();
            LoadCompanies();
            LoadModels();
            LoadIMEIs();

            cmbCompanyName.SelectedIndexChanged += CmbCompanyName_SelectedIndexChanged;
            cmbModelNumber.SelectedIndexChanged += CmbModelNumber_SelectedIndexChanged;
            cmbIMEI.SelectedIndexChanged += CmbIMEI_SelectedIndexChanged;
        }

        private void CmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModels();
        }

        private void CmbModelNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIMEIs();
        }

        private void CmbIMEI_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void LoadCompanies()
        {
            try
            {
                DataTable dt = CompanyRepository.GetCompanies();

                cmbCompanyName.DisplayMember = "CompName";
                cmbCompanyName.ValueMember = "CompId";
                cmbCompanyName.DataSource = dt;

                if (dt.Rows.Count < 1)
                {
                    cmbModelNumber.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách công ty: {ex.Message}");
            }
        }

        private void LoadModels()
        {
            try
            {
                if (cmbCompanyName.SelectedValue == null)
                {
                    cmbModelNumber.DataSource = null;
                    return;
                }

                string sql = "SELECT ModelId, ModelNo FROM Model WHERE CompId = @CompId ORDER BY ModelNo";
                DataTable dt = DbHelper.ExecuteQuery(sql, new SqlParameter("@CompId", cmbCompanyName.SelectedValue));

                cmbModelNumber.DisplayMember = "ModelNo";
                cmbModelNumber.ValueMember = "ModelId";
                cmbModelNumber.DataSource = dt;

                if (dt.Rows.Count < 1)
                {
                    cmbIMEI.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách model: {ex.Message}");
            }
        }

        private void LoadIMEIs()
        {
            try
            {
                if (cmbModelNumber.SelectedValue == null)
                {
                    cmbIMEI.DataSource = null;
                    return;
                }

                string sql = "SELECT IMEINo FROM Mobile WHERE ModelId = @ModelId";
                DataTable dt = DbHelper.ExecuteQuery(sql, new SqlParameter("@ModelId", cmbModelNumber.SelectedValue));

                cmbIMEI.DisplayMember = "IMEINo";
                cmbIMEI.ValueMember = "IMEINo";
                cmbIMEI.DataSource = dt;

                if (dt.Rows.Count < 1)
                {
                    txtPrice.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách IMEI: {ex.Message}");
            }
        }

        private void SetPrice()
        {
            if (cmbIMEI.SelectedValue == null)
            {
                txtPrice.Text = "0.00";
                return;
            }

            string sql = "SELECT Price FROM Mobile WHERE IMEINo = @IMEINo";
            object result = DbHelper.ExecuteScalar(sql, new SqlParameter("@IMEINo", cmbIMEI.SelectedValue));

            txtPrice.Text = result?.ToString() ?? "0.00";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string getCustomerSql = "SELECT ISNULL(MAX(CustId), 0) + 1 FROM Customer";
            int custId = Convert.ToInt32(DbHelper.ExecuteScalar(getCustomerSql));
            string insertCustomerSql = @"
                INSERT INTO Customer (CustId, CustName, MobileNo, MailId, Address) 
                VALUES (@CustId, @CustName, @MobileNo, @MailId, @Address);";

            DbHelper.ExecuteNonQuery(insertCustomerSql,
                new SqlParameter("@CustId", custId),
                new SqlParameter("@CustName", txtCustomerName.Text),
                new SqlParameter("@MobileNo", txtMobileNumber.Text),
                new SqlParameter("@MailId", txtEmail.Text),
                new SqlParameter("@Address", txtAddress.Text));

            string getSalesSql = "SELECT ISNULL(MAX(SalesId), 0) + 1 FROM Sales";
            int salesId = Convert.ToInt32(DbHelper.ExecuteScalar(getSalesSql));
            string insertSalesSql = @"
                INSERT INTO Sales (SalesId, IMEINo, SalesDate, Price, CustId) 
                VALUES (@SalesId, @IMEINo, @SalesDate, @Price, @CustId);";
            int rowUpdateSales = DbHelper.ExecuteNonQuery(insertSalesSql,
                new SqlParameter("@SalesId", salesId),
                new SqlParameter("@IMEINo", cmbIMEI.SelectedValue),
                new SqlParameter("@SalesDate", DateTime.Now),
                new SqlParameter("@Price", txtPrice.Text),
                new SqlParameter("@CustId", custId));

            if (rowUpdateSales > 0)
            {
                MessageBox.Show("Bán hàng thành công.");
                txtCustomerName.Clear();
                txtMobileNumber.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtPrice.Clear();
                cmbIMEI.DataSource = null;
                cmbModelNumber.DataSource = null;
                cmbCompanyName.DataSource = null;
            }
            else
            {
                MessageBox.Show("Bán hàng thất bại.");
            }
        }
    }
}
