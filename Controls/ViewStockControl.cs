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
    public partial class ViewStockControl : UserControl
    {
        public ViewStockControl()
        {
            InitializeComponent();
            LoadCompanies();
            LoadModels();
            ShowAvailableStock();

            cmbCompanyName.SelectedIndexChanged += CmbCompanyName_SelectedIndexChanged;

            cmbModelNumber.SelectedIndexChanged += CmbModelNumber_SelectedIndexChanged;
        }

        private void CmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompanyName.SelectedValue != null)
            {
                LoadModels();
                ShowAvailableStock();
            }
        }

        private void CmbModelNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModelNumber.SelectedValue != null)
            {
                ShowAvailableStock();
            }
        }

        private void LoadCompanies()
        {
            try
            {
                string sql = "SELECT CompId, CompName FROM Company ORDER BY CompName";
                DataTable dt = DbHelper.ExecuteQuery(sql);

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

        private void ShowAvailableStock()
        {
            try
            {
                if (cmbModelNumber.SelectedValue == null)
                {
                    tbStockAvailable.Text = "0";
                    return;
                }

                string sql = "SELECT AvalableQty FROM Model WHERE ModelId = @ModelId";
                object result = DbHelper.ExecuteScalar(sql, new SqlParameter("@ModelId", cmbModelNumber.SelectedValue));

                tbStockAvailable.Text = result?.ToString() ?? "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị số lượng tồn kho: {ex.Message}");
            }
        }
    }
}
