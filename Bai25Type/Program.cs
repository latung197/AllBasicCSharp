using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bai25Type
{
    // Lop Type là thành phân cơ bản của dotnet lấy ra thông tin của kiểu dữ liệu ở thời điểm thực thi 
   public  class Program
    {
        static void Main(string[] args)
        {
            int [] a = {2,3,4,1,4 };
            Type type = typeof(int);
            var type2 = typeof(string);
            var type3 = a.GetType();
            Console.WriteLine(type.FullName);

            type3.GetProperties().ToList().ForEach(// Lấy tát cả các thuộc tính của đối tượng
                (PropertyInfo p) =>
                {
                    Console.WriteLine(p.Name);
                }
            );
            Console.ReadKey();
        }
    }
}
