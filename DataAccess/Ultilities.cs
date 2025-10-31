using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    public class Ultilities
    {
        private static string StrName = "ConnectionStringName";

        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;

        public static string Food_GetAll = "Food_GetAll";
        public static string Food_InsertUpdateDelete = "Food_InsertUpdateDelete";

        public static string Category_GetAll = "Category_GetAll";
        public static string Category_InsertUpdateDelete = "Category_InsertUpdateDelete";

        public static string Account_GetAll = "Account_GetAll";
        public static string Account_InsertUpdateDelete = "Account_InsertUpdateDelete";

        public static string Table_GetAll = "Table_GetAll";
        public static string Table_InsertUpdateDelete = "Table_InsertUpdateDelete";

        public static string Role_GetAll = "Role_GetAll";
        public static string Role_InsertUpdateDelete = "Role_InsertUpdateDelete";

        public static string RoleAccount_GetByAccountName = "RoleAccount_GetByAccountName";
        public static string RoleAccount_DeleteByAccount = "RoleAccount_DeleteByAccount";
        public static string RoleAccount_Insert = "RoleAccount_Insert";

        public static string Bills_GetUncheckByTableID = "Bills_GetUncheckByTableID";
        public static string Bills_InsertUpdateDelete = "Bills_InsertUpdateDelete";
        public static string BillDetails_GetByBillID = "BillDetails_GetByBillID";
        public static string BillDetails_InsertUpdateDelete = "BillDetails_InsertUpdateDelete";

    }
}
