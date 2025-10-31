using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Lớp quản lý Role: DA = DataAccess
    public class RoleDA
    {
        public List<Role> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Role_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Role> list = new List<Role>();
            while (reader.Read())
            {
                Role role = new Role();
                role.ID = Convert.ToInt32(reader["ID"]);
                role.RoleName = reader["RoleName"].ToString();
                role.Path = reader["Path"].ToString();
                role.Notes = reader["Notes"].ToString();

                list.Add(role);
            }
            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(Role role, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Role_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = role.ID;

            command.Parameters.Add("@RoleName", SqlDbType.NVarChar, 1000)
                .Value = role.RoleName;
            command.Parameters.Add("@Path", SqlDbType.NVarChar, 3000)
                .Value = role.Path;
            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000)
                .Value = role.Notes;
            command.Parameters.Add("@Action", SqlDbType.Int)
                .Value = action;

            int result = command.ExecuteNonQuery();
            if (action == 0 && result > 0)
            {
                return (int)command.Parameters["@ID"].Value;
            }
            return result;
        }
    }
}