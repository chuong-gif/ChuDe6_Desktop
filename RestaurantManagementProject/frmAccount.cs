using BusinessLogic;
using DataAccess;
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
    public partial class frmAccount : Form
    {
        // Danh sách toàn cục bảng Account
        List<Account> listAccount = new List<Account>();
        // Đối tượng Account đang chọn hiện hành
        Account accountCurrent = new Account();

        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            // Tải danh sách tài khoản lên ListView
            LoadAccountDataToListView();
        }

        private void LoadAccountDataToListView()
        {
            // Gọi đối tượng AccountBL
            AccountBL accountBL = new AccountBL();
            // Lấy dữ liệu
            listAccount = accountBL.GetAll();
            int count = 1; // Biến số thứ tự

            lsvAccount.Items.Clear();

            // Duyệt mảng dữ liệu để đưa vào ListView
            foreach (var acc in listAccount)
            {
                ListViewItem item = lsvAccount.Items.Add(count.ToString());
                item.SubItems.Add(acc.AccountName);
                item.SubItems.Add(acc.FullName);
                item.SubItems.Add(acc.Email);
                item.SubItems.Add(acc.Tell);
                item.SubItems.Add(acc.DateCreated.ToShortDateString());
                count++;
            }
        }

        private void lsvAccount_Click(object sender, EventArgs e)
        {
            // Duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvAccount.Items.Count; i++)
            {
                // Nếu có dòng được chọn thì lấy dòng đó
                if (lsvAccount.Items[i].Selected)
                {
                    // Lấy các tham số và gán dữ liệu vào các ô
                    accountCurrent = listAccount[i];
                    txtAccountName.Text = accountCurrent.AccountName;
                    txtPassword.Text = accountCurrent.Password;
                    txtFullName.Text = accountCurrent.FullName;
                    txtEmail.Text = accountCurrent.Email;
                    txtTell.Text = accountCurrent.Tell;
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            //Gán các ô bằng giá trị mặc định
            txtAccountName.Text = "";
            txtPassword.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtTell.Text = "";
        }

        // Phương thức lấy thông tin từ các ô text
        private Account GetAccountFromControls()
        {
            Account acc = new Account();

            // Khóa chính AccountName không được rỗng
            if (string.IsNullOrWhiteSpace(txtAccountName.Text))
            {
                MessageBox.Show("Tên tài khoản không được để trống!");
                return null;
            }

            acc.AccountName = txtAccountName.Text;
            acc.Password = txtPassword.Text;
            acc.FullName = txtFullName.Text;
            acc.Email = txtEmail.Text;
            acc.Tell = txtTell.Text;

            return acc;
        }


        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Account acc = GetAccountFromControls();
            if (acc == null) return;

            AccountBL accountBL = new AccountBL();
            int result = accountBL.Insert(acc);

            if (result > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadAccountDataToListView();
            }
            else
                MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại (Có thể trùng tên tài khoản)");
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            Account acc = GetAccountFromControls();
            if (acc == null) return;

            // Gán AccountName từ đối tượng hiện tại (để chắc chắn)
            acc.AccountName = accountCurrent.AccountName;

            AccountBL accountBL = new AccountBL();
            int result = accountBL.Update(acc);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
                LoadAccountDataToListView();
            }
            else
                MessageBox.Show("Cập nhật không thành công.");
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (accountCurrent == null || string.IsNullOrWhiteSpace(accountCurrent.AccountName))
            {
                MessageBox.Show("Bạn phải chọn một tài khoản để xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá tài khoản: " + accountCurrent.AccountName + "?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                AccountBL accountBL = new AccountBL();
                int result = accountBL.Delete(accountCurrent);

                if (result > 0)
                {
                    MessageBox.Show("Xoá tài khoản thành công");
                    LoadAccountDataToListView();
                    cmdClear.PerformClick(); // Xóa trắng các ô text
                }
                else
                    MessageBox.Show("Xoá không thành công");
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}