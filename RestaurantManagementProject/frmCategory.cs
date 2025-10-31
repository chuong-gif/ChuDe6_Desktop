using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestaurantManagementProject
{
    public partial class frmCategory : Form
    {
        List<Category> listCategory = new List<Category>();
        Category categoryCurrent = new Category();

        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadCategoryDataToListView();
        }

        private void LoadCategoryDataToListView()
        {
            CategoryBL categoryBL = new CategoryBL();
            listCategory = categoryBL.GetAll();
            int count = 1;

            lsvCategory.Items.Clear();

            foreach (var category in listCategory)
            {
                ListViewItem item = lsvCategory.Items.Add(count.ToString());
                item.SubItems.Add(category.ID.ToString());
                item.SubItems.Add(category.Name);

                string typeText = category.Type == 1 ? "Đồ ăn" : "Thức uống";
                item.SubItems.Add(typeText);

                count++;
            }
        }

        private void lsvCategory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvCategory.Items.Count; i++)
            {
                if (lsvCategory.Items[i].Selected)
                {
                    categoryCurrent = listCategory[i];
                    txtName.Text = categoryCurrent.Name;
                    txtType.Text = categoryCurrent.Type.ToString();
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtType.Text = "0";
        }

        private Category GetCategoryFromControls()
        {
            Category category = new Category();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên danh mục không được để trống!");
                return null;
            }
            category.Name = txtName.Text;

            int type;
            if (!int.TryParse(txtType.Text, out type))
            {
                MessageBox.Show("Kiểu phải là số (0 hoặc 1)");
                return null;
            }
            category.Type = type;

            return category;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Category category = GetCategoryFromControls();
            if (category == null) return;

            CategoryBL categoryBL = new CategoryBL();
            int result = categoryBL.Insert(category);

            if (result > 0)
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadCategoryDataToListView();
            }
            else
                MessageBox.Show("Thêm không thành công.");
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            Category category = GetCategoryFromControls();
            if (category == null) return;

            category.ID = categoryCurrent.ID;

            CategoryBL categoryBL = new CategoryBL();
            int result = categoryBL.Update(category);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật danh mục thành công");
                LoadCategoryDataToListView();
            }
            else
                MessageBox.Show("Cập nhật không thành công.");
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (categoryCurrent == null || categoryCurrent.ID == 0)
            {
                MessageBox.Show("Bạn phải chọn một danh mục để xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá danh mục: " + categoryCurrent.Name + "?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CategoryBL categoryBL = new CategoryBL();
                int result = categoryBL.Delete(categoryCurrent);

                if (result > 0)
                {
                    MessageBox.Show("Xoá danh mục thành công");
                    LoadCategoryDataToListView();
                    cmdClear.PerformClick();
                }
                else
                    MessageBox.Show("Xoá không thành công (Lỗi: Danh mục có thể đang chứa Món ăn).");
            }
        }
    }
}