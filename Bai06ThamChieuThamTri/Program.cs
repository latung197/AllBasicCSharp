using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ba6ThamChieuThamTri
{
    public class student
    {
        public string Name { get; set; }
        public student(string student)
        {
            this.Name = student;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             -- Tham trị: Biến sẽ lưu giá trị của đối tượng cần lưu trữ
                + các kiểu tham trị : byte, Int, long, float, double, decema, bool, char, struct , enum, Tuple
                int a = 10;
                int b = a;
                b = 20;
                => gia trị a vẫn là 10 
             -- Tham chiếu: Biến sẽ lưu địa chỉ ô nhớ chứa giá trị cần lưu trữ 
                + Các kiểu tham trị: string, class, delegate, interface, dynamic, object
                string a = "Tung";
                string b = a;
                b = "Le Van Tung"; => giá chị địa chỉ ô nhớ thay đổi
                => Giá trị của a là : "Le Van Tung" 
                => b = a <=> gán địa chỉ ô nhớ trỏ đến của b = a .
             */



        student student = new student("Le Van Tung");
            student b ;
            b = student;
            b.Name = "AAAAAAA";
            Console.WriteLine(student.Name);
            Console.ReadKey();
        }
    }
}
