using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12Mang
{

    class Program
    {
        public class SinhVien
        {
            public SinhVien()
            {

            }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            /*
             - Mảng: Là một kiểu cấu trúc lưu tập hợp các đối tượng có cũng kiểu dữ liệu.
             */
            
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 9, 0, 12, 42, 12 };
            double[,] mang2chieu = new double[2, 4] { {1,2,3,1 },{ 3,1,2,3} };
            SinhVien sinhVien = new SinhVien();
            SinhVien sinhVien1 = new SinhVien();
            List<SinhVien> ds = new List<SinhVien>();
            ds.Add(sinhVien1);
        }
    }
}
