using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17NgoaiLeException
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ngoại lệ là lỗi phát sinh sảy ra trong quá trình thưc thì trường trình khiến trường trình kết thúc đột ngột.
             * Khi không muốn trương trình kết thúc một cách đột ngột mà điều hướng sang một chỉ thị khác ta sử dung try catch
             */
            int a = 10;
            int b = 0;

            try
            {
                Console.WriteLine(a / b);

            }
            catch(Exception e)  
            {
                Console.WriteLine("Lỗi khi chạy! ");
                Console.WriteLine(e.Message);// Tên lỗi 
                Console.WriteLine(e.StackTrace);// Dấu vết sảy ra lỗi: VD ở đây sảy ra ở main file program.cs dòng số 22
                Console.WriteLine(e.GetType().Name);// Xác định được loại lỗi. Ở đây là loại lỗi thuộc lớp DivideByZeroException -> Lớp này là lớp kế thừa từ lớp exception -> Các lỗi chia cho 0 thay vì để exception ta có thì để lớp này => Lớp này chỉ bắt các lỗi chia cho 0 không bắt các lỗi khách
                    
            }

         

            Console.ReadKey();
        }
    }
}
