
namespace SalesWinApp
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memberManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMangagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberManagementToolStripMenuItem,
            this.productMangagementToolStripMenuItem,
            this.createOrderToolStripMenuItem,
            this.viewOrderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memberManagementToolStripMenuItem
            // 
            this.memberManagementToolStripMenuItem.Name = "memberManagementToolStripMenuItem";
            this.memberManagementToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.memberManagementToolStripMenuItem.Text = "Member Manager";
            this.memberManagementToolStripMenuItem.Click += new System.EventHandler(this.memberManagementToolStripMenuItem_Click);
            // 
            // productMangagementToolStripMenuItem
            // 
            this.productMangagementToolStripMenuItem.Name = "productMangagementToolStripMenuItem";
            this.productMangagementToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.productMangagementToolStripMenuItem.Text = "Product Mangager";
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.createOrderToolStripMenuItem.Text = "Create Order";
            // 
            // viewOrderToolStripMenuItem
            // 
            this.viewOrderToolStripMenuItem.Name = "viewOrderToolStripMenuItem";
            this.viewOrderToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.viewOrderToolStripMenuItem.Text = "Reports";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 513);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productMangagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}