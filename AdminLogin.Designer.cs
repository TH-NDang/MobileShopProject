namespace MobileShopProject
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBack;
        private MobileShopProject.Controls.LoginControl loginControl;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBack = new System.Windows.Forms.Label();
            this.loginControl = new MobileShopProject.Controls.LoginControl();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblBack.Location = new System.Drawing.Point(12, 12);
            this.lblBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(57, 20);
            this.lblBack.TabIndex = 2;
            this.lblBack.Text = "← Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // loginControl
            // 
            this.loginControl.Location = new System.Drawing.Point(250, 150);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(300, 160);
            this.loginControl.TabIndex = 3;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.loginControl);
            this.Controls.Add(this.lblBack);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "AdminLogin";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login - Mobile Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}