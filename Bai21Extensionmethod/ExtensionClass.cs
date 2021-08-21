using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21Extensionmethod
{
   public static class ExtensionClass
    {
        public static void Inchuoi(this string a)
            {
                Console.WriteLine(a);
            }
        public static void CongChuoi(this string s, string t)
        {
            Console.WriteLine(t+s);
        }

        public static void Info(this Products products)
        {
            Console.WriteLine($"Id san pham: {products.ID} - Ten san pham :{products.Name}.");
        }
    }
}
