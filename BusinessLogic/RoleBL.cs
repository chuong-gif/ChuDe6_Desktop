using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    // Lớp RoleBL xử lý nghiệp vụ cho Role
    public class RoleBL
    {
        RoleDA roleDA = new RoleDA();

        public List<Role> GetAll()
        {
            return roleDA.GetAll();
        }

        public int Insert(Role role)
        {
            return roleDA.Insert_Update_Delete(role, 0); // 0 là action Thêm
        }

        public int Update(Role role)
        {
            return roleDA.Insert_Update_Delete(role, 1); // 1 là action Sửa
        }

        public int Delete(Role role)
        {
            return roleDA.Insert_Update_Delete(role, 2); // 2 là action Xóa
        }
    }
}