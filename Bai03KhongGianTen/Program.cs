using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhongGianTen.KhongGian1;// de su dung cac class hoc namepace ta khai bao them tai day
namespace KhongGianTen
{
    class Program
    {
        static void Main(string[] args)
        {
            VuKhi vuKhi = new VuKhi();
            vuKhi.In();

            KhongGian2.VuKhi vuKhi1 = new KhongGian2.VuKhi();
            vuKhi1.In();

            KhongGianTen3.Khonggianten3 khonggianten3 = new KhongGianTen3.Khonggianten3();
            khonggianten3.Info();
            
            Console.ReadKey();
        }
    }
}
