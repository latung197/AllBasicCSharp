using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" + TinhGiaiThua(3));

            Console.WriteLine("" + SoHoanHao(14));

            Console.WriteLine("" + ChuoiNhoNhat("7269"));
            //Console.WriteLine("" + TongSoKeo(10,5,2));

            Console.WriteLine("123" + (int)"2");
            Console.ReadKey();

        }

        public static int TinhGiaiThua(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * TinhGiaiThua(n - 1);
            }
        }

        public static bool SoHoanHao(int n)
        {
            int m = 0;
            int p = n;
            if (p % 2 != 0 && p != 1)
            {
                p = (p - 1) / 2;
            }
            else
            {
                p = p / 2;
            }
            Console.WriteLine(p);
            for (int i = 1; i <= p; i++)
            {
                if (n % i == 0)
                {
                    m = m + i;
                    Console.WriteLine(i);
                }
            }

            if (m == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string ChuoiNhoNhat(string str)
        {
            int min = 0;
            String s = "";
            for (int i = 0; i < str.Length; i++)
            {

                string str1 = str.Remove(i, 1);
                if (i == 0)
                {
                    min = int.Parse(str1);
                    s = str[i].ToString();
                }
                else
                {
                    if (min > int.Parse(str1))
                    {
                        min = int.Parse(str1);
                        s = str[i].ToString();
                    }
                }
            }
            return s;
        }



        public int totalCandy(int m, int n, int c)
        {
            int k = m / n;
            int kq = k;
            while(k>= c)
            {
                int q = k / c;
                kq = kq + q;
                k = k % c + q;
            }
            return kq;
        }
    }
}



