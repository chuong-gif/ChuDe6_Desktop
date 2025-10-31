namespace RestaurantManagementProject
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
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFood = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAuthorization = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuOrder,
            this.mnuManagement,
            this.mnuAccountMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(69, 20);
            this.mnuSystem.Text = "Hệ thống";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(104, 22);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuOrder
            // 
            this.mnuOrder.Name = "mnuOrder";
            this.mnuOrder.Size = new System.Drawing.Size(70, 20);
            this.mnuOrder.Text = "Bán hàng";
            this.mnuOrder.Click += new System.EventHandler(this.mnuOrder_Click);
            // 
            // mnuManagement
            // 
            this.mnuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCategories,
            this.mnuFood,
            this.mnuTable});
            this.mnuManagement.Name = "mnuManagement";
            this.mnuManagement.Size = new System.Drawing.Size(60, 20);
            this.mnuManagement.Text = "Quản lý";
            // 
            // mnuCategories
            // 
            this.mnuCategories.Name = "mnuCategories";
            this.mnuCategories.Size = new System.Drawing.Size(180, 22);
            this.mnuCategories.Text = "Danh mục";
            this.mnuCategories.Click += new System.EventHandler(this.mnuCategories_Click);
            // 
            // mnuFood
            // 
            this.mnuFood.Name = "mnuFood";
            this.mnuFood.Size = new System.Drawing.Size(180, 22);
            this.mnuFood.Text = "Món ăn";
            this.mnuFood.Click += new System.EventHandler(this.mnuFood_Click);
            // 
            // mnuTable
            // 
            this.mnuTable.Name = "mnuTable";
            this.mnuTable.Size = new System.Drawing.Size(180, 22);
            this.mnuTable.Text = "Bàn";
            this.mnuTable.Click += new System.EventHandler(this.mnuTable_Click);
            // 
            // mnuAccountMenu
            // 
            this.mnuAccountMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAccount,
            this.mnuRole,
            this.toolStripMenuItem1,
            this.mnuAuthorization});
            this.mnuAccountMenu.Name = "mnuAccountMenu";
            this.mnuAccountMenu.Size = new System.Drawing.Size(70, 20);
            this.mnuAccountMenu.Text = "Tài khoản";
            // 
            // mnuAccount
            // 
            this.mnuAccount.Name = "mnuAccount";
            this.mnuAccount.Size = new System.Drawing.Size(180, 22);
            this.mnuAccount.Text = "Quản lý Tài khoản";
            this.mnuAccount.Click += new System.EventHandler(this.mnuAccount_Click);
            // 
            // mnuRole
            // 
            this.mnuRole.Name = "mnuRole";
            this.mnuRole.Size = new System.Drawing.Size(180, 22);
            this.mnuRole.Text = "Quản lý Vai trò";
            this.mnuRole.Click += new System.EventHandler(this.mnuRole_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuAuthorization
            // 
            this.mnuAuthorization.Name = "mnuAuthorization";
            this.mnuAuthorization.Size = new System.Drawing.Size(180, 22);
            this.mnuAuthorization.Text = "Phân quyền";
            this.mnuAuthorization.Click += new System.EventHandler(this.mnuAuthorization_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Phần mềm Quản lý Nhà hàng - Mô hình 3 tầng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuManagement;
        private System.Windows.Forms.ToolStripMenuItem mnuCategories;
        private System.Windows.Forms.ToolStripMenuItem mnuFood;
        private System.Windows.Forms.ToolStripMenuItem mnuTable;
        private System.Windows.Forms.ToolStripMenuItem mnuAccountMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuRole;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthorization;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
    }
}