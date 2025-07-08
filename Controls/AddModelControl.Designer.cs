namespace MobileShopProject.Controls
{
    partial class AddModelControl
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
        private System.Windows.Forms.Label lblModelID;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.TextBox txtModelID;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.TextBox txtModelNumber;
        private System.Windows.Forms.Button btnAdd;

        private void InitializeComponent()
        {
            this.lblModelID = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.txtModelID = new System.Windows.Forms.TextBox();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.txtModelNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // lblModelID
            this.lblModelID.AutoSize = true;
            this.lblModelID.Location = new System.Drawing.Point(20, 30);
            this.lblModelID.Name = "lblModelID";
            this.lblModelID.Size = new System.Drawing.Size(58, 13);
            this.lblModelID.TabIndex = 0;
            this.lblModelID.Text = "Model ID:";

            // lblCompanyName
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(20, 70);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name:";

            // lblModelNumber
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(20, 110);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(78, 13);
            this.lblModelNumber.TabIndex = 2;
            this.lblModelNumber.Text = "Model Number:";

            // txtModelID
            this.txtModelID.Location = new System.Drawing.Point(150, 27);
            this.txtModelID.Name = "txtModelID";
            this.txtModelID.Size = new System.Drawing.Size(200, 20);
            this.txtModelID.TabIndex = 3;

            // cmbCompanyName
            this.cmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(150, 67);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(200, 21);
            this.cmbCompanyName.TabIndex = 4;

            // txtModelNumber
            this.txtModelNumber.Location = new System.Drawing.Point(150, 107);
            this.txtModelNumber.Name = "txtModelNumber";
            this.txtModelNumber.Size = new System.Drawing.Size(200, 20);
            this.txtModelNumber.TabIndex = 5;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(150, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;

            // AddModelControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtModelNumber);
            this.Controls.Add(this.cmbCompanyName);
            this.Controls.Add(this.txtModelID);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblModelID);
            this.Name = "AddModelControl";
            this.Size = new System.Drawing.Size(400, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
