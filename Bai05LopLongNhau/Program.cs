using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5LopLongNhau
{
    class Program
    {
        /*
        Lớp lồng nhau:
        Trong C# cho phép báo khai báo một lớp(Class), một cấu trúc(Struct), một giao diện(Interface) bên trong một lớp khác.
         */
        static void Main(string[] args)
        {
            VuKhi vuKhi = new VuKhi();
            vuKhi.In();
            vuKhi.sungTruong = new VuKhi.SungTruong();
            vuKhi.sungTruong.In();
            Console.ReadKey();
        }
    }
}
