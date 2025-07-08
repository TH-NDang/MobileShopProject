namespace MobileShopProject.Controls
{
    partial class SearchCustomerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Label lblIMEI;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvCustomerSales;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarrantyUntil;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIMEI = new System.Windows.Forms.Label();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvCustomerSales = new System.Windows.Forms.DataGridView();
            this.colSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarrantyUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSales)).BeginInit();
            this.gbCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIMEI
            // 
            this.lblIMEI.AutoSize = true;
            this.lblIMEI.Location = new System.Drawing.Point(20, 30);
            this.lblIMEI.Name = "lblIMEI";
            this.lblIMEI.Size = new System.Drawing.Size(87, 16);
            this.lblIMEI.TabIndex = 0;
            this.lblIMEI.Text = "IMEI Number:";
            // 
            // txtIMEI
            // 
            this.txtIMEI.Location = new System.Drawing.Point(120, 27);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(300, 22);
            this.txtIMEI.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(440, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(560, 26);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerSales
            // 
            this.dgvCustomerSales.AllowUserToAddRows = false;
            this.dgvCustomerSales.AllowUserToDeleteRows = false;
            this.dgvCustomerSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleDate,
            this.colCompanyName,
            this.colModelNumber,
            this.colIMEI,
            this.colPrice,
            this.colWarrantyUntil});
            this.dgvCustomerSales.Location = new System.Drawing.Point(20, 320);
            this.dgvCustomerSales.Name = "dgvCustomerSales";
            this.dgvCustomerSales.ReadOnly = true;
            this.dgvCustomerSales.RowHeadersVisible = false;
            this.dgvCustomerSales.RowHeadersWidth = 51;
            this.dgvCustomerSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerSales.Size = new System.Drawing.Size(1281, 250);
            this.dgvCustomerSales.TabIndex = 4;
            // 
            // colSaleDate
            // 
            this.colSaleDate.DataPropertyName = "SaleDate";
            this.colSaleDate.HeaderText = "Sale Date";
            this.colSaleDate.MinimumWidth = 6;
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.ReadOnly = true;
            this.colSaleDate.Width = 120;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.HeaderText = "Company";
            this.colCompanyName.MinimumWidth = 6;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            this.colCompanyName.Width = 150;
            // 
            // colModelNumber
            // 
            this.colModelNumber.DataPropertyName = "ModelNumber";
            this.colModelNumber.HeaderText = "Model";
            this.colModelNumber.MinimumWidth = 6;
            this.colModelNumber.Name = "colModelNumber";
            this.colModelNumber.ReadOnly = true;
            this.colModelNumber.Width = 150;
            // 
            // colIMEI
            // 
            this.colIMEI.DataPropertyName = "IMEI";
            this.colIMEI.HeaderText = "IMEI";
            this.colIMEI.MinimumWidth = 6;
            this.colIMEI.Name = "colIMEI";
            this.colIMEI.ReadOnly = true;
            this.colIMEI.Width = 180;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // colWarrantyUntil
            // 
            this.colWarrantyUntil.DataPropertyName = "WarrantyUntil";
            this.colWarrantyUntil.HeaderText = "Warranty Until";
            this.colWarrantyUntil.MinimumWidth = 6;
            this.colWarrantyUntil.Name = "colWarrantyUntil";
            this.colWarrantyUntil.ReadOnly = true;
            this.colWarrantyUntil.Width = 120;
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCustomerDetails.Controls.Add(this.txtAddress);
            this.gbCustomerDetails.Controls.Add(this.lblAddress);
            this.gbCustomerDetails.Controls.Add(this.txtEmail);
            this.gbCustomerDetails.Controls.Add(this.lblEmail);
            this.gbCustomerDetails.Controls.Add(this.txtMobileNumber);
            this.gbCustomerDetails.Controls.Add(this.lblMobileNumber);
            this.gbCustomerDetails.Controls.Add(this.txtCustomerName);
            this.gbCustomerDetails.Controls.Add(this.lblCustomerName);
            this.gbCustomerDetails.Location = new System.Drawing.Point(20, 70);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Size = new System.Drawing.Size(1281, 230);
            this.gbCustomerDetails.TabIndex = 5;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Details";
            this.gbCustomerDetails.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(120, 120);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(1141, 90);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(120, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(1141, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(120, 50);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.ReadOnly = true;
            this.txtMobileNumber.Size = new System.Drawing.Size(200, 22);
            this.txtMobileNumber.TabIndex = 3;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(20, 53);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(102, 16);
            this.lblMobileNumber.TabIndex = 2;
            this.lblMobileNumber.Text = "Mobile Number:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(120, 20);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(1141, 22);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(20, 23);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(47, 16);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đây là trang Search Customer of User Nomal";
            // 
            // SearchCustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCustomerDetails);
            this.Controls.Add(this.dgvCustomerSales);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtIMEI);
            this.Controls.Add(this.lblIMEI);
            this.Controls.Add(this.label1);
            this.Name = "SearchCustomerControl";
            this.Size = new System.Drawing.Size(941, 612);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSales)).EndInit();
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}
