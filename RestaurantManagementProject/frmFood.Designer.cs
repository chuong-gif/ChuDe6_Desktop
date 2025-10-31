namespace RestaurantManagementProject
{
    partial class frmFood
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
               this.grpLeft = new System.Windows.Forms.GroupBox(); 
               this.txtNotes = new System.Windows.Forms.TextBox(); 
               this.cbbCategory = new System.Windows.Forms.ComboBox(); 
               this.txtPrice = new System.Windows.Forms.TextBox(); 
               this.txtUnit = new System.Windows.Forms.TextBox(); 
               this.txtName = new System.Windows.Forms.TextBox(); 
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
               this.cmdDelete = new System.Windows.Forms.Button(); 
               this.cmdUpdate = new System.Windows.Forms.Button(); 
               this.cmdAdd = new System.Windows.Forms.Button(); 
               this.cmdClear = new System.Windows.Forms.Button(); 
               this.grpRight = new System.Windows.Forms.GroupBox(); 
               this.lsvFood = new System.Windows.Forms.ListView(); 
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenThucPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiThucPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.grpLeft.Controls.Add(this.cbbCategory);
            this.grpLeft.Controls.Add(this.txtPrice);
            this.grpLeft.Controls.Add(this.txtUnit);
            this.grpLeft.Controls.Add(this.txtName);
            this.grpLeft.Controls.Add(this.label5);
            this.grpLeft.Controls.Add(this.label4);
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
            this.txtNotes.Location = new System.Drawing.Point(100, 160);
               this.txtNotes.Multiline = true; 
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(184, 189);
               this.txtNotes.TabIndex = 4; 
            // 
            // cbbCategory
            // 
            this.cbbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(100, 129);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(184, 21);
               this.cbbCategory.TabIndex = 3; 
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(100, 99);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(184, 20);
               this.txtPrice.TabIndex = 2; 
               this.txtPrice.Text = "0"; 
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnit.Location = new System.Drawing.Point(100, 69);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(184, 20);
               this.txtUnit.TabIndex = 1; 
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại thực phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thực phẩm:";
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
            this.grpRight.Controls.Add(this.lsvFood);
            this.grpRight.Controls.Add(this.lblStatistic);
            this.grpRight.Controls.Add(this.cmdExit);
            this.grpRight.Location = new System.Drawing.Point(318, 12);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(554, 426);
            this.grpRight.TabIndex = 1;
            this.grpRight.TabStop = false;
               this.grpRight.Text = "Danh mục thức ăn"; 
            // 
            // lsvFood
            // 
            this.lsvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenThucPham,
            this.colDVT,
            this.colGia,
            this.colLoaiThucPham,
            this.colGhiChu});
               this.lsvFood.FullRowSelect = true; 
               this.lsvFood.GridLines = true; 
            this.lsvFood.HideSelection = false;
            this.lsvFood.Location = new System.Drawing.Point(6, 19);
               this.lsvFood.MultiSelect = false; 
            this.lsvFood.Name = "lsvFood";
            this.lsvFood.Size = new System.Drawing.Size(542, 352);
            this.lsvFood.TabIndex = 0;
            this.lsvFood.UseCompatibleStateImageBehavior = false;
               this.lsvFood.View = System.Windows.Forms.View.Details; 
            this.lsvFood.Click += new System.EventHandler(this.lsvFood_Click);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 40;
            // 
            // colTenThucPham
            // 
            this.colTenThucPham.Text = "Tên thực phẩm";
            this.colTenThucPham.Width = 120;
            // 
            // colDVT
            // 
            this.colDVT.Text = "ĐVT";
            this.colDVT.Width = 50;
            // 
            // colGia
            // 
            this.colGia.Text = "Giá";
            this.colGia.Width = 70;
            // 
            // colLoaiThucPham
            // 
            this.colLoaiThucPham.Text = "Loại thực phẩm";
            this.colLoaiThucPham.Width = 100;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Text = "Ghi chú";
            this.colGhiChu.Width = 150;
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
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpLeft);
            this.Name = "frmFood";
               this.Text = "THÊM - XOÁ - SỬA BẢNG FOOD"; 
            this.Load += new System.EventHandler(this.frmFood_Load);
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
        private System.Windows.Forms.ListView lsvFood;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenThucPham;
        private System.Windows.Forms.ColumnHeader colDVT;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.ColumnHeader colLoaiThucPham;
        private System.Windows.Forms.ColumnHeader colGhiChu;
    }
}