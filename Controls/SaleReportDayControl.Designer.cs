namespace MobileShopProject.Controls
{
    partial class SaleReportDayControl
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
        private System.Windows.Forms.Label lblSelectDay;
        private System.Windows.Forms.DateTimePicker dtpSelectDay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIMEINumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSelectDay = new System.Windows.Forms.Label();
            this.dtpSelectDay = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.colSaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIMEINumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectDay
            // 
            this.lblSelectDay.AutoSize = true;
            this.lblSelectDay.Location = new System.Drawing.Point(20, 30);
            this.lblSelectDay.Name = "lblSelectDay";
            this.lblSelectDay.Size = new System.Drawing.Size(76, 16);
            this.lblSelectDay.TabIndex = 0;
            this.lblSelectDay.Text = "Select Day:";
            // 
            // dtpSelectDay
            // 
            this.dtpSelectDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelectDay.Location = new System.Drawing.Point(100, 27);
            this.dtpSelectDay.Name = "dtpSelectDay";
            this.dtpSelectDay.Size = new System.Drawing.Size(150, 22);
            this.dtpSelectDay.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 2;
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
            this.colPrice});
            this.dgvSales.Location = new System.Drawing.Point(20, 70);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(871, 470);
            this.dgvSales.TabIndex = 3;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 125;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(20, 560);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(239, 20);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "Total Sale Amount of [date]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đây là trang Sale Report with day";
            // 
            // SaleReportDayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpSelectDay);
            this.Controls.Add(this.lblSelectDay);
            this.Controls.Add(this.label1);
            this.Name = "SaleReportDayControl";
            this.Size = new System.Drawing.Size(703, 473);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}
