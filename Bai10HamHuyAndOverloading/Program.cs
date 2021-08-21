using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bai10HamHuy
{
    /*
     * Phương thức tĩnh, trường dữ liệu tĩnh 
     */

    public class CountNumber
    {
        public static int number = 0;
        public static readonly double pi = 10;
        public static void Infor()
        {
            Console.WriteLine("So lan truy cap: " + number);
        }
    }

    public class VuKhi
    {
        public static int _number = 10;
        public readonly double _pi = 3.14;
        public static void In()
        {
            Console.WriteLine("Phuong thuc tinh");
        }
    }

    public class Vector
    {
        public double x { get; set; }
        public double y { get; set; }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Info()
        {
            Console.WriteLine($"x={x}, y ={y}");
        }
        // khởi tạo quá tải toán tử (Operator overloading) Đây là nạp trồng toán tử
        /* 
         * C# định nghĩa sẵn một số phép toán + - * : cho các kiểu dữ liệu như int, float ...  nhưng các định nghĩa này lại không thể sử dụng cho các class , struct ma lập trình viên tự định nghĩa 
           => Nên ta dùng nạp trồng toán tử để định nghĩa lại các các phép toán cho các kiểu dữ liệu mà lập trình viên khởi tạo
         */
        //Ví dụ nạp trồng toán tử + cho vecter cú pháp trung
        public static Vector operator +(Vector a, Vector b)
        {
            //return new Vector(a.x + b.x, a.y + b.y);
            double sx = a.x = b.x;
            double sy = a.y + b.y;
            Vector vector = new Vector(sx, sy);
            return vector;
        }
        // khai bao index(Gan chi muc cho cac gia chi cua class)

        public double this[int i]
        {
            set
            {
                switch (i)
                {
                    case 1:
                        x = value;
                        break;
                    case 2:
                        y = value;
                        break;
                    default:
                        throw new Exception("Chi so sai");
                }
            }
            get
            {
                switch (i)
                {
                    case 1:
                        return x;
                    case 2:
                        return y;
                    default:
                        throw new Exception("Chi so sai");
                }
            }
        }
    }
    /*
     - Phương thức hủy
     1: Một lớp chỉ được khỏi tạo một hàm hủy
     2: Muốn quản lý quá trình thu hồi -> ta kể thừa từ lớp Idisposeaple
         */
    public class SinhVien : IDisposable
    {
        public string Name { get; set; }
        public SinhVien(string Name)
        {
            this.Name = Name;
            Console.WriteLine("Khoi Tao Sinh Vien");
        }

        ~SinhVien()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Huy Doi Tuong");
            Console.ResetColor();
        }

        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Huy Doi Tuong(Boi Dispose)");
            Console.ResetColor();
        }

    }

    public class Program
    {

        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("chuoi ket noi");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from ", sqlConnection);
            using (DataSet ds = new DataSet())
            {

            };

            VuKhi.In();

            Vector vector1 = new Vector(2, 3);
            Vector vector2 = new Vector(5, 11);
            Vector v = vector1 + vector2;
            Console.WriteLine(v.x + "");


            // Indexer
            // v[toado1]~ x
            // v[toado2]~ y

            Vector vector3 = new Vector(5, 6);
            vector3[1] = 10;
            vector3[2] = 20;
            Console.WriteLine($"x{vector3.x}, y {vector3.y}");
            // Huy boi dispose
            // De su dung phuong thuc Dispose t phai su dung tu khoa using o dau=> khi ra khoi pham vi using phuong thuc dispose duoc goi
            using (SinhVien sinhVien = new SinhVien("le Van Tung"))
            {
                // cac thuc thi cua SV
            }

            // Huy boi ham huy
            //SinhVien sv;
            //for(int i =0; i < 1000000; i++)
            //{
            //    sv = new SinhVien("Sinh vien"+i);
            //    // khi gan = null se goi den ham huy
            //    sv = null;
            //}
            Console.ReadKey();
        }
    }
}
