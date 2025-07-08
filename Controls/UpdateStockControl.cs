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
using MobileShopProject.DataAccess;


namespace MobileShopProject.Controls
{
    public partial class UpdateStockControl : UserControl
    {
        public UpdateStockControl()
        {
            InitializeComponent();
            LoadId();
            LoadCompanies();

            cmbCompanyName.SelectedIndexChanged += CmbCompanyName_SelectedIndexChanged;
            if (cmbCompanyName.Items.Count > 0)
            {
                LoadModels();
            }
        }

        private void CmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reload models when company selection changes
            if (cmbCompanyName.SelectedValue != null)
            {
                LoadModels();
            }
        }

        private void LoadId()
        {
            try
            {
                string sql = "SELECT ISNULL(MAX(TransId), 0) + 1 FROM [Transaction]";
                int nextId = Convert.ToInt32(DbHelper.ExecuteScalar(sql));
                txtTransID.Text = $"T{nextId:D3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách ID: {ex.Message}");
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách model: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string transIdText = txtTransID.Text.Trim().TrimStart('T');

            if (!int.TryParse(transIdText, out int transId))
            {
                MessageBox.Show("ID không hợp lệ.");
                return;
            }

            int modelId = (int)cmbModelNumber.SelectedValue;
            int quantity = Convert.ToInt32(txtQuantity.Text);
            decimal amount = Convert.ToDecimal(txtAmount.Text);

            try
            {
                string insertTransaction = "INSERT INTO [Transaction] (TransId, ModelId, Quantity, Amount, Date) VALUES (@transId, @modelId, @quantity, @amount, @date)";
                int rowUpdateTransaction = DbHelper.ExecuteNonQuery(insertTransaction,
                    new SqlParameter("@modelId", modelId),
                    new SqlParameter("@quantity", quantity),
                    new SqlParameter("@amount", amount),
                    new SqlParameter("@transId", transId),
                    new SqlParameter("@date", DateTime.Now));
                // update AvalableQty in Model
                string updateAvalableQty = "UPDATE Model SET AvalableQty = AvalableQty + @quantity WHERE ModelId = @modelId";
                int rowUpdateAvalableQty = DbHelper.ExecuteNonQuery(updateAvalableQty,
                    new SqlParameter("@modelId", modelId),
                    new SqlParameter("@quantity", quantity));

                if (rowUpdateTransaction > 0 && rowUpdateAvalableQty > 0)
                {
                    MessageBox.Show("Cập nhật thành công.");
                    txtQuantity.Clear();
                    txtAmount.Clear();
                    LoadId();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}");
            }

        }
    }
}
