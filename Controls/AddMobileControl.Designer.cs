namespace MobileShopProject.Controls
{
    partial class AddMobileControl
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
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.Label lblIMEINumber;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblWarrantyDate;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.ComboBox cmbModelNumber;
        private System.Windows.Forms.TextBox txtIMEINumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpWarrantyDate;
        private System.Windows.Forms.Button btnInsert;

        private void InitializeComponent()
        {
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.lblIMEINumber = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWarrantyDate = new System.Windows.Forms.Label();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.cmbModelNumber = new System.Windows.Forms.ComboBox();
            this.txtIMEINumber = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpWarrantyDate = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblCompanyName
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(20, 30);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(97, 16);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name:";

            // lblModelNumber
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(20, 70);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(97, 16);
            this.lblModelNumber.TabIndex = 1;
            this.lblModelNumber.Text = "Model Number:";

            // lblIMEINumber
            this.lblIMEINumber.AutoSize = true;
            this.lblIMEINumber.Location = new System.Drawing.Point(20, 110);
            this.lblIMEINumber.Name = "lblIMEINumber";
            this.lblIMEINumber.Size = new System.Drawing.Size(87, 16);
            this.lblIMEINumber.TabIndex = 2;
            this.lblIMEINumber.Text = "IMEI Number:";

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";

            // lblWarrantyDate
            this.lblWarrantyDate.AutoSize = true;
            this.lblWarrantyDate.Location = new System.Drawing.Point(20, 190);
            this.lblWarrantyDate.Name = "lblWarrantyDate";
            this.lblWarrantyDate.Size = new System.Drawing.Size(94, 16);
            this.lblWarrantyDate.TabIndex = 4;
            this.lblWarrantyDate.Text = "Warranty Date:";

            // cmbCompanyName
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(150, 27);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(200, 24);
            this.cmbCompanyName.TabIndex = 5;

            // cmbModelNumber
            this.cmbModelNumber.Location = new System.Drawing.Point(150, 67);
            this.cmbModelNumber.Name = "cmbModelNumber";
            this.cmbModelNumber.Size = new System.Drawing.Size(200, 24);
            this.cmbModelNumber.TabIndex = 6;

            // txtIMEINumber
            this.txtIMEINumber.Location = new System.Drawing.Point(150, 107);
            this.txtIMEINumber.Name = "txtIMEINumber";
            this.txtIMEINumber.Size = new System.Drawing.Size(200, 22);
            this.txtIMEINumber.TabIndex = 7;

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(150, 147);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 8;

            // dtpWarrantyDate
            this.dtpWarrantyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWarrantyDate.Location = new System.Drawing.Point(150, 187);
            this.dtpWarrantyDate.Name = "dtpWarrantyDate";
            this.dtpWarrantyDate.Size = new System.Drawing.Size(200, 22);
            this.dtpWarrantyDate.TabIndex = 9;

            // btnInsert
            this.btnInsert.Location = new System.Drawing.Point(150, 230);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 35);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);

            // AddMobileControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtpWarrantyDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtIMEINumber);
            this.Controls.Add(this.cmbModelNumber);
            this.Controls.Add(this.cmbCompanyName);
            this.Controls.Add(this.lblWarrantyDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblIMEINumber);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "AddMobileControl";
            this.Size = new System.Drawing.Size(400, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
