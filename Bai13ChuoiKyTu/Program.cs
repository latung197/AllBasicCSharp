using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13ChuoiKyTu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thêm dấu " vào chuối -> Cần đặt thêm: \" vào chuối.
            string s = "Le Van \"Tung\"";// - In ra : Le Van "Tung"

            // Thêm @   =>  Dữ nguyên cấu trúc của chuỗi kể cả khi chứa các ký tự đặc biệt /n hay /t ....
            string s1 = @"Le Van Tung \t \n
                        hien thi van ban y nhu chuoi minh nhap vao ke ca ky tu dac biet";

            //Thêm $ Cho phép gán định dạng trong chuỗi
            int nam = 2021;
            string s2 = $"Nam nay la nam {nam}"; // -> Nam nay la nam 2021

            Console.WriteLine(s+"\n" +s1+"\n"+s2);
            Console.ReadKey();
        }
    }
}
