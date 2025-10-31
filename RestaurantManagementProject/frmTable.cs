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
using System.Xml.Linq;

namespace RestaurantManagementProject
{
    public partial class frmTable : Form
    {
        List<Table> listTable = new List<Table>();
        Table tableCurrent = new Table();

        public frmTable()
        {
            InitializeComponent();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadTableDataToListView();
        }

        private void LoadTableDataToListView()
        {
            TableBL tableBL = new TableBL();
            listTable = tableBL.GetAll();
            int count = 1;

            lsvTable.Items.Clear();

            foreach (var table in listTable)
            {
                ListViewItem item = lsvTable.Items.Add(count.ToString());
                item.SubItems.Add(table.ID.ToString());
                item.SubItems.Add(table.Name);

                // Hiển thị Status dạng text
                string statusText = table.Status == 0 ? "Trống" : "Có khách";
                item.SubItems.Add(statusText);

                item.SubItems.Add(table.Capacity.ToString());
                count++;
            }
        }

        private void lsvTable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvTable.Items.Count; i++)
            {
                if (lsvTable.Items[i].Selected)
                {
                    tableCurrent = listTable[i];
                    txtName.Text = tableCurrent.Name;
                    txtStatus.Text = tableCurrent.Status.ToString();
                    txtCapacity.Text = tableCurrent.Capacity.ToString();
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtStatus.Text = "0";
            txtCapacity.Text = "0";
        }

        private Table GetTableFromControls()
        {
            Table table = new Table();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên bàn không được để trống!");
                return null;
            }

            table.Name = txtName.Text;

            int status;
            if (!int.TryParse(txtStatus.Text, out status))
            {
                MessageBox.Show("Trạng thái phải là số (0 hoặc 1)");
                return null;
            }
            table.Status = status;

            int capacity;
            if (!int.TryParse(txtCapacity.Text, out capacity))
            {
                MessageBox.Show("Sức chứa phải là số");
                return null;
            }
            table.Capacity = capacity;

            return table;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Table table = GetTableFromControls();
            if (table == null) return;

            TableBL tableBL = new TableBL();
            int result = tableBL.Insert(table);

            if (result > 0)
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadTableDataToListView();
            }
            else
                MessageBox.Show("Thêm không thành công.");
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            Table table = GetTableFromControls();
            if (table == null) return;

            // Gán ID từ đối tượng hiện tại
            table.ID = tableCurrent.ID;

            TableBL tableBL = new TableBL();
            int result = tableBL.Update(table);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật bàn thành công");
                LoadTableDataToListView();
            }
            else
                MessageBox.Show("Cập nhật không thành công.");
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (tableCurrent == null || tableCurrent.ID == 0)
            {
                MessageBox.Show("Bạn phải chọn một bàn để xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xoá bàn: " + tableCurrent.Name + "?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TableBL tableBL = new TableBL();
                int result = tableBL.Delete(tableCurrent);

                if (result > 0)
                {
                    MessageBox.Show("Xoá bàn thành công");
                    LoadTableDataToListView();
                    cmdClear.PerformClick();
                }
                else
                    MessageBox.Show("Xoá không thành công (Lỗi: Bàn có thể đang được sử dụng trong Hóa đơn).");
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}