using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantManagementProject
{
    public partial class frmPhanQuyen : Form
    {
        // Danh sách tất cả các vai trò
        List<Role> allRoles = new List<Role>();

        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            LoadAccountsToComboBox();
            LoadAllRolesToCheckedListBox();
        }

        private void LoadAccountsToComboBox()
        {
            AccountBL accountBL = new AccountBL();
            var accounts = accountBL.GetAll();

            cboAccount.DataSource = accounts;
            cboAccount.DisplayMember = "FullName"; // Hiển thị Tên đầy đủ
            cboAccount.ValueMember = "AccountName"; // Giữ giá trị là Tên TK
        }

        private void LoadAllRolesToCheckedListBox()
        {
            RoleBL roleBL = new RoleBL();
            allRoles = roleBL.GetAll();

            clbRoles.DataSource = allRoles;
            clbRoles.DisplayMember = "RoleName";
            clbRoles.ValueMember = "ID";
        }

        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bỏ check tất cả
            for (int i = 0; i < clbRoles.Items.Count; i++)
            {
                clbRoles.SetItemChecked(i, false);
            }

            // Lấy tài khoản được chọn
            if (cboAccount.SelectedValue == null) return;
            string accountName = cboAccount.SelectedValue.ToString();

            // Lấy các vai trò hiện tại của tài khoản đó
            RoleAccountBL raBL = new RoleAccountBL();
            var currentRoles = raBL.GetByAccountName(accountName);

            // Check vào các vai trò mà tài khoản đó có
            foreach (var currentRole in currentRoles)
            {
                for (int i = 0; i < allRoles.Count; i++)
                {
                    if (allRoles[i].ID == currentRole.RoleID)
                    {
                        clbRoles.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboAccount.SelectedValue == null) return;
            string accountName = cboAccount.SelectedValue.ToString();

            // Lấy danh sách các vai trò được check
            List<RoleAccount> newRoles = new List<RoleAccount>();
            foreach (var item in clbRoles.CheckedItems)
            {
                Role checkedRole = item as Role;
                if (checkedRole != null)
                {
                    newRoles.Add(new RoleAccount
                    {
                        RoleID = checkedRole.ID,
                        Actived = true
                    });
                }
            }

            // Gọi BL để cập nhật
            RoleAccountBL raBL = new RoleAccountBL();
            int result = raBL.UpdateRolesForAccount(accountName, newRoles);

            MessageBox.Show($"Đã cập nhật {result} vai trò cho tài khoản {accountName}.");
        }
    }
}