using DataAccess; // using tầng DataAccess
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    // Lớp TableBL xử lý nghiệp vụ cho Table
    public class TableBL
    {
        // Đối tượng TableDA từ DataAccess
        TableDA tableDA = new TableDA();

        // Phương thức lấy hết dữ liệu
        public List<Table> GetAll()
        {
            return tableDA.GetAll();
        }

        // Phương thức thêm dữ liệu
        public int Insert(Table table)
        {
            return tableDA.Insert_Update_Delete(table, 0); // 0 là action Thêm
        }

        // Phương thức cập nhật dữ liệu
        public int Update(Table table)
        {
            return tableDA.Insert_Update_Delete(table, 1); // 1 là action Sửa
        }

        // Phương thức xoá dữ liệu
        public int Delete(Table table)
        {
            return tableDA.Insert_Update_Delete(table, 2); // 2 là action Xóa
        }
    }
}