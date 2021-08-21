using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16StructEnum
{
    class Program
    {
        // Struct là kiểu dữ liệu tham trị <> Class là kiểu dữ liệu tham chiếu.
        public struct Product
        {
            public string Name;
            public double Price;
            public void GetInfo()
            {
                Console.WriteLine($"Ten san pham{Name}, Gia san pham {Price}");
            }
            
            // Phương thức tạo constructer
            // Phương thức tạo bắt buộc phải gán giá trị <> class thì không
            public Product (string _name, double _price)
            {
                this.Name = _name;
                this.Price = _price;
            }
        }

        // Kiểu dữ liệu enum
        enum HocLuc
        {
            kem,
            trungbinh,
            kha,
            gioi
        }
        static void Main(string[] args)
        {
            // Struct khởi tạo như một kiểu dữ liệu tham trị bình thường.
            Product sanPham;
            sanPham.Name = "IPhone";
            sanPham.Price = 10000;
            sanPham.GetInfo();
            // Kiểu liệt kê
            HocLuc hocLuc;
            hocLuc = HocLuc.gioi;
            switch (hocLuc)
            {
                case HocLuc.kem:
                    Console.WriteLine(HocLuc.kem);
                    break;
                case HocLuc.trungbinh:
                    Console.WriteLine(HocLuc.trungbinh);
                    break;
                case HocLuc.gioi:
                    Console.WriteLine(HocLuc.gioi);
                    break;
            }
            Console.ReadKey();
        }
    }
}
