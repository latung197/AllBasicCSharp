using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19Generic
{
    class Program
    {
        // Cách viết cũ
        /*
        public static void Swap(ref int a, ref int b)
        {
            int z = a;
            a = b;
            b = z;
        }
        * Phương thức Swap trên chỉ nhận giá trị kiểu Int.
        * Vì truyền theo kiểu dữ liệu nên khi sử dụng kiểu dữ liệu khác ta phải viết lại code (Quá tải toán tử : hay phương thức NẠP TRỒNG TOÁN TỬ)
        public static void Swap(ref string a, ref string b)
        {
            string z = a;
            a = b;
            b = z;
        }
        * Phương thức Swap trên chỉ nhận giá trị kiểu string
        */

        /* Genaric Ta định dạng một kiểu dữ liệu T -> Kiểu T là kiểu nào thì khi chạy trương trình sẽ biết
         * => DÙNG CHUNG CHO TẤT CẢ CÁC KIỂU DỮ LIỆU KHÁC NHAU HAY CLASS KHÁC NHAU CÓ CÙNG MỘT MỤC ĐÍCH
         
         VD: Đổi chỗ cho 2 giá trị có kiểu dữ liệu bất kỳ .

         - Từ khóa ref : Khai báo ref trước biến để thông báo truyền giá trị tham chiếu -> Tức là khi chạy xong phương thức thì giá trị a b truyền bên ngoài vào cũng thay đổi.
         - Khi hàm cần lưu 1 giá trị trả về ta sử dụng return nếu nhiều hơn ta sử dụng từ khóa ref học out
        */
        public static void Swap<T>(ref T a, ref T b)
        {
            T z = a;
            a = b;
            b = z;
        }

        static void Main(string[] args)
        {
            double a = 5;
            double b = 10;
            Console.WriteLine($"a: {a}---- b:{b}");
            Program.Swap(ref a, ref b);
            Console.WriteLine($"a: {a}---- b:{b}");
            Product<int> product = new Product<int>(100);
            product.PrinIfo();
            Product<string> product1 = new Product<string>("ID Kieu Chuoi");
            product1.PrinIfo();

            SanPham<int> sanPham = new SanPham<int>(100);
            sanPham.inThongTin();
            SanPham<string> sanPham1 = new SanPham<string>("Dien thoai Iphone");
            sanPham1.inThongTin();
            Console.ReadKey();


            // Cac kieu du lieu xay dung du tren kieu Genaric
            // List<int>
            // Stack<int>
            // Queue<string>

        }
    }

    public class SanPham<T>
    {
        public T id { get; set; }
        public SanPham(T id)
        {
            this.id = id;
        }
        public void inThongTin()
        {
            Console.WriteLine("Thong tin san pham: "+this.id +"$");
        }
    }

    public class Product<T>
    {
        public T Id { get; set; }
        public Product(T Id)
        {
            this.Id = Id;
        }
        public void PrinIfo()
        {
            Console.WriteLine($"Gia tri ID :{this.Id}");
        }
    }
}
