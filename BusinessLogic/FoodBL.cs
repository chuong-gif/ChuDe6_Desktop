using DataAccess; // Phải using tầng DataAccess
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
     //Lớp FoodBL có các phương thức xử lý bảng Food 
    public class FoodBL
    {
         //Đối tượng FoodDA từ DataAccess 
          FoodDA foodDA = new FoodDA(); 

         // Phương thức lấy hết dữ liệu 
        public List<Food> GetAll()
        {
              return foodDA.GetAll(); 
        }

         // Phương thức lấy về đối tượng Food theo khoa chính 
        public Food GetByID(int ID)
        {
              List<Food> list = GetAll(); 
              foreach (var item in list) 
            {
                  if (item.ID == ID) // Nếu gặp khoa chính 
                    return item; // thì trả về kết quả 
            }
              return null; 
        }

         // Phương thức tìm kiếm theo khoá 
        public List<Food> Find(string key)
        {
              List<Food> list = GetAll(); 
              List<Food> result = new List<Food>(); 
            
             // Duyệt theo danh sách 
            foreach (var item in list)
            {
                 // Nếu từng trường chứa từ khoá 
                  if (item.ID.ToString().Contains(key)
                     || item.Name.Contains(key)
                     || item.Unit.Contains(key)
                     || item.Price.ToString().Contains(key)
                     || item.Notes.Contains(key)) 
                    result.Add(item); // Thi thêm vào danh sách kết quả 
            }
              return result; 
        }

         // Phương thức thêm dữ liệu 
        public int Insert(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 0); // 0 là action Thêm 
        }

         // Phương thức cập nhật dữ liệu 
        public int Update(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 1); // 1 là action Sửa 
        }

         // Phương thức xoá dữ liệu 
        public int Delete(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 2); // 2 là action Xóa 
        }
    }
}