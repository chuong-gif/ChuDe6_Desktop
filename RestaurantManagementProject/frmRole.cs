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
    public partial class frmRole : Form
    {
        List<Role> listRole = new List<Role>();
        Role roleCurrent = new Role();

        public frmRole()
        {
            InitializeComponent();
        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            LoadRoleDataToListView();
        }

        private void LoadRoleDataToListView()
        {
            RoleBL roleBL = new RoleBL();
            listRole = roleBL.GetAll();
            int count = 1;

            lsvRole.Items.Clear();

            foreach (var role in listRole)
            {
                ListViewItem item = lsvRole.Items.Add(count.ToString());
                item.SubItems.Add(role.ID.ToString());
                item.SubItems.Add(role.RoleName);
                item.SubItems.Add(role.Path);
                item.SubItems.Add(role.Notes);
                count++;
            }
        }

        private void lsvRole_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvRole.Items.Count; i++)
            {
                if (lsvRole.Items[i].Selected)
                {
                    roleCurrent = listRole[i];
                    txtRoleName.Text = roleCurrent.RoleName;
                    txtPath.Text = roleCurrent.Path;
                    txtNotes.Text = roleCurrent.Notes;
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtRoleName.Text = "";
            txtPath.Text = "";
            txtNotes.Text = "";
        }

        private Role GetRoleFromControls()
        {
            Role role = new Role();

            if (string.IsNullOrWhiteSpace(txtRoleName.Text))
            {
                MessageBox.Show("Tên vai trò không được để trống!");
                return null;
            }

            role.RoleName = txtRoleName.Text;
            role.Path = txtPath.Text;
            role.Notes = txtNotes.Text;

            return role;
        }


        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Role role = GetRoleFromControls();
            if (role == null) return;

            RoleBL roleBL = new RoleBL();
            int result = roleBL.Insert(role);

            if (result > 0)
            {
                MessageBox.Show("Thêm vai trò thành công");
                LoadRoleDataToListView();
            }
            else
                MessageBox.Show("Thêm không thành công.");
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            Role role = GetRoleFromControls();
            if (role == null) return;

            role.ID = roleCurrent.ID;

            RoleBL roleBL = new RoleBL();
            int result = roleBL.Update(role);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật vai trò thành công");
                LoadRoleDataToListView();
            }
            else
                MessageBox.Show("Cập nhật không thành công.");
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (roleCurrent == null || roleCurrent.ID == 0)
            {
                MessageBox.Show("Bạn phải chọn một vai trò để xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá vai trò: " + roleCurrent.RoleName + "?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                RoleBL roleBL = new RoleBL();
                int result = roleBL.Delete(roleCurrent);

                if (result > 0)
                {
                    MessageBox.Show("Xoá vai trò thành công");
                    LoadRoleDataToListView();
                    cmdClear.PerformClick();
                }
                else
                    MessageBox.Show("Xoá không thành công (Lỗi: Vai trò có thể đang được gán cho tài khoản).");
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}