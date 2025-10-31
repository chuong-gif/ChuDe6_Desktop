using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Lớp ánh xạ bảng [Role]
    public class Role
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string Path { get; set; }
        public string Notes { get; set; }
    }
}