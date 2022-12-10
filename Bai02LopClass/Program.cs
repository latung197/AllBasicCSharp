using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopClass
{
    class Program
    {
        /*
          - Class (lớp): là một kiểu dữ liệu tham chiếu được định nghĩa bởi tập hợp các thuộc tính và phương thức. Từ lớp đó sinh ra các đối tượng còn được gọi là biên bản triển khai của lớp (instance of a class), mối đối tượng có giá trị cụ thể (Lưu trong thành viên biến, thuộc tính) 
          - 4 Tính chất lập trình hướng đối tượng.
          1:Tính trừu tượng: Tổng quát hóa thông tin(Chỉ các thông tin tập trung cần thiết) mà không chi thông tin về đối tượng không gán cứng cho một đối tượng cụ thể nào đó nào đó(Triển khai với interface, abstract). 
          2: Tính đóng gói: Dữ liệu của đối tượng cố gắng như nằm trong hộp đen, các đối tượng khác không được trực tiếp truy cập tác động đến dữ liệu (VD: như chiếc ô tô thì người dùng chỉ cần lên xe và dùng chứ không cần biết bên trong xe có các bộ phận nào và thuộc tính chi tiết như thế nào). Các phương thức bên ngoài truy cập tác động vào thông qua các phương thức public cho phép, set,get.
          3: Tính đa hình: Đối tượng sẽ ứng xử khác nhau tùy trường hợp.
          Ví dụ ta có 3 loài vật là chó, lợn và mèo. 3 loài đều có tiếng kêu nhưng mỗi loài lại có tiếng kêu riêng, chó thì sủa "gâu gâu", lợn thì kêu "éc éc", mèo thì kêu "meo meo". Cùng là hành động kêu nhưng mỗi loài lại thực hiện theo các cách khác nhau
          4: Tính kế thừa: Đặc tính của lớp được kế thừa từ một lớp khác.
             */
        static void Main(string[] args)
        {
            VuKhi sungLuc;
            sungLuc = new VuKhi();
            sungLuc.Name = "Le Van Anh";
            Console.WriteLine(sungLuc.Name);
            SungTruong sungTruong = new SungTruong();
            sungTruong.Name = "Sung truong";
            sungTruong.SungBan();
            var sinhVien = new SinhVien();

            Console.ReadKey();
        }
    }
}
