using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using MobileShopProject.DataAccess;

namespace MobileShopProject.Controls
{
    public partial class SaleReportDayControl : UserControl
    {
        public SaleReportDayControl()
        {
            InitializeComponent();
            dtpSelectDay.Value = DateTime.Today;
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            try
            {
                string query = @"SELECT s.SalesId, s.IMEINo, m.ModelNo, c.CompName, 
                               s.Price, s.SalesDate, cust.CustName, cust.MobileNo
                               FROM Sales s
                               INNER JOIN Mobile mb ON s.IMEINo = mb.IMEINo
                               INNER JOIN Model m ON mb.ModelId = m.ModelId
                               INNER JOIN Company c ON m.CompId = c.CompId
                               INNER JOIN Customer cust ON s.CustId = cust.CustId
                               WHERE CONVERT(date, s.SalesDate) = @SalesDate";

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@SalesDate", dtpSelectDay.Value.Date)
                };

                DataTable dt = DbHelper.ExecuteQuery(query, parameters);
                dgvSales.DataSource = dt;
                CalculateTotal(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotal(DataTable dt)
        {
            decimal total = 0;
            foreach (DataRow row in dt.Rows)
            {
                total += Convert.ToDecimal(row["Price"]);
            }
            lblTotal.Text = $"Total Sale Amount of {dtpSelectDay.Value.Date.ToString("dd/MM/yyyy")} là: {total:C}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSalesData();
        }
    }
}
