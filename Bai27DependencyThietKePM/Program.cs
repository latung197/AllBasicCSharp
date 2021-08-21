using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Bai27DependencyThietKePM
{
    /*
    public class LopA
    {
        public int Id { get; set; }
        public void Action() => Console.WriteLine("A");
    }

    public class LopB
    {
        public void Action()
        {
            Console.WriteLine("B");
            LopA lopA = new LopA();
            lopA.Action();

        }
    }


    public interface IClassB
    {
        void ActionB();
    }

    public interface IClassC
    {
        void ActionC();
    }


    class ClassC:IClassC
    {
        public void ActionC() => Console.WriteLine("Action in ClassC");
    }

    class ClassB :IClassB
    {
        // Phụ thuộc của ClassB là ClassC
        IClassC c_dependency;

        public ClassB(IClassC classc) => c_dependency = classc;

      

        public void ActionB()
        {
            Console.WriteLine("Action in ClassB");
            c_dependency.ActionC();
        }
    }

    class ClassA
    {
        // Phụ thuộc của ClassA là ClassB
        IClassB b_dependency;

        public ClassA(IClassB classb) => b_dependency = classb;
        public void ActionA()
        {
            Console.WriteLine("Action in ClassA");
            b_dependency.ActionB();
        }
    }

    class ClassC1 : IClassC
    {
        public ClassC1() => Console.WriteLine("ClassC1 is created");
        public void ActionC()
        {
            Console.WriteLine("Action in C1");
        }
    }

    class ClassB1 : IClassB
    {
        IClassC c_dependency;
        public ClassB1(IClassC classc)
        {
            c_dependency = classc;
            Console.WriteLine("ClassB1 is created");
        }
        public void ActionB()
        {
            Console.WriteLine("Action in B1");
            c_dependency.ActionC();
        }
    }
    */

    /*
     Kỹ thuật lập trình Dependency Injection :
        + Xây dựng các lớp, dịch vụ có phụ thuộc nhau một cách lỏng lẻo, và lớp dependency có thể tiêm vào đối tượng injection - Thường qua các constructor, property, set, get
        + Xây dựng được một thư viện có thể tự động tạo ra các đối tượng, các dependency tiêm vào đối tượng đó, thường là áp dụng kỹ thuật Reflection của C#
     */
     public interface IClassB
    {
        void ActionB();
    }

    public interface IClassC
    {
        void ActionC();
    }

    class ClassC : IClassC
    {
        public void ActionC() => Console.WriteLine("Action in ClassC");
    }

    class ClassB : IClassB
    {
        // Phụ thuộc của ClassB là ClassC
        // => Ta thấy classB phụ thuộc vào interface C như vậy khi khởi tạo ở Main ta có thể thay thế tất cả các lớp khởi tạo từ interface C mà không cần sửa lại code Class B
        IClassC c_dependency;

        public ClassB(IClassC classc) => c_dependency = classc;
        public void ActionB()
        {
            Console.WriteLine("Action in ClassB");
            c_dependency.ActionC();
        }
    }

    class ClassA
    {
        // Phụ thuộc của ClassA là ClassB
        IClassB b_dependency;

        public ClassA(IClassB classb) => b_dependency = classb;
        public void ActionA()
        {
            Console.WriteLine("Action in ClassA");
            b_dependency.ActionB();
        }
    }

    class ClassC1 : IClassC
    {
        public ClassC1() => Console.WriteLine("ClassC1 is created");
        public void ActionC()
        {
            Console.WriteLine("Action in C1");
        }
    }

    class ClassB1 : IClassB
    {
        IClassC c_dependency;
        public ClassB1(IClassC classc)
        {
            c_dependency = classc;
            Console.WriteLine("ClassB1 is created");
        }
        public void ActionB()
        {
            Console.WriteLine("Action in B1");
            c_dependency.ActionC();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            #region Old
            /*
                IClassC objectC = new ClassC1();
                IClassB objectB = new ClassB1(objectC);
                ClassA objectA = new ClassA(objectB);

                objectA.ActionA();
                // Thu vien ho tro Dependency Ịnjection
                var service = new ServiceCollection();
                // dang ky cac dich vu
                service.AddSingleton<IClassC, ClassC>();
                var provader = service.BuildServiceProvider();

                var classc = provader.GetService<IClassC>();
            */
            #endregion

            IClassC objectC = new ClassC1();
            IClassB objectB = new ClassB1(objectC);
            ClassA objectA = new ClassA(objectB);
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));


            //Public.Convert_to_en_US(DateTime.Now),
            //                                        DateTime.Now.ToString("hh:mm:ss")

            objectA.ActionA();

            Console.ReadKey();
        }
    }
}
