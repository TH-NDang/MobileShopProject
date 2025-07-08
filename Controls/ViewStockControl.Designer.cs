namespace MobileShopProject.Controls
{
    partial class ViewStockControl
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
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.ComboBox cmbModelNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStockStatus;

        private void InitializeComponent()
        {
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.cmbModelNumber = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStockAvalable = new System.Windows.Forms.Label();
            this.txtStockAvalable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(97, 106);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(108, 16);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(217, 103);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(206, 24);
            this.cmbCompanyName.TabIndex = 1;
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(97, 146);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(99, 16);
            this.lblModelNumber.TabIndex = 2;
            this.lblModelNumber.Text = "Model Number:";
            // 
            // cmbModelNumber
            // 
            this.cmbModelNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelNumber.Enabled = false;
            this.cmbModelNumber.FormattingEnabled = true;
            this.cmbModelNumber.Location = new System.Drawing.Point(217, 143);
            this.cmbModelNumber.Name = "cmbModelNumber";
            this.cmbModelNumber.Size = new System.Drawing.Size(206, 24);
            this.cmbModelNumber.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(454, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 41);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStockStatus.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(221, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "View Stock";
            // 
            // lblStockAvalable
            // 
            this.lblStockAvalable.AutoSize = true;
            this.lblStockAvalable.Location = new System.Drawing.Point(97, 186);
            this.lblStockAvalable.Name = "lblStockAvalable";
            this.lblStockAvalable.Size = new System.Drawing.Size(101, 16);
            this.lblStockAvalable.TabIndex = 6;
            this.lblStockAvalable.Text = "Stock Avalable:";
            // 
            // txtStockAvalable
            // 
            this.txtStockAvalable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockAvalable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAvalable.Location = new System.Drawing.Point(217, 180);
            this.txtStockAvalable.Name = "txtStockAvalable";
            this.txtStockAvalable.ReadOnly = true;
            this.txtStockAvalable.Size = new System.Drawing.Size(120, 26);
            this.txtStockAvalable.TabIndex = 7;
            this.txtStockAvalable.Text = "0.00";
            this.txtStockAvalable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ViewStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtStockAvalable);
            this.Controls.Add(this.lblStockAvalable);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbModelNumber);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.cmbCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "ViewStockControl";
            this.Size = new System.Drawing.Size(651, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStockAvalable;
        private System.Windows.Forms.TextBox txtStockAvalable;
    }
}
