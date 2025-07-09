namespace MobileShopProject
{
    partial class UserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAdmin;
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.loginControl = new MobileShopProject.Controls.LoginControl();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblAdmin.Location = new System.Drawing.Point(638, 12);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(129, 20);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Login as Admin →";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // loginControl
            // 
            this.loginControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginControl.Location = new System.Drawing.Point(250, 150);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(320, 200);
            this.loginControl.TabIndex = 3;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.loginControl);
            this.Controls.Add(this.lblAdmin);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "UserLogin";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login - Mobile Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}