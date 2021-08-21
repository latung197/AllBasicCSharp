using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Bai26Atribute
{
    /*Attribute : Thuộc tính bổ xung thêm cho lớp. Các thuộc tính này thường được sử dụng bới các thư viện hoặc famework hoặc trình biên dịch.
     * VD: EntytiFramwork
     */

    /*-- Bai tap: Ta tu tao 1 Attribute
     Mo ta thong tin chi tiet
        - ThongTinChiTiet
         */

    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Property)] // Mô tả Atribute Mota dưới được sử dụng ở đâu (lop, property, method ...)=> Ở đây ta gán cả class hoặc method hoặc property.
    public class MotaAttribute:Attribute // Khi khởi tạo đuôi class phải la Attribute  và kế thừa từ class Attribute.
    {
        public string ThongTinChiTiet { get; set; }
        public MotaAttribute(string _thongTinChiTiet)
        {
            this.ThongTinChiTiet = _thongTinChiTiet;
        }
    }

    [Mota("Mo ta nguoi dung")]
    public class Username
    {
        [Mota("Ten nguoi dung")]
        public string Name { get; set; }
        [Mota("Id")]
        public int Id { get; set; }
        [Mota("Email nguoi dung")]
        public string Email { get; set; }

        //Giả sử thêm 1 phương thức đánh dấu 1 phương thức đã lỗi thời không nên sử dụng.
        [Obsolete("Phuong thuc nay da loi thoi nen su dung ShowInfo")]
        public void PrinInfo()
        {
            Console.WriteLine(Name);
        }
    }


    public class Username1      
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }

        // Gia su them 1 thuoc tinh danh dau 1 phuong thuc loi thoi
        public void PrinInfo()
        {
            Console.WriteLine(Name);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Username username = new Username();
            username.Id = 10;
            username.Name = "Le Van Tung";
            username.Email = "TungLv197@gmail.com";
            var property = username.GetType().GetProperties();
            foreach(PropertyInfo attr in property)
            {
                foreach (var q in attr.GetCustomAttributes(false))
                {
                    MotaAttribute mota = q as MotaAttribute;
                    if(mota != null)
                    {
                        var name = attr.Name;
                        Console.WriteLine($"{mota.ThongTinChiTiet}");
                    }

                }

            }
            username.PrinInfo();
            

            Console.ReadKey();

        }
    }
}
