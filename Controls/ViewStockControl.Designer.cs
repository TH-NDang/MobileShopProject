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
        private System.Windows.Forms.Panel pnlStockStatus;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label lblStockLabel;
        private System.Windows.Forms.DataGridView dgvStockDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdated;

        private void InitializeComponent()
        {
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.cmbModelNumber = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.pnlStockStatus = new System.Windows.Forms.Panel();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.lblStockLabel = new System.Windows.Forms.Label();
            this.dgvStockDetails = new System.Windows.Forms.DataGridView();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStockStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(20, 30);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(108, 16);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(140, 27);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(200, 24);
            this.cmbCompanyName.TabIndex = 1;
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(20, 70);
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
            this.cmbModelNumber.Location = new System.Drawing.Point(140, 67);
            this.cmbModelNumber.Name = "cmbModelNumber";
            this.cmbModelNumber.Size = new System.Drawing.Size(200, 24);
            this.cmbModelNumber.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(360, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
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
            // pnlStockStatus
            // 
            this.pnlStockStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStockStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStockStatus.Controls.Add(this.lblStockValue);
            this.pnlStockStatus.Controls.Add(this.lblStockLabel);
            this.pnlStockStatus.Location = new System.Drawing.Point(500, 20);
            this.pnlStockStatus.Name = "pnlStockStatus";
            this.pnlStockStatus.Padding = new System.Windows.Forms.Padding(10);
            this.pnlStockStatus.Size = new System.Drawing.Size(652, 80);
            this.pnlStockStatus.TabIndex = 5;
            this.pnlStockStatus.Visible = false;
            // 
            // lblStockValue
            // 
            this.lblStockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockValue.Location = new System.Drawing.Point(10, 10);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(630, 28);
            this.lblStockValue.TabIndex = 1;
            this.lblStockValue.Text = "0";
            this.lblStockValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockLabel
            // 
            this.lblStockLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStockLabel.Location = new System.Drawing.Point(10, 38);
            this.lblStockLabel.Name = "lblStockLabel";
            this.lblStockLabel.Size = new System.Drawing.Size(630, 30);
            this.lblStockLabel.TabIndex = 0;
            this.lblStockLabel.Text = "Units Available";
            this.lblStockLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvStockDetails
            // 
            this.dgvStockDetails.AllowUserToAddRows = false;
            this.dgvStockDetails.AllowUserToDeleteRows = false;
            this.dgvStockDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStockDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompanyName,
            this.colModelNumber,
            this.colInStock,
            this.colLastUpdated});
            this.dgvStockDetails.Location = new System.Drawing.Point(20, 120);
            this.dgvStockDetails.Name = "dgvStockDetails";
            this.dgvStockDetails.ReadOnly = true;
            this.dgvStockDetails.RowHeadersVisible = false;
            this.dgvStockDetails.RowHeadersWidth = 51;
            this.dgvStockDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockDetails.Size = new System.Drawing.Size(1152, 551);
            this.dgvStockDetails.TabIndex = 6;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.HeaderText = "Company Name";
            this.colCompanyName.MinimumWidth = 6;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            this.colCompanyName.Width = 250;
            // 
            // colModelNumber
            // 
            this.colModelNumber.DataPropertyName = "ModelNumber";
            this.colModelNumber.HeaderText = "Model Number";
            this.colModelNumber.MinimumWidth = 6;
            this.colModelNumber.Name = "colModelNumber";
            this.colModelNumber.ReadOnly = true;
            this.colModelNumber.Width = 200;
            // 
            // colInStock
            // 
            this.colInStock.DataPropertyName = "InStock";
            this.colInStock.HeaderText = "In Stock";
            this.colInStock.MinimumWidth = 6;
            this.colInStock.Name = "colInStock";
            this.colInStock.ReadOnly = true;
            // 
            // colLastUpdated
            // 
            this.colLastUpdated.DataPropertyName = "LastUpdated";
            this.colLastUpdated.HeaderText = "Last Updated";
            this.colLastUpdated.MinimumWidth = 6;
            this.colLastUpdated.Name = "colLastUpdated";
            this.colLastUpdated.ReadOnly = true;
            this.colLastUpdated.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đây là trang View Stock of Nomal User";
            // 
            // ViewStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvStockDetails);
            this.Controls.Add(this.pnlStockStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbModelNumber);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.cmbCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.label1);
            this.Name = "ViewStockControl";
            this.Size = new System.Drawing.Size(855, 566);
            this.pnlStockStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}
