using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11NullNullable
{
    class Program
    {
        public class KieuDuLieu
        {
            /*
             -- Null => Sử dụng cho các kiểu dữ liệu tham chiếu VD: string, class..
             -- Nullable => Sử dụng cho các kiểu dữ liệu tham trị VD: int, float, double...

            - Với các biến tham trị không được gán trực tiếp giá trị null.
            - Vì ttrong nhiều trường hợp database vẫn nhận giá trị null cho các biến tham trị nên ta vẫn có thể gán giá trị null cho biến với cú pháp sau.
            */
            // Kieu tham tri
            public int? age = null;
            public Nullable<int> NamSinh = null;// Tương tự dòng trên
            // Kieu tham chieu
            public string Name = null;
        }
        static void Main(string[] args)
        {
        }
    }
}
