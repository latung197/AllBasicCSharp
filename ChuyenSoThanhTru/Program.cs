using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenSoThanhChu
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = Utils.NumberToText(30);
            
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
