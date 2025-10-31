using DataAccess;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BillDetailsBL
    {
        BillDetailsDA billDetailsDA = new BillDetailsDA();

        public List<BillDetails> GetByBillID(int billID)
        {
            return billDetailsDA.GetByBillID(billID);
        }

        public int Insert(BillDetails billDetails)
        {
            return billDetailsDA.Insert_Update_Delete(billDetails, 0); // 0 = Insert
        }

        public int Update(BillDetails billDetails)
        {
            return billDetailsDA.Insert_Update_Delete(billDetails, 1); // 1 = Update
        }

        public int Delete(BillDetails billDetails)
        {
            return billDetailsDA.Insert_Update_Delete(billDetails, 2); // 2 = Delete
        }
    }
}