using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20Collection
{
    public class Program
    {
        public static void PrinDs(List<int> ds)
        {
            foreach (var x in ds)
            {
                Console.WriteLine(x);
            }
        }

        public class Products
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string Origin { get; set; }
        }

        // Danh sách lưu trữ tâp hợp các đối tượng có cùng kiểu dữ liệu.
        static void Main(string[] args)
        {
            #region co ban
            /*
            List<int> dsInt = new List<int>();
            dsInt.AddRange(new int[] {2,1,3,10,120,12,43,12,5,12,55 });
            var find = dsInt.FindAll((int x)=>
            {
                return x > 2;
            });
            PrinDs(find);

            Console.WriteLine("\n-----------------------------");

            for (int i=0; i < dsInt.Count; i++)
            {
                Console.WriteLine(dsInt[i]);
            }*/
            #endregion 

            List<Products> dssp = new List<Products>()
            {
                new Products(){Name ="Iphone", Price=7000, Origin="USA"},
                new Products(){Name ="Poco", Price=10000, Origin="China"},
                new Products(){Name ="Sonny", Price=1000, Origin="NhatBan"},
                new Products(){Name ="Vinmat", Price=20000, Origin="VietNam"}
            };
            // find
            var dsfind = dssp.Find((Products x) =>
            {
                return x.Origin == "NhatBan";

            });
            Console.WriteLine($"Ten {dsfind.Name} - Gia :{dsfind.Price} - Xuat xu :{dsfind.Origin} ");
            // findAll

            var dsfindAll = dssp.FindAll((Products x) =>
                {
                    return x.Price > 1000;
                });

            foreach (var ds1 in dsfindAll)
            {
                Console.WriteLine($"Ten {ds1.Name} - Gia :{ds1.Price} - Xuat xu :{ds1.Origin} ");
            }
            //  SortedList, khai báo, khởi tạo và ví dụ áp dụng SortedList để lưu danh sách được sắp xếp theo key
            SortedList<string, Products> ds = new SortedList<string, Products>();

            // Queue - Hàng đợi-> Vào trước ra trước
            Queue<int> hangDoi = new Queue<int>();
            hangDoi.Enqueue(10); //Thêm mới --->  Hang doi khi them thi them  vao cuoi danh sách
            hangDoi.Dequeue(); // Bớt phần tử --->  Chỉ phần tử đầu tiên bị bớt đi

            // Stack ---> Vào trước ra sau kiểu như xếp hàng vào kho -. Xếp trước thì ở dưới nên khi lấy sẽ ra sau
            Stack<int> stack = new Stack<int>();
            stack.Push(1); // Thêm mới vào trên cùng
            stack.Pop(); // Loại bỏ phần từ trên cùng

            // Dictionnary 
            Dictionary<int, string> keyValues = new Dictionary<int, string>();
            keyValues.Add(1, "Bien1");
            keyValues.Add(2, "Bien1");
            keyValues.Add(3, "Bien1");
            foreach (KeyValuePair<int, string> keyValuePair in keyValues)
            {
                Console.WriteLine($"key; {keyValuePair.Key} values: {keyValuePair.Value}");
            }

            // Hashset là tập hợp danh sách KHÔNG CHO PHÉP TRÙNG giá trị. HashSet<T> khác với các collection khác là nó cung cấp cơ chế đơn giản nhất để lưu các giá trị, nó không chỉ mục thứ tự và các phần tử không sắp xếp theo thứ tự nào.
            HashSet<int> hSet = new HashSet<int>();
            Console.ReadKey();
        }
       
    }
}
