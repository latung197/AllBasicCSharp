using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Bai29ThuVienDependenceInject
{
    /*
    - Lớp ServiceCollection: Là lớp triển khai giao diện IServiceCollection có chức năng quản lý các dịch vụ(Đăng ký dịch vụ, tạo dịch vụ, tự động Inject .)
     ServiceCollection là trung tâm của kỹ thuật DI, nó là thành phần rất quan trọng trong ứng dụng ASP.NET

    - Các sử dụng cơ bản như sau:

        Khởi tạo đối tượng ServiceCollection, sau đó đăng ký (lớp) các dịch vụ vào ServiceCollection
        Từ ServiceCollection phát sinh ra đối tượng ServiceProvider, từ đối tượng này truy vấn lấy ra các dịch vụ cụ thể khi cần

    - ServiceLifetime : Mõi lớp, dịch vụ đăng ký vào ServiceCollection thì có một đối tượng ServiceDescriptor chứa thông tin về dịch vụ đó, căn cứ vào ServiceDescriptor để ServiceCollection khởi tạo dịch vụ khi cần. Trong ServiceDescriptor có thuộc tính Lifetime để xác định dịch vụ tạo ra tồn tại trog bao lâu. Lifetime có kiểu ServiceLifetime (kiểu enum) có các giá trị cụ thể:

        - Khi đằng ký các dịch vụ vào service các dịch vụ đó tồn tại trong bao lâu gồm các kiểu:
    - Các kiểu dịch vụ : 
       1 - Scoped : Một bản thực thi (instance) của dịch vụ (Class) được tạo ra cho mỗi phạm vi, tức tồn tại cùng với sự tồn tại của một đối tượng kiểu ServiceScope (đối tượng này tạo bằng cách gọi ServiceProvider.CreateScope, đối tượng này hủy thì dịch vụ cũng bị hủy). Tức là chỉ tồn tại ở trong một khối lệnh 
       2 - Singleton: Duy nhất một phiên bản thực thi (instance of class) (dịch vụ) được tạo ra cho hết vòng đời của ServiceProvider

       3 - transitent: Một phiên bản của dịch vụ được tạo mỗi khi được yêu cầu
         */
    #region
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
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PHẦN 1: Các đối tượng service
            var services = new ServiceCollection();
            // Đăng ký các dịch vụ

            // 1 Singleton
            //services.AddSingleton<IClassC, ClassC>();
            // 2 transtion
            //services.AddTransient<IClassC, ClassC>();
            // 3 Scoped
            services.AddScoped<IClassC, ClassC>();

            var provider = services.BuildServiceProvider();
            for(int i =0; i <=5; i++)
            {
                var classC = provider.GetService<IClassC>();
                Console.WriteLine(classC.GetHashCode());
            }

            using(var scoped = provider.CreateScope())
            {
                // Sẽ tạo ra một đối tượng khác trong khối lệnh này
                var provider1 = scoped.ServiceProvider;
                for (int i = 0; i <= 5; i++)
                {
                    var classC = provider1.GetService<IClassC>();
                    Console.WriteLine(classC.GetHashCode());
                }
            }
             */

            

            Console.WriteLine("AAAAA");
            Console.ReadKey();
        }
    }
}
