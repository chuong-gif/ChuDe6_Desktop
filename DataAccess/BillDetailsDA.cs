using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BillDetailsDA
    {
        public List<BillDetails> GetByBillID(int billID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.BillDetails_GetByBillID;
            cmd.Parameters.Add("@InvoiceID", SqlDbType.Int).Value = billID;

            SqlDataReader reader = cmd.ExecuteReader();
            List<BillDetails> list = new List<BillDetails>();
            while (reader.Read())
            {
                BillDetails billDetails = new BillDetails();
                billDetails.ID = Convert.ToInt32(reader["ID"]);
                billDetails.InvoiceID = Convert.ToInt32(reader["InvoiceID"]);
                billDetails.FoodID = Convert.ToInt32(reader["FoodID"]);
                billDetails.Quantity = Convert.ToInt32(reader["Quantity"]);
                list.Add(billDetails);
            }
            sqlConn.Close();
            return list;
        }

        public int Insert_Update_Delete(BillDetails billDetails, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.BillDetails_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(IDPara).Value = billDetails.ID;

            cmd.Parameters.Add("@InvoiceID", SqlDbType.Int).Value = billDetails.InvoiceID;
            cmd.Parameters.Add("@FoodID", SqlDbType.Int).Value = billDetails.FoodID;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = billDetails.Quantity;
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