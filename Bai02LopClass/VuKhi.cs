using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopClass
{
    public class VuKhi // Măc dinh là internar
    {
        public string Name
        {
           
            set
            {
                Console.WriteLine("Vua khoi tao du lieu cho thuoc tinh Namelan 1");
            }

            get
            {
                Console.WriteLine("Vua lay du lieu tu thuoc tinh Name");
                return "Het";
            }
        }
        public VuKhi()
        {
        }
        public void SungBan()
        {
            Console.WriteLine("Bung Bung");
        }


    }
}
