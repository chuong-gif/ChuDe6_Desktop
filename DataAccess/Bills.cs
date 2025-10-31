using System;

namespace DataAccess
{
    // Lớp ánh xạ bảng Bills
    public class Bills
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TableID { get; set; }
        public int Amount { get; set; }
        public double? Discount { get; set; }
        public double? Tax { get; set; }
        public bool Status { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public string Account { get; set; }
    }
}