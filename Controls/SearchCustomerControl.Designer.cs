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
        private System.Windows.Forms.DataGridView dgvCustomerSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;

        private void InitializeComponent()
        {
            this.lblIMEI = new System.Windows.Forms.Label();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCustomerSales = new System.Windows.Forms.DataGridView();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIMEI
            // 
            this.lblIMEI.AutoSize = true;
            this.lblIMEI.Location = new System.Drawing.Point(140, 65);
            this.lblIMEI.Name = "lblIMEI";
            this.lblIMEI.Size = new System.Drawing.Size(87, 16);
            this.lblIMEI.TabIndex = 0;
            this.lblIMEI.Text = "IMEI Number:";
            // 
            // txtIMEI
            // 
            this.txtIMEI.Location = new System.Drawing.Point(240, 62);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(300, 22);
            this.txtIMEI.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(560, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerSales
            // 
            this.dgvCustomerSales.AllowUserToAddRows = false;
            this.dgvCustomerSales.AllowUserToDeleteRows = false;
            this.dgvCustomerSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerName,
            this.colMobileNumber,
            this.colEmail,
            this.colAddress});
            this.dgvCustomerSales.Location = new System.Drawing.Point(103, 149);
            this.dgvCustomerSales.Name = "dgvCustomerSales";
            this.dgvCustomerSales.ReadOnly = true;
            this.dgvCustomerSales.RowHeadersVisible = false;
            this.dgvCustomerSales.RowHeadersWidth = 51;
            this.dgvCustomerSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerSales.Size = new System.Drawing.Size(643, 247);
            this.dgvCustomerSales.TabIndex = 4;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.MinimumWidth = 6;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            this.colCustomerName.Width = 150;
            // 
            // colMobileNumber
            // 
            this.colMobileNumber.DataPropertyName = "MobileNumber";
            this.colMobileNumber.HeaderText = "Mobile Number";
            this.colMobileNumber.MinimumWidth = 6;
            this.colMobileNumber.Name = "colMobileNumber";
            this.colMobileNumber.ReadOnly = true;
            this.colMobileNumber.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 180;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 125;
            // 
            // SearchCustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCustomerSales);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtIMEI);
            this.Controls.Add(this.lblIMEI);
            this.Name = "SearchCustomerControl";
            this.Size = new System.Drawing.Size(862, 504);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
