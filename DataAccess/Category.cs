using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Lớp ánh xạ bảng Category [cite: 4230]
    public class Category
    {
        // ID của bảng, tự tăng trong CSDL [cite: 4235]
        public int ID { get; set; }
        

       // Tên của loại thức ăn [cite: 4238]
        public string Name { get; set; }
        

        // Kiểu: 0 là đồ uống; 1 là thức ăn... [cite: 4241]
        public int Type { get; set; }        
    }
}