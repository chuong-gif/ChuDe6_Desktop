using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Hàm mở Form con, đảm bảo chỉ mở 1 thể hiện (instance) của Form
        private void ShowForm(Form childForm)
        {
            // Kiểm tra xem Form đã mở chưa
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == childForm.GetType())
                {
                    form.Activate(); // Nếu đã mở, kích hoạt nó
                    return;
                }
            }

            // Nếu chưa mở, tạo mới và hiển thị
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuOrder_Click(object sender, EventArgs e)
        {
            ShowForm(new frmOrder());
        }


        private void mnuCategories_Click(object sender, EventArgs e)
        {
            ShowForm(new frmCategory());
        }

        private void mnuFood_Click(object sender, EventArgs e)
        {
            ShowForm(new frmFood());
        }

        private void mnuTable_Click(object sender, EventArgs e)
        {
            ShowForm(new frmTable());
        }

        private void mnuAccount_Click(object sender, EventArgs e)
        {
            ShowForm(new frmAccount());
        }

        private void mnuRole_Click(object sender, EventArgs e)
        {
            ShowForm(new frmRole());
        }

        private void mnuAuthorization_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPhanQuyen());
        }
    }
}