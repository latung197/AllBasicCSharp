using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15InterfaceAbstract
{
    /*Phan 1: Ghi đè
     
         */
    public class Product
    {
        protected double Price { get; set; }
        // Một phương thức nếu muốn cho phép được ghi đè ta thêm từ khóa Virtual
        public virtual void ProductInfo()
        {
            Console.WriteLine($"Gia san pham {Price}");
        }
    }
    public class Iphone: Product
    {
        public Iphone() => Price = 300;
        void abc() => Console.WriteLine("Bieu thuc ABC");
        int TingTong(int a, int b) => a + b;

        // Để ghi đè phương thức từ lớp cha ta thêm từ khóa khoa override
        // Để gọi phương thức của lớp cha ta sử dụng từ khóa base.ProductInfo();
        public override void ProductInfo()
        {
            base.ProductInfo();// base. là phương thức gọi đến phương thức khi chưa bị ghi đè ở lớp cha
            Console.WriteLine("Day la In cua Iphone");
        }
        public void Test() => ProductInfo();
    }

    /* Phan 2 : 
     * Phương thức ảo: Chỉ dùng để làm phương thức cơ sở cho các lớp khác kế thừa.
        - Lớp này không được sử dụng để khởi tạo đối tượng.
        - Lớp ảo chỉ khai báo các phương thức ảo và các lớp kế thừa PHẢI TRIỂN KHAI các phương thức của nó.
        --> Khi tạo thư viện cập nhật tất cả các lớp con kế thừa sẽ phải cập nhật
         */
        

    public abstract class product1
    {
        public abstract void Product1Info();
    }


    public class Iphone1 : product1
    {
        // Triển khai phương thức.
        public override void Product1Info()
        {
        }
    }

    /* Phan 3 : 
     * Interface khá giống abstruct
       
     */
    public interface IHinhHoc
    {
         double TinhDienTich();
         double TinhChiVi();
    }

    public class HinhChuNhat : IHinhHoc
    {
        public double x { get; set; }
        public double y { get; set; }

        public HinhChuNhat(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public double TinhChiVi()
        {
            return 2 * (x + y);
        }

        public double TinhDienTich()
        {
            return x * y;
        }   
    }

    public class HinhTron : IHinhHoc
    {
        public double bankinh { get; set; }
        public HinhTron(Double chuvi)
        {
            this.bankinh = chuvi;
        }
        public double TinhChiVi()
        {
            return 2* bankinh * Math.PI;
        }

        public double TinhDienTich()
        {
            return bankinh * bankinh * Math.PI;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Iphone iphone = new Iphone();
            iphone.Test();
            // Khi khởi tạo phương thức ta sử dụng lớp giao diện () code se la doi tuong khac nhau tuy khoi tao -> TÍNH ĐA HÌNH
            IHinhHoc doiTuong = new HinhTron(3);

            /*IHinhHoc doiTuong = new HinhChuNhat(3,4); 
             * Khi sử dụng giao diện thay đổi giá trị khởi tạo ta không phải sửa code trong console.writeline bên dưới ->Hạn chế phải sửa code nhưng vẫn thay đổi được các phương thức tùy vào đổi tượng khởi tạo. */
            Console.WriteLine(""+ doiTuong.TinhDienTich());

            Console.ReadKey();
        }
    }
}
