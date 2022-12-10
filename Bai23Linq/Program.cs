using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai23Linq
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // cá màu
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";

    }

    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }
    }

    public class SanPham
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // các màu sản phẩm
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public SanPham(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        public override string ToString()
          => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";
    }

    public class ThuongHieu
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            #region lan1 dong
            /*
            var brands = new List<Brand>() {
                    new Brand{ID = 1, Name = "Công ty AAA"},
                    new Brand{ID = 2, Name = "Công ty BBB"},
                    new Brand{ID = 4, Name = "Công ty CCC"},
            };  

            var products = new List<Product>()
                    {
                    new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                    new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                    new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                    new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                    new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                    new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                    new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
                    };


            var query = from p in products
                        where p.Price == 400
                        select p;

            foreach(var p in query)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\n------------------------------ select");
            // Phuong thuc select
            var kq = products.Select((p) => { return new {p.Name, p.Price }; }); // VD tra ve 1 kieu vo danh
            foreach (var p in kq)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\n------------------------------ where");
            // Phuong thuc Where
            var kq1 = products.Where((p) => { return p.Price >= 200 && p.Price <= 400; });
            foreach (var p in kq1)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\n-----------------------------selectmany");
            // tra ve tap hop cac phan tu chu khong phai tap hop cac chuoi cac mang
            var kq2 = products.SelectMany((p) => { return p.Colors; });
            foreach (var p in kq2)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("\n-----------------------------MaxMin");
            int[] number = { 1, 2, 3, 5, 1, 52, 44, 112,12, 41, };
            Console.WriteLine(number.Max());
            Console.WriteLine(number.Where(n=>n%2!=0).Max());
            Console.WriteLine(products.Min(p => p.Price));

            Console.WriteLine("\n-----------------------------MaxMin");
            //phuong thuc join
            var kq3 = products.Join(brands, p => p.Brand, b => b.ID, (p, b) => { return new { ten = p.Name, b.Name }; });
            foreach (var p in kq3)
            {
                Console.WriteLine(p.ToString());
            }

            // Phuong thuc group join

            //var kq4 = brands.GroupJoin(products, b => b.ID, p => p.Brand, ());

            Console.WriteLine("\n-----------------------------orderby");
            products.OrderBy(p => p.Price).ToList().ForEach(p=>Console.WriteLine(p.ToString()));

            // Phuong thuc group
            Console.WriteLine("\n-----------------------------Groupby");
            var kq6 = products.GroupBy(p => p.Price);

            Console.WriteLine("\n-----------------------------Distinct");
            // Phuong thuc distinct
            products.SelectMany(p => p.Colors).Distinct().ToList().ForEach(p => Console.WriteLine(p));

            // Phuong thuc join tuong duong inner join 
            var kq7 = from p in products
                      join b in brands on p.Brand equals b.ID
                      select new { ten = p.Name, gia = p.Price, thuonghieu = b.Name };
            kq7.ToList().ForEach(p => Console.WriteLine(p.ToString()));
            Console.ReadKey();
            */
            #endregion 

            SanPham sanPham = new SanPham(1, "Iphone", 10000, new string[] { "sanh", "Do" }, 1000);
            Console.WriteLine(sanPham);


            List<ThuongHieu> thuongHieus = new List<ThuongHieu>()
            {
                new ThuongHieu{ID=1,Name = "Cong Ty AAA"},
                new ThuongHieu{ID=2,Name = "Cong Ty BBB"},
                new ThuongHieu{ID=3,Name = "Cong Ty CCC"}
            };

            List<SanPham> sanPhams = new List<SanPham>()
            {
                    new SanPham(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                    new SanPham(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                    new SanPham(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                    new SanPham(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                    new SanPham(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                    new SanPham(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                    new SanPham(7, "Tủ áo",      600, new string[] {"Trắng"},               3)
            };

            // Lay ra san pham co gia bang 400

            var query1 = from p in sanPhams
                         where p.Price == 400
                         select p;

            foreach (SanPham p in query1)
            {
                Console.WriteLine(p);
            }

            var query2 = sanPhams.Select(
                (p) => { return p.Name; }
                );

            foreach (var p in query2)
            {
                Console.WriteLine(p);
            }

            var query3 = sanPhams.Where((p) =>
            {

                return (p.Price >= 200 && p.Price <= 300 && p.ID == 4);
            });

            foreach (var p in query3)
            {
                Console.WriteLine(p);
            }

            int[] dsSo = { 2, 3, 4, 5, 6, 32, 53, 23, 65, 3, 432 };

            Console.WriteLine(dsSo.Where((x) => { return x % 2 != 0; }).Min());
            var dsso1 = dsSo.Where((p) =>
            {
                return p % 2 == 0;
            });
            foreach (int x in dsSo)
            {
                Console.WriteLine("-" + x);
            }
            Console.WriteLine(sanPhams.Average((p) => { return p.Price; }));
            // left join 
            var query4 = sanPhams.Join(thuongHieus, p => p.Brand, q => q.ID, (p, q) => { return new { ten = p.Name, thuonghieu = q.Name }; });

            foreach (var p in query4)
            {
                Console.WriteLine(p.ten + p.thuonghieu);
            }

            // Group join 
            var query5 = thuongHieus.GroupJoin(sanPhams, p => p.ID, q => q.Brand, (th, prd) =>
            {
                return new { ThuongHieu = th.Name, cacsanphams = prd };
            });

            foreach (var p in query5)
            {
                Console.WriteLine(p.ThuongHieu + p.cacsanphams);
            }
            // Take :  Lấy n Sản phẩm đầu tiên
            sanPhams.Take(3).ToList().ForEach((p) => { Console.WriteLine(p); });
            Console.WriteLine("-----------------------");

            //Skip : Bỏ qua n phần từ đầu tiên và lấy các phần tử còn lại.
            sanPhams.Skip(3).ToList().ForEach((p) => { Console.WriteLine(p); });
            Console.WriteLine("-----------------------");

            // order by
            sanPhams.OrderBy(p => p.Price).ToList().ForEach((p) => { Console.WriteLine(p); });
            Console.WriteLine("-----------------------");

            // Selectmany: 
            sanPhams.SelectMany(p => p.Colors).ToList().ForEach((p) => { Console.WriteLine(p); });
            Console.WriteLine("-----------------------");

            // Single : Kiểm tra xem có chỉ 1 phần tử thỏa mãn logic thì trả về phần tử đó-> nếu không có hoặc có nhiều hơn 1 => lỗi
            var kq = sanPhams.Single((p) => { return p.ID == 3; });
            Console.WriteLine(kq.Name);
            // SingleOrDefault : Kiểm tra xem phần tử thóa mãn logic nào đó nếu 0 có trả về null nếu nhiều hơn 1 thỏa mãn => Lỗi
            Console.WriteLine("-----------------------");

            //Any : trả về true nếu thỏa mãn 1 điều kiện nào đó
            var kq2 = sanPhams.Any((p) => { return p.Price == 600; });
            Console.WriteLine(kq2);
            Console.WriteLine("-----------------------");

            //All : Phương thức trả về true nếu tất cả các phần tử thỏa mãn một điều kiện nào đó và ngược lại nếu 1 phần tử không thỏa mãn.
            var kq3 = sanPhams.All((p) => { return p.Price >= 600; });
            Console.WriteLine(kq3);

            // In ra tên sản phầm, tên thương hiệu, lấy ra các sản phẩm từ 300 đến 400 sắp xép giảm dần theo giá.

            sanPhams.Where((p) => { return p.Price >= 200 && p.Price <= 400; }).OrderByDescending(p => p.Price).Join(thuongHieus, p => p.Brand, q => q.ID, (sp, th) => { return new { tensp = sp.Name, gia = sp.Price, thuonghieu = th.Name }; }).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-----------------------");

            /*
             1: Cú pháp của LinQ:
             2: Xác định phần tử: from in IEnumerable
             where, order by
             */

            var q4 = from p in sanPhams
                     where p.Price == 300
                     select $"";
            q4.ToList().ForEach(p => Console.WriteLine(p));


            Console.ReadLine();


        }
    }
}
