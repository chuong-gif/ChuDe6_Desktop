using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RoleAccountBL
    {
        RoleAccountDA roleAccountDA = new RoleAccountDA();

        public List<RoleAccount> GetByAccountName(string accountName)
        {
            return roleAccountDA.GetByAccountName(accountName);
        }

        // Hàm nghiệp vụ: Xóa hết vai trò cũ, thêm lại vai trò mới
        public int UpdateRolesForAccount(string accountName, List<RoleAccount> newRoles)
        {
            // 1. Xóa hết vai trò cũ
            roleAccountDA.DeleteByAccount(accountName);

            // 2. Thêm lại các vai trò mới
            int countSuccess = 0;
            foreach (var role in newRoles)
            {
                role.AccountName = accountName; // Đảm bảo đúng AccountName
                countSuccess += roleAccountDA.Insert(role);
            }
            return countSuccess;
        }
    }
}