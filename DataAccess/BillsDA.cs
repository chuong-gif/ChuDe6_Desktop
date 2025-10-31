using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BillsDA
    {
        public Bills GetUncheckByTableID(int tableID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Bills_GetUncheckByTableID;
            cmd.Parameters.Add("@TableID", SqlDbType.Int).Value = tableID;

            SqlDataReader reader = cmd.ExecuteReader();
            Bills bill = null;
            if (reader.Read()) // Chỉ lấy 1 hóa đơn (duy nhất)
            {
                bill = new Bills();
                bill.ID = Convert.ToInt32(reader["ID"]);
                bill.Name = reader["Name"].ToString();
                bill.TableID = Convert.ToInt32(reader["TableID"]);
                bill.Amount = Convert.ToInt32(reader["Amount"]);
                bill.Discount = Convert.ToDouble(reader["Discount"]);
                bill.Tax = Convert.ToDouble(reader["Tax"]);
                bill.Status = Convert.ToBoolean(reader["Status"]);
                bill.Account = reader["Account"].ToString();
            }
            sqlConn.Close();
            return bill;
        }

        public int Insert_Update_Delete(Bills bill, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Bills_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(IDPara).Value = bill.ID;

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = bill.Name;
            cmd.Parameters.Add("@TableID", SqlDbType.Int).Value = bill.TableID;
            cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = bill.Amount;
            cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = bill.Discount;
            cmd.Parameters.Add("@Tax", SqlDbType.Float).Value = bill.Tax;
            cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = bill.Status;
            cmd.Parameters.Add("@Account", SqlDbType.NVarChar, 100).Value = bill.Account;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (action == 0 && result > 0)
            {
                return (int)cmd.Parameters["@ID"].Value;
            }
            sqlConn.Close();
            return result;
        }
    }
}