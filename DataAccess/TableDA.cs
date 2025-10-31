using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Lớp quản lý Table: DA = DataAccess
    public class TableDA
    {
        // Phương thức lấy hết dữ liệu
        public List<Table> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Table_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Table> list = new List<Table>();
            while (reader.Read())
            {
                Table table = new Table();
                table.ID = Convert.ToInt32(reader["ID"]);
                table.Name = reader["Name"].ToString();
                table.Status = Convert.ToInt32(reader["Status"]);
                table.Capacity = Convert.ToInt32(reader["Capacity"]);

                list.Add(table);
            }
            sqlConn.Close();
            return list;
        }

        // Phương thức thêm, xoá, sửa
        public int Insert_Update_Delete(Table table, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Table_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = table.ID;

            command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000)
                .Value = table.Name;
            command.Parameters.Add("@Status", SqlDbType.Int)
                .Value = table.Status;
            command.Parameters.Add("@Capacity", SqlDbType.Int)
                .Value = table.Capacity;
            command.Parameters.Add("@Action", SqlDbType.Int)
                .Value = action;

            int result = command.ExecuteNonQuery();
            if (action == 0 && result > 0) // Chỉ khi Thêm (Action = 0)
            {
                return (int)command.Parameters["@ID"].Value;
            }
            return result;
        }
    }
}