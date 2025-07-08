using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using MobileShopProject.DataAccess;

namespace MobileShopProject.Controls
{
    public partial class SaleReportRangeControl : UserControl
    {
        public SaleReportRangeControl()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Today;
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
                               WHERE CAST(s.SalesDate AS DATE) BETWEEN @FromDate AND @ToDate
                               ORDER BY s.SalesDate DESC";

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@FromDate", dtpStartDate.Value.Date),
                    new SqlParameter("@ToDate", dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1))
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
            lblTotal.Text = $"Total Sale Amount from {dtpStartDate.Value.Date.ToString("dd/MM/yyyy")} to {dtpEndDate.Value.Date.ToString("dd/MM/yyyy")}: {total:C}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("From date cannot be greater than To date.", "Invalid Date Range", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadSalesData();
        }
    }
}
