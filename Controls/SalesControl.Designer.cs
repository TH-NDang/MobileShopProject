namespace MobileShopProject.Controls
{
    partial class SalesControl
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
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox gbMobileDetails;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.ComboBox cmbModelNumber;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.Label lblIMEI;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;

        private void InitializeComponent()
        {
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.gbMobileDetails = new System.Windows.Forms.GroupBox();
            this.cmbModelNumber = new System.Windows.Forms.ComboBox();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.lblIMEI = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmountLabel = new System.Windows.Forms.Label();
            this.gbCustomerInfo.SuspendLayout();
            this.gbMobileDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();

            // gbCustomerInfo
            this.gbCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCustomerInfo.Controls.Add(this.txtAddress);
            this.gbCustomerInfo.Controls.Add(this.lblAddress);
            this.gbCustomerInfo.Controls.Add(this.txtEmail);
            this.gbCustomerInfo.Controls.Add(this.lblEmail);
            this.gbCustomerInfo.Controls.Add(this.txtMobileNumber);
            this.gbCustomerInfo.Controls.Add(this.lblMobileNumber);
            this.gbCustomerInfo.Controls.Add(this.txtCustomerName);
            this.gbCustomerInfo.Controls.Add(this.lblCustomerName);
            this.gbCustomerInfo.Location = new System.Drawing.Point(20, 20);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(900, 150);
            this.gbCustomerInfo.TabIndex = 0;
            this.gbCustomerInfo.TabStop = false;
            this.gbCustomerInfo.Text = "Customer Information";

            // txtAddress
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(120, 90);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(760, 50);
            this.txtAddress.TabIndex = 7;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 93);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";

            // txtEmail
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(500, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 22);
            this.txtEmail.TabIndex = 5;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(440, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";

            // txtMobileNumber
            this.txtMobileNumber.Location = new System.Drawing.Point(120, 50);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(200, 22);
            this.txtMobileNumber.TabIndex = 3;

            // lblMobileNumber
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(20, 53);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(97, 16);
            this.lblMobileNumber.TabIndex = 2;
            this.lblMobileNumber.Text = "Mobile Number:";

            // txtCustomerName
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(120, 20);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(760, 22);
            this.txtCustomerName.TabIndex = 1;

            // lblCustomerName
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(20, 23);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(47, 16);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";

            // gbMobileDetails
            this.gbMobileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMobileDetails.Controls.Add(this.cmbModelNumber);
            this.gbMobileDetails.Controls.Add(this.lblModelNumber);
            this.gbMobileDetails.Controls.Add(this.cmbCompanyName);
            this.gbMobileDetails.Controls.Add(this.lblCompanyName);
            this.gbMobileDetails.Controls.Add(this.txtIMEI);
            this.gbMobileDetails.Controls.Add(this.lblIMEI);
            this.gbMobileDetails.Controls.Add(this.txtPrice);
            this.gbMobileDetails.Controls.Add(this.lblPrice);
            this.gbMobileDetails.Location = new System.Drawing.Point(20, 190);
            this.gbMobileDetails.Name = "gbMobileDetails";
            this.gbMobileDetails.Size = new System.Drawing.Size(900, 120);
            this.gbMobileDetails.TabIndex = 1;
            this.gbMobileDetails.TabStop = false;
            this.gbMobileDetails.Text = "Mobile Details";

            // cmbModelNumber
            this.cmbModelNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelNumber.FormattingEnabled = true;
            this.cmbModelNumber.Location = new System.Drawing.Point(120, 50);
            this.cmbModelNumber.Name = "cmbModelNumber";
            this.cmbModelNumber.Size = new System.Drawing.Size(200, 24);
            this.cmbModelNumber.TabIndex = 3;

            // lblModelNumber
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(20, 53);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(97, 16);
            this.lblModelNumber.TabIndex = 2;
            this.lblModelNumber.Text = "Model Number:";

            // cmbCompanyName
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(120, 20);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(200, 24);
            this.cmbCompanyName.TabIndex = 1;

            // lblCompanyName
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(20, 23);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(104, 16);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name:";

            // txtIMEI
            this.txtIMEI.Location = new System.Drawing.Point(500, 20);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(200, 22);
            this.txtIMEI.TabIndex = 5;

            // lblIMEI
            this.lblIMEI.AutoSize = true;
            this.lblIMEI.Location = new System.Drawing.Point(400, 23);
            this.lblIMEI.Name = "lblIMEI";
            this.lblIMEI.Size = new System.Drawing.Size(84, 16);
            this.lblIMEI.TabIndex = 4;
            this.lblIMEI.Text = "IMEI Number:";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(500, 50);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "0.00";

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(400, 53);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";

            // btnAddToCart
            this.btnAddToCart.Location = new System.Drawing.Point(20, 330);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(120, 30);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(160, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;

            // btnCheckout
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(800, 630);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 40);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;

            // dgvCart
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemNo,
            this.colCompany,
            this.colModel,
            this.colIMEI,
            this.colPrice,
            this.colRemove});
            this.dgvCart.Location = new System.Drawing.Point(20, 380);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(900, 200);
            this.dgvCart.TabIndex = 4;

            // colItemNo
            this.colItemNo.DataPropertyName = "ItemNo";
            this.colItemNo.HeaderText = "#";
            this.colItemNo.Name = "colItemNo";
            this.colItemNo.ReadOnly = true;
            this.colItemNo.Width = 40;

            // colCompany
            this.colCompany.DataPropertyName = "Company";
            this.colCompany.HeaderText = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.ReadOnly = true;
            this.colCompany.Width = 200;

            // colModel
            this.colModel.DataPropertyName = "Model";
            this.colModel.HeaderText = "Model";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            this.colModel.Width = 200;

            // colIMEI
            this.colIMEI.DataPropertyName = "IMEI";
            this.colIMEI.HeaderText = "IMEI";
            this.colIMEI.Name = "colIMEI";
            this.colIMEI.ReadOnly = true;
            this.colIMEI.Width = 200;

            // colPrice
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.DefaultCellStyle.Format = "N2";
            this.colPrice.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrice.Width = 100;

            // colRemove
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "Remove";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 100;

            // txtTotalAmount
            this.txtTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(800, 600);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(120, 22);
            this.txtTotalAmount.TabIndex = 6;
            this.txtTotalAmount.Text = "0.00";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // lblTotalAmount
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(700, 603);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(94, 16);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "Total (USD):";

            // SaleControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.gbMobileDetails);
            this.Controls.Add(this.gbCustomerInfo);
            this.Name = "SaleControl";
            this.Size = new System.Drawing.Size(940, 690);
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            this.gbMobileDetails.ResumeLayout(false);
            this.gbMobileDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}
