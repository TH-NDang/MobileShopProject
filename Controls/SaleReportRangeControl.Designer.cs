namespace MobileShopProject.Controls
{
    partial class SaleReportRangeControl
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
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIMEINumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleDate;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colSaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIMEINumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(20, 30);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(69, 16);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(20, 70);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 16);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(100, 27);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 22);
            this.dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(100, 67);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 22);
            this.dtpEndDate.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleID,
            this.colCompanyName,
            this.colModelNumber,
            this.colIMEINumber,
            this.colPrice,
            this.colSaleDate});
            this.dgvSales.Location = new System.Drawing.Point(20, 110);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(1325, 648);
            this.dgvSales.TabIndex = 5;
            // 
            // colSaleID
            // 
            this.colSaleID.DataPropertyName = "SaleID";
            this.colSaleID.HeaderText = "Sale ID";
            this.colSaleID.MinimumWidth = 6;
            this.colSaleID.Name = "colSaleID";
            this.colSaleID.ReadOnly = true;
            this.colSaleID.Width = 80;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.HeaderText = "Company Name";
            this.colCompanyName.MinimumWidth = 6;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            this.colCompanyName.Width = 150;
            // 
            // colModelNumber
            // 
            this.colModelNumber.DataPropertyName = "ModelNumber";
            this.colModelNumber.HeaderText = "Model Number";
            this.colModelNumber.MinimumWidth = 6;
            this.colModelNumber.Name = "colModelNumber";
            this.colModelNumber.ReadOnly = true;
            this.colModelNumber.Width = 150;
            // 
            // colIMEINumber
            // 
            this.colIMEINumber.DataPropertyName = "IMEINumber";
            this.colIMEINumber.HeaderText = "IMEI Number";
            this.colIMEINumber.MinimumWidth = 6;
            this.colIMEINumber.Name = "colIMEINumber";
            this.colIMEINumber.ReadOnly = true;
            this.colIMEINumber.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // colSaleDate
            // 
            this.colSaleDate.DataPropertyName = "SaleDate";
            dataGridViewCellStyle4.Format = "d";
            this.colSaleDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSaleDate.HeaderText = "Sale Date";
            this.colSaleDate.MinimumWidth = 6;
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.ReadOnly = true;
            this.colSaleDate.Width = 125;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(20, 778);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(418, 20);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Total Sale Amount from [start date] to [end date]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đây là trang Sale Report with Range Date to Date";
            // 
            // SaleReportRangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.label1);
            this.Name = "SaleReportRangeControl";
            this.Size = new System.Drawing.Size(959, 681);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}
