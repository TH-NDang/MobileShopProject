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
    public partial class AddMobileControl : UserControl
    {
        public AddMobileControl()
        {
            InitializeComponent();
            LoadCompanies();
            LoadModels();

            cmbCompanyName.SelectedIndexChanged += CmbCompanyName_SelectedIndexChanged;
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

        private void CmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModels();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtIMEINumber.Text == "" || txtPrice.Text == "" || cmbModelNumber.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            int warrantyMonths = (dtpWarrantyDate.Value.Year - DateTime.Now.Year) * 12 + 
                    (dtpWarrantyDate.Value.Month - DateTime.Now.Month);
            if (warrantyMonths < 0) warrantyMonths = 0;

            string sqlInsert = "INSERT INTO Mobile (IMEINo, Price, Warranty, ModelId, Status) VALUES (@imei, @price, @warranty, @modelId,@status)";
            int rowUpdate = DbHelper.ExecuteNonQuery(sqlInsert,
                new SqlParameter("@imei", txtIMEINumber.Text),
                new SqlParameter("@price", txtPrice.Text),
                new SqlParameter("@warranty", warrantyMonths),
                new SqlParameter("@modelId", cmbModelNumber.SelectedValue),
                new SqlParameter("@status", "Not sold"));

            if (rowUpdate > 0)
            {
                MessageBox.Show("Thêm thành công.");
                txtIMEINumber.Clear();
                dtpWarrantyDate.Value = DateTime.Now;
                txtPrice.Clear();
                LoadModels();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }
    }
}
