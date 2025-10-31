using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace RestaurantManagementProject
{
    public partial class frmOrder : Form
    {
        // Danh sách các đối tượng BL
        TableBL tableBL = new TableBL();
        CategoryBL categoryBL = new CategoryBL();
        FoodBL foodBL = new FoodBL();
        BillsBL billsBL = new BillsBL();
        BillDetailsBL billDetailsBL = new BillDetailsBL();

        // Danh sách dữ liệu
        List<Table> listTable = new List<Table>();
        List<Category> listCategory = new List<Category>();
        List<Food> listFood = new List<Food>();

        // Hóa đơn hiện tại đang chọn
        Bills currentBill;

        // Giả sử tài khoản đăng nhập là 'admin' (sẽ nâng cấp ở bài sau)
        string currentAccount = "admin";

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadTables();
            LoadCategories();
            LoadFoodList(null); // Tải tất cả món ăn ban đầu
        }

        #region Tải dữ liệu

        private void LoadTables()
        {
            // Lấy danh sách bàn
            listTable = tableBL.GetAll();
            flpTables.Controls.Clear();

            foreach (var table in listTable)
            {
                Button btn = new Button()
                {
                    Width = 90,
                    Height = 90,
                    Text = table.Name + Environment.NewLine + (table.Status == 0 ? "Trống" : "Có khách"),
                    Tag = table // Lưu đối tượng Table vào Tag
                };

                // Đặt màu dựa trên trạng thái
                btn.BackColor = table.Status == 0 ? Color.LightGreen : Color.LightCoral;
                btn.Click += TableButton_Click;
                flpTables.Controls.Add(btn);
            }
        }

        private void LoadCategories()
        {
            // 1. Tạm gỡ sự kiện
            cboCategory.SelectedIndexChanged -= cboCategory_SelectedIndexChanged;

            // 2. Tải dữ liệu như bình thường
            listCategory = categoryBL.GetAll();
            cboCategory.DataSource = listCategory;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "ID";

            // 3. Gắn lại sự kiện
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;

        }

        private void LoadFoodList(int? categoryID)
        {
            listFood = foodBL.GetAll();
            lsvFood.Items.Clear();

            // Lọc món ăn theo CategoryID
            var foodsToShow = (categoryID == null)
                ? listFood
                : listFood.FindAll(f => f.FoodCategoryID == categoryID);

            foreach (var food in foodsToShow)
            {
                ListViewItem item = new ListViewItem(food.Name);
                item.SubItems.Add(food.Price.ToString("N0")); // Format tiền tệ
                item.Tag = food; // Lưu đối tượng Food
                lsvFood.Items.Add(item);
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedValue != null)
            {
                LoadFoodList((int)cboCategory.SelectedValue);
            }
        }

        #endregion

        #region Xử lý nghiệp vụ (Chọn bàn, Thêm món)

        // Sự kiện khi nhấn vào một bàn
        private void TableButton_Click(object sender, EventArgs e)
        {
            Table table = (sender as Button).Tag as Table;
            lsvOrder.Tag = table; // Lưu bàn hiện tại vào Tag của ListView Hóa đơn

            // Lấy hóa đơn chưa thanh toán của bàn này
            currentBill = billsBL.GetUncheckByTableID(table.ID);

            ShowBill(table.ID);
        }

        // Hiển thị chi tiết hóa đơn
        private void ShowBill(int tableID)
        {
            lsvOrder.Items.Clear();
            int totalAmount = 0;

            if (currentBill != null) // Bàn này đã có hóa đơn
            {
                var billDetails = billDetailsBL.GetByBillID(currentBill.ID);
                foreach (var detail in billDetails)
                {
                    Food food = listFood.Find(f => f.ID == detail.FoodID);
                    if (food != null)
                    {
                        ListViewItem item = new ListViewItem(food.Name);
                        item.SubItems.Add(detail.Quantity.ToString());
                        item.SubItems.Add(food.Price.ToString("N0"));
                        int amount = food.Price * detail.Quantity;
                        item.SubItems.Add(amount.ToString("N0"));
                        item.Tag = detail; // Lưu chi tiết hóa đơn

                        lsvOrder.Items.Add(item);
                        totalAmount += amount;
                    }
                }
            }

            // Cập nhật tổng tiền
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotal.Text = totalAmount.ToString("c", culture);
            nudDiscount.Value = (decimal)(currentBill?.Discount ?? 0) * 100;
            UpdateFinalAmount();
        }

        // Thêm món ăn (double-click từ lsvFood)
        private void lsvFood_DoubleClick(object sender, EventArgs e)
        {
            if (lsvFood.SelectedItems.Count == 0) return;
            if (lsvOrder.Tag == null) // Chưa chọn bàn
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món!");
                return;
            }

            Table table = lsvOrder.Tag as Table;
            Food food = lsvFood.SelectedItems[0].Tag as Food;

            // 1. Tạo hóa đơn mới nếu chưa có
            if (currentBill == null)
            {
                currentBill = new Bills()
                {
                    Name = "HĐ " + table.Name,
                    TableID = table.ID,
                    Amount = 0,
                    Discount = 0,
                    Tax = 0,
                    Status = false,
                    Account = currentAccount
                };
                currentBill.ID = billsBL.Insert(currentBill); // Thêm và lấy ID mới

                // Cập nhật trạng thái bàn
                table.Status = 1; // Có khách
                tableBL.Update(table);
                LoadTables(); // Tải lại giao diện bàn
            }

            // 2. Kiểm tra món ăn đã có trong hóa đơn chưa
            BillDetails existingDetail = null;
            foreach (ListViewItem item in lsvOrder.Items)
            {
                BillDetails detail = item.Tag as BillDetails;
                if (detail.FoodID == food.ID)
                {
                    existingDetail = detail;
                    break;
                }
            }

            // 3. Thêm/Cập nhật chi tiết hóa đơn
            if (existingDetail != null) // Món đã tồn tại -> Tăng số lượng
            {
                existingDetail.Quantity++;
                billDetailsBL.Update(existingDetail);
            }
            else // Món mới -> Thêm mới
            {
                BillDetails newDetail = new BillDetails()
                {
                    InvoiceID = currentBill.ID,
                    FoodID = food.ID,
                    Quantity = 1
                };
                newDetail.ID = billDetailsBL.Insert(newDetail);
            }

            // 4. Tải lại hóa đơn
            ShowBill(table.ID);
        }

        #endregion

        #region Thanh toán

        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            UpdateFinalAmount();
        }

        private void UpdateFinalAmount()
        {
            if (!int.TryParse(txtTotal.Text.Split(',')[0].Replace(".", ""), out int totalAmount))
            {
                totalAmount = 0;
            }

            double discountPercent = (double)nudDiscount.Value / 100;
            int discountAmount = (int)(totalAmount * discountPercent);
            int finalAmount = totalAmount - discountAmount;

            CultureInfo culture = new CultureInfo("vi-VN");
            txtFinalAmount.Text = finalAmount.ToString("c", culture);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (currentBill == null)
            {
                MessageBox.Show("Bàn này không có hóa đơn để thanh toán.");
                return;
            }

            if (!int.TryParse(txtTotal.Text.Split(',')[0].Replace(".", ""), out int totalAmount))
            {
                totalAmount = 0;
            }
            double discountPercent = (double)nudDiscount.Value / 100;

            // Cập nhật hóa đơn
            currentBill.Status = true; // Đã thanh toán
            currentBill.Amount = totalAmount;
            currentBill.Discount = discountPercent;

            billsBL.Update(currentBill);

            // Cập nhật bàn về trạng thái trống
            Table table = lsvOrder.Tag as Table;
            table.Status = 0; // Trống
            tableBL.Update(table);

            MessageBox.Show("Thanh toán thành công!");

            // Tải lại
            LoadTables();
            lsvOrder.Items.Clear();
            lsvOrder.Tag = null;
            currentBill = null;
            txtTotal.Text = "0";
            txtFinalAmount.Text = "0";
            nudDiscount.Value = 0;
        }

        #endregion
    }
}