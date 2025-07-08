using MobileShopProject.DataAccess;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MobileShopProject.DataAccess;

namespace MobileShopProject.Controls
{
    public partial class AddModelControl : UserControl
    {
        public AddModelControl()
        {
            InitializeComponent();
            txtModelID.ReadOnly = true;
            LoadCompanies();
            GenerateNextId();
        }

        private void LoadCompanies()
        {
            try
            {
                DataTable dt = CompanyRepository.GetCompanies();

                cmbCompanyName.DisplayMember = "CompName";
                cmbCompanyName.ValueMember = "CompId";
                cmbCompanyName.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách công ty: {ex.Message}");
            }
        }

        private void GenerateNextId()
        {
            try
            {
                string sql = "SELECT ISNULL(MAX(ModelId), 0) + 1 FROM Model";
                int nextId = Convert.ToInt32(DbHelper.ExecuteScalar(sql));
                txtModelID.Text = $"M{nextId:D3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo ID: {ex.Message}");
                txtModelID.Text = "M001";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string modelNumber = txtModelNumber.Text.Trim();
            string modelIdText = txtModelID.Text.Trim().TrimStart('M');

            if (cmbCompanyName.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn công ty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(modelNumber))
            {
                MessageBox.Show("Vui lòng nhập số model.");
                return;
            }

            if (!int.TryParse(modelIdText, out int modelId))
            {
                MessageBox.Show("ID không hợp lệ.");
                return;
            }

            int compId = (int)cmbCompanyName.SelectedValue;

            try
            {
                string sql = "INSERT INTO Model (ModelId, CompId, ModelNo, AvalableQty) " +
                           "VALUES (@modelId, @compId, @modelNo, 0)";

                int rows = DbHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@modelId", modelId),
                    new SqlParameter("@compId", compId),
                    new SqlParameter("@modelNo", modelNumber));

                if (rows > 0)
                {
                    MessageBox.Show("Thêm model thành công.");
                    txtModelNumber.Clear();
                    GenerateNextId();
                }
                else
                {
                    MessageBox.Show("Thêm model thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm model: {ex.Message}");
            }
        }
    }
}
