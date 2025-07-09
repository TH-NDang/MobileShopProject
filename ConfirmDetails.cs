using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopProject
{
    public partial class ConfirmDetails : Form
    {
        private decimal totalAmount;

        public ConfirmDetails(
            string companyName,
            string modelNumber,
            string imei,
            string customerName,
            string customerContact,
            string customerEmail,
            decimal price,
            int quantity)
        {
            InitializeComponent();
            
            // Set the form title
            this.Text = "Xác nhận chi tiết đơn hàng";
            
            // Calculate total amount
            totalAmount = price * quantity;
            
            // Display the sales data
            lblCompanyName.Text = $"Tên công ty: {companyName}";
            lblModelNumber.Text = $"Số model: {modelNumber}";
            lblIMEI.Text = $"IMEI: {imei}";
            lblCustomerName.Text = $"Tên khách hàng: {customerName}";
            lblCustomerContact.Text = $"Liên hệ: {customerContact}";
            lblCustomerEmail.Text = $"Email: {customerEmail}";
            lblPrice.Text = $"Giá: {price:N0} VNĐ";
            lblQuantity.Text = $"Số lượng: {quantity}";
            lblTotal.Text = $"Tổng cộng: {totalAmount:N0} VNĐ";
            
            // Handle form closing
            this.FormClosing += ConfirmDetails_FormClosing;
        }
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Set dialog result to OK to indicate confirmation
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        private void ConfirmDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If user closes the form with X button, set dialog result to Cancel
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
