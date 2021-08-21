using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7KieuVoDanhVaDynamic
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string NoiSinh { get; set; }
        public void Info()
        {
            Console.WriteLine($"Ten Sinh Vien: {this.HoTen}");
        }
    }

    public class Program
    {
      

        /*
         - Kiểu dynamic cho cho phép khơi tạo biến khi chưa hề có đối tượng. Phần mềm vẫn cho buil project => Chỉ báo lỗi kho chạy đến đọa trương trình đó mà không có đối tượng đã khởi tạo
         */
        public void PrintInfo(dynamic dynamic) 
        {
            dynamic.HoTen = "Le Van Tung";
            dynamic.Info();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            /*
             * Kiểu vô danh Var là kiểu dữ liệu được xác đinh sau khi được gán giá trị. Kiểu dữ liệu của biến chính là kiểu dữ liệu của biến được gán. Mỗi biến Var chỉ gán kiểu dữ liệu một lần và mặc định kiểu dữ liệu đó không tháy đổi sau đó.
             */
            var VoDanh = new {  name = "Le Van Tung", tuoi =25};
            Console.WriteLine(VoDanh.name+ " " + VoDanh.tuoi);

            SinhVien sinhVien = new SinhVien();
            program.PrintInfo(sinhVien);
            List<SinhVien> listSV = new List<SinhVien>()
            {
                new SinhVien(){HoTen = "Tung", NamSinh=1997,NoiSinh="Ha Noi" },
                new SinhVien(){HoTen = "Tung", NamSinh=2000,NoiSinh="Ha Noi" },
                new SinhVien(){HoTen = "Tung", NamSinh=2001,NoiSinh="Ha Noi" },
                new SinhVien(){HoTen = "Tung", NamSinh=2001,NoiSinh="Ha Noi" }
            };
            var ketQua = from sv in listSV
                         where sv.NamSinh > 2000
                         select new SinhVien {HoTen = sv.HoTen, NoiSinh = sv.NoiSinh };

            foreach(SinhVien sv in ketQua)
            {
                Console.WriteLine(sv.HoTen+"  "+sv.NoiSinh);
            }
            Console.ReadKey();


        }
    }
}
