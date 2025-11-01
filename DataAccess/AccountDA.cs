using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Lớp quản lý Account: DA = DataAccess
    public class AccountDA
    {
        // Phương thức lấy hết dữ liệu theo thủ tục Account_GetAll
        public List<Account> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Account_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Account> list = new List<Account>();
            while (reader.Read())
            {
                Account acc = new Account();
                acc.AccountName = reader["AccountName"].ToString();
                acc.Password = reader["Password"].ToString();
                acc.FullName = reader["FullName"].ToString();
                acc.Email = reader["Email"].ToString();
                acc.Tell = reader["Tell"].ToString();
                if (reader["DateCreated"] != DBNull.Value)
                {
                    // Nếu không NULL, thì mới chuyển đổi
                    acc.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                }
                else
                {
                    // Tùy chọn: Nếu bạn muốn gán một ngày mặc định khi nó bị NULL
                    // account.DateCreated = DateTime.MinValue; 
                }

                list.Add(acc);
            }
            sqlConn.Close();
            return list;
        }

        // Phương thức thêm, xoá, sửa theo thủ tục Account_InsertUpdateDelete
        public int Insert_Update_Delete(Account acc, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Account_InsertUpdateDelete;

            // Thêm các tham số cho thủ tục
            command.Parameters.Add("@Action", SqlDbType.Int)
                .Value = action;
            command.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100)
                .Value = acc.AccountName;

            // Chỉ cần các tham số này khi Thêm hoặc Sửa
            if (action == 0 || action == 1)
            {
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 200)
                    .Value = acc.Password;
                command.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000)
                    .Value = acc.FullName;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 1000)
                    .Value = acc.Email;
                command.Parameters.Add("@Tell", SqlDbType.NVarChar, 200)
                    .Value = acc.Tell;
            }
            else // Khi Xóa (action = 2), các tham số này không cần thiết
            {
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 200)
                    .Value = DBNull.Value;
                command.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000)
                    .Value = DBNull.Value;
                command.Parameters.Add("@Email", SqlDbType.NVarChar, 1000)
                    .Value = DBNull.Value;
                command.Parameters.Add("@Tell", SqlDbType.NVarChar, 200)
                    .Value = DBNull.Value;
            }

            int result = command.ExecuteNonQuery();
            sqlConn.Close();
            return result; // Trả về số dòng bị ảnh hưởng
        }
    }
}