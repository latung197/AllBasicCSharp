using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14TinhKeThua
{
    // Thêm từ khóa public sealed class Animal -> Class khác sẽ không được phép kế thừa từ lớp Animal
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Khoi tao lop co so");
        }
        public int legs { get; set; }
        public float weight { get; set; }
        public virtual void ShowLegs()
        {
            Console.WriteLine($"So chan: {legs}");
        }
    }

    public class Cat : Animal
    {
        private string food { get; set; }
        public Cat()
        {
            this.legs = 4;
            this.weight = 3;
            this.food = "Mouse";
            // Van truy cap duoc tu lop con k truy cap duoc tu ben ngoai
        }

        // Để khởi tạo lớp kế thừa mới cùng tên từ lớp cha ta sử dụng từ khóa new

        public override void ShowLegs()
        {
            Console.WriteLine($"So chan cua meo: {legs}");
        }

        // Để gọi tới phương thức của lớp cha (lớp cơ sở) nếu lớp con đã có phương thức cũng tên ta sử dụng từ khóa base. 
        public void ShowInfo()
        {
            base.ShowLegs();
        }
    }

    // Chển kiểu giữa các lớp cơ sở và lớp kế thừa.
    class A { };
    class B : A { };
    class C : B { };
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.ShowLegs();
            //c.ShowInfo();

            A a;
            B b;
            C c1;
            a = new B();
            a = new C();
            b = new C();
            // -> Lớp cha có thể ép kiểu sang các lớp kế thừa nhưng ngược lại thì không.
            Console.ReadKey();
        }
    }
}
