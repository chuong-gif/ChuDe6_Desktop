using DataAccess; // Phải using tầng DataAccess
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
     // Lớp CategoryBL có các phương thức xử lý bằng Category 
    public class CategoryBL
    {
         //Đối tượng CategoryDA từ DataAccess 
          CategoryDA categoryDA = new CategoryDA();

        // Phương thức lấy hết dữ liệu
        public List<Category> GetAll()
        {
            return categoryDA.GetAll();
        }

         // Phương thức thêm dữ liệu 
        public int Insert(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 0); // 0 là action Thêm 
        }

         // Phương thức cập nhật dữ liệu [cite: 4416]
        public int Update(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 1); // 1 là action Sửa 
        }

         // Phương thức xoá dữ liệu 
        public int Delete(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 2); // 2 là action Xóa 
        }
    }
}