using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5LopLongNhau
{
    //Lớp lồng nhau (kiểu Nested) trong C#
    public class VuKhi
    {
        public void In()
        {
            Console.WriteLine("ten sung");
        }

        public SungTruong sungTruong { get; set; }

        public class SungTruong
        {
            public string Name { get; set; }
            public void In()
            {
                Console.WriteLine("Sung Truong");
            }
        }
    }
}
