using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiaFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             - Khi một Class quá lớn => để quản lý từng chức năng trong Class ta có thể chia Class ra thành các file khác nhau => Mỗi file sẽ chưa một thuộc tính hoặc phương thức xử lý cụ thể nào đó của Class .
             Để tạo để tạo mới ta thêm từ kháo partial trước Class và tên class ở 2 file phải giống nhau.
             
             */
            Class1 class1 = new Class1();
            class1.In();
            class1.In1();
            Console.ReadKey();
        }
    }
}
