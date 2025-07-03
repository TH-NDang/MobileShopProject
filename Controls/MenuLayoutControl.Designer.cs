namespace MobileShopProject.Controls
{
    partial class MenuLayoutControl
    {
        private System.Windows.Forms.FlowLayoutPanel mainMenuPanel;
        private System.Windows.Forms.FlowLayoutPanel subMenuPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;

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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.subMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.mainLayoutPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.mainMenuPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.subMenuPanel, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.contentPanel, 0, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(800, 600);
            this.mainLayoutPanel.TabIndex = 0;

            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPanel.Location = new System.Drawing.Point(3, 3);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(794, 44);
            this.mainMenuPanel.TabIndex = 0;

            // 
            // subMenuPanel
            // 
            this.subMenuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.subMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subMenuPanel.Location = new System.Drawing.Point(3, 53);
            this.subMenuPanel.Name = "subMenuPanel";
            this.subMenuPanel.Size = new System.Drawing.Size(794, 34);
            this.subMenuPanel.TabIndex = 1;

            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(3, 93);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(794, 504);
            this.contentPanel.TabIndex = 2;

            // 
            // MenuLayoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "MenuLayoutControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.mainLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
