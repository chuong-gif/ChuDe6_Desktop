using DataAccess;

namespace BusinessLogic
{
    public class BillsBL
    {
        BillsDA billsDA = new BillsDA();

        public Bills GetUncheckByTableID(int tableID)
        {
            return billsDA.GetUncheckByTableID(tableID);
        }

        public int Insert(Bills bill)
        {
            return billsDA.Insert_Update_Delete(bill, 0); // 0 = Insert
        }

        public int Update(Bills bill)
        {
            return billsDA.Insert_Update_Delete(bill, 1); // 1 = Update
        }

        public int Delete(Bills bill)
        {
            return billsDA.Insert_Update_Delete(bill, 2); // 2 = Delete
        }
    }
}