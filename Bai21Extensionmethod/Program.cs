using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21Extensionmethod
{
    /* 
     * Extension method (Phương thức mở rộng) cho phép thêm các phương thức vào các Class đã có sẵn mà không là thay đổi cấu trúc của lớp cũ -> Không phải sửa lại code cũ.
     
     */
    public class Products
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Products (string ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
    public class Program
    {
        
        public static void Main(string[] args)
        {
            // Thêm phương thức in chuỗi và cộng chuỗi vào Class tring có sãn.
            string s = "Le Van Tung";
            s.Inchuoi();
            s.CongChuoi("Ho Va Ten: ");
            // Thêm phương thức Info vào Class Products
            Products products = new Products("1", "Iphone");
            products.Info();
            Console.ReadKey();
        }
    }
}
