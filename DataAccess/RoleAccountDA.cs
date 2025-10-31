using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleAccountDA
    {
        // Lấy danh sách RoleID đã gán
        public List<RoleAccount> GetByAccountName(string accountName)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.RoleAccount_GetByAccountName;

            command.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100)
                .Value = accountName;

            SqlDataReader reader = command.ExecuteReader();
            List<RoleAccount> list = new List<RoleAccount>();
            while (reader.Read())
            {
                RoleAccount ra = new RoleAccount();
                ra.RoleID = Convert.ToInt32(reader["RoleID"]);
                ra.Actived = Convert.ToBoolean(reader["Actived"]);
                ra.AccountName = accountName; // Gán lại
                list.Add(ra);
            }
            sqlConn.Close();
            return list;
        }

        // Xóa tất cả vai trò theo tên tài khoản
        public int DeleteByAccount(string accountName)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.RoleAccount_DeleteByAccount;

            command.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100)
                .Value = accountName;

            int result = command.ExecuteNonQuery();
            sqlConn.Close();
            return result;
        }

        // Thêm một vai trò
        public int Insert(RoleAccount ra)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.RoleAccount_Insert;

            command.Parameters.Add("@RoleID", SqlDbType.Int)
                .Value = ra.RoleID;
            command.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100)
                .Value = ra.AccountName;
            command.Parameters.Add("@Actived", SqlDbType.Bit)
                .Value = ra.Actived;
            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000)
                .Value = ra.Notes ?? (object)DBNull.Value; // Cho phép Notes null

            int result = command.ExecuteNonQuery();
            sqlConn.Close();
            return result;
        }
    }
}