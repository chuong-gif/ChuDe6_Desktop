using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Lớp ánh xạ bảng BillDetails
    public class BillDetails
    {
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }
    }
}