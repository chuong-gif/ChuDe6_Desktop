using DataAccess; // using tầng DataAccess
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    // Lớp AccountBL có các phương thức xử lý bảng Account
    public class AccountBL
    {
        // Đối tượng AccountDA từ DataAccess
        AccountDA accountDA = new AccountDA();

        // Phương thức lấy hết dữ liệu
        public List<Account> GetAll()
        {
            return accountDA.GetAll();
        }

        // Phương thức thêm dữ liệu
        public int Insert(Account acc)
        {
            return accountDA.Insert_Update_Delete(acc, 0); // 0 là action Thêm
        }

        // Phương thức cập nhật dữ liệu
        public int Update(Account acc)
        {
            return accountDA.Insert_Update_Delete(acc, 1); // 1 là action Sửa
        }

        // Phương thức xoá dữ liệu
        public int Delete(Account acc)
        {
            return accountDA.Insert_Update_Delete(acc, 2); // 2 là action Xóa
        }
    }
}