namespace RestaurantManagementProject
{
    partial class frmRole
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.lsvRole = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStatistic = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.grpLeft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLeft
            // 
            this.grpLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpLeft.Controls.Add(this.txtNotes);
            this.grpLeft.Controls.Add(this.txtPath);
            this.grpLeft.Controls.Add(this.txtRoleName);
            this.grpLeft.Controls.Add(this.label3);
            this.grpLeft.Controls.Add(this.label2);
            this.grpLeft.Controls.Add(this.label1);
            this.grpLeft.Controls.Add(this.cmdDelete);
            this.grpLeft.Controls.Add(this.cmdUpdate);
            this.grpLeft.Controls.Add(this.cmdAdd);
            this.grpLeft.Controls.Add(this.cmdClear);
            this.grpLeft.Location = new System.Drawing.Point(12, 12);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(300, 426);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "Chức năng";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(100, 99);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(184, 274);
            this.txtNotes.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(100, 69);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(184, 20);
            this.txtPath.TabIndex = 1;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoleName.Location = new System.Drawing.Point(100, 39);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(184, 20);
            this.txtRoleName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đường dẫn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên vai trò:";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdDelete.Location = new System.Drawing.Point(220, 388);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(64, 23);
            this.cmdDelete.TabIndex = 8;
            this.cmdDelete.Text = "Xoá";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdUpdate.Location = new System.Drawing.Point(150, 388);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(64, 23);
            this.cmdUpdate.TabIndex = 7;
            this.cmdUpdate.Text = "Sửa";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAdd.Location = new System.Drawing.Point(80, 388);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(64, 23);
            this.cmdAdd.TabIndex = 6;
            this.cmdAdd.Text = "Thêm";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdClear.Location = new System.Drawing.Point(10, 388);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(64, 23);
            this.cmdClear.TabIndex = 5;
            this.cmdClear.Text = "Nhập lại";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // grpRight
            // 
            this.grpRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRight.Controls.Add(this.lsvRole);
            this.grpRight.Controls.Add(this.lblStatistic);
            this.grpRight.Controls.Add(this.cmdExit);
            this.grpRight.Location = new System.Drawing.Point(318, 12);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(554, 426);
            this.grpRight.TabIndex = 1;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "Danh sách vai trò";
            // 
            // lsvRole
            // 
            this.lsvRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvRole.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colID,
            this.colRoleName,
            this.colPath,
            this.colNotes});
            this.lsvRole.FullRowSelect = true;
            this.lsvRole.GridLines = true;
            this.lsvRole.HideSelection = false;
            this.lsvRole.Location = new System.Drawing.Point(6, 19);
            this.lsvRole.MultiSelect = false;
            this.lsvRole.Name = "lsvRole";
            this.lsvRole.Size = new System.Drawing.Size(542, 352);
            this.lsvRole.TabIndex = 0;
            this.lsvRole.UseCompatibleStateImageBehavior = false;
            this.lsvRole.View = System.Windows.Forms.View.Details;
            this.lsvRole.Click += new System.EventHandler(this.lsvRole_Click);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 40;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // colRoleName
            // 
            this.colRoleName.Text = "Tên vai trò";
            this.colRoleName.Width = 150;
            // 
            // colPath
            // 
            this.colPath.Text = "Đường dẫn";
            this.colPath.Width = 150;
            // 
            // colNotes
            // 
            this.colNotes.Text = "Ghi chú";
            this.colNotes.Width = 150;
            // 
            // lblStatistic
            // 
            this.lblStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Location = new System.Drawing.Point(6, 393);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(54, 13);
            this.lblStatistic.TabIndex = 1;
            this.lblStatistic.Text = "Thống kê";
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Location = new System.Drawing.Point(473, 388);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 0;
            this.cmdExit.Text = "Thoát";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // frmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpLeft);
            this.Name = "frmRole";
            this.Text = "QUẢN LÝ VAI TRÒ";
            this.Load += new System.EventHandler(this.frmRole_Load);
            this.grpLeft.ResumeLayout(false);
            this.grpLeft.PerformLayout();
            this.grpRight.ResumeLayout(false);
            this.grpRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.ListView lsvRole;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colRoleName;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.ColumnHeader colNotes;
    }
}