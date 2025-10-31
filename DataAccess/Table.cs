using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Lớp ánh xạ bảng [Table]
    public class Table
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int Capacity { get; set; }
    }
}