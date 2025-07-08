namespace MobileShopProject.Controls
{
    partial class UpdateStockControl
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
        private System.Windows.Forms.Label lblTransID;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.ComboBox cmbModelNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnUpdate;

        private void InitializeComponent()
        {
            this.lblTransID = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.cmbModelNumber = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // lblTransID
            this.lblTransID.AutoSize = true;
            this.lblTransID.Location = new System.Drawing.Point(20, 30);
            this.lblTransID.Name = "lblTransID";
            this.lblTransID.Size = new System.Drawing.Size(52, 16);
            this.lblTransID.TabIndex = 0;
            this.lblTransID.Text = "Trans ID:";
            
            // lblCompanyName
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(20, 70);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(104, 16);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name:";
            
            // lblModelNumber
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(20, 110);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(97, 16);
            this.lblModelNumber.TabIndex = 2;
            this.lblModelNumber.Text = "Model Number:";
            
            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 150);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            
            // lblAmount
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 190);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 16);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount:";
            
            // txtTransID
            this.txtTransID.Location = new System.Drawing.Point(150, 27);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(200, 22);
            this.txtTransID.TabIndex = 5;
            this.txtTransID.ReadOnly = true;
            
            // cmbCompanyName
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(150, 67);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(200, 24);
            this.cmbCompanyName.TabIndex = 6;
            
            // cmbModelNumber
            this.cmbModelNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelNumber.FormattingEnabled = true;
            this.cmbModelNumber.Location = new System.Drawing.Point(150, 107);
            this.cmbModelNumber.Name = "cmbModelNumber";
            this.cmbModelNumber.Size = new System.Drawing.Size(200, 24);
            this.cmbModelNumber.TabIndex = 7;
            
            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(150, 147);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Text = "0";
            
            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(150, 187);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.Text = "0.00";
            
            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(150, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            
            // UpdateStockControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbModelNumber);
            this.Controls.Add(this.cmbCompanyName);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblTransID);
            this.Name = "UpdateStockControl";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
