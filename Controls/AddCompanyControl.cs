using MobileShopProject.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MobileShopProject.Controls
{
    public partial class AddCompanyControl : UserControl
    {
        public AddCompanyControl()
        {
            InitializeComponent();
            txtCompanyID.ReadOnly = true;
            GenerateNextId();
        }

        private void GenerateNextId()
        {
            try
            {
                string sql = "SELECT ISNULL(MAX(CompId), 0) + 1 FROM Company";
                int nextId = Convert.ToInt32(DbHelper.ExecuteScalar(sql));
                txtCompanyID.Text = $"C{nextId}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo ID: {ex.Message}");
                txtCompanyID.Text = "C1";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string compName = txtCompanyName.Text.Trim();
            string compIdText = txtCompanyID.Text.Trim().TrimStart('C');

            if (string.IsNullOrWhiteSpace(compName))
            {
                MessageBox.Show("Vui lòng nhập tên công ty.");
                return;
            }

            if (!int.TryParse(compIdText, out int compId))
            {
                MessageBox.Show("ID không hợp lệ.");
                return;
            }

            string sql = "INSERT INTO Company (CompId, CompName) VALUES (@compId, @compName)";
            int rows = DbHelper.ExecuteNonQuery(sql,
                new SqlParameter("@compId", compId),
                new SqlParameter("@compName", compName));

            if (rows > 0)
            {
                MessageBox.Show("Thêm thành công.");
                txtCompanyName.Clear();
                GenerateNextId(); // Generate next ID for the new entry
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

    }

}
