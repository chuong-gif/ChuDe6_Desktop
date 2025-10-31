namespace RestaurantManagementProject
{
    partial class frmCategory
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
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.lsvCategory = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpLeft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLeft
            // 
            this.grpLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpLeft.Controls.Add(this.txtType);
            this.grpLeft.Controls.Add(this.txtName);
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
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType.Location = new System.Drawing.Point(100, 69);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(184, 20);
            this.txtType.TabIndex = 1;
            this.txtType.Text = "0";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(100, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kiểu (0: Uống, 1: Ăn):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên danh mục:";
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
            this.grpRight.Controls.Add(this.lsvCategory);
            this.grpRight.Location = new System.Drawing.Point(318, 12);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(554, 426);
            this.grpRight.TabIndex = 1;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "Danh sách danh mục";
            // 
            // lsvCategory
            // 
            this.lsvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colID,
            this.colName,
            this.colType});
            this.lsvCategory.FullRowSelect = true;
            this.lsvCategory.GridLines = true;
            this.lsvCategory.HideSelection = false;
            this.lsvCategory.Location = new System.Drawing.Point(6, 19);
            this.lsvCategory.MultiSelect = false;
            this.lsvCategory.Name = "lsvCategory";
            this.lsvCategory.Size = new System.Drawing.Size(542, 392);
            this.lsvCategory.TabIndex = 0;
            this.lsvCategory.UseCompatibleStateImageBehavior = false;
            this.lsvCategory.View = System.Windows.Forms.View.Details;
            this.lsvCategory.Click += new System.EventHandler(this.lsvCategory_Click);
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
            // colName
            // 
            this.colName.Text = "Tên danh mục";
            this.colName.Width = 200;
            // 
            // colType
            // 
            this.colType.Text = "Kiểu";
            this.colType.Width = 100;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpLeft);
            this.Name = "frmCategory";
            this.Text = "QUẢN LÝ DANH MỤC";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.grpLeft.ResumeLayout(false);
            this.grpLeft.PerformLayout();
            this.grpRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.ListView lsvCategory;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
    }
}