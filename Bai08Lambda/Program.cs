using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Biểu thức lambda hay hàm nặc danh là biểu thức không có tên chỉ có thân hàm.
             * lambda -  Anonymous 
            Các cách khai báo

             1 (Tham_so)=> bieu thuc

             2 (Tham_so)=>
            {
                Bieu thuc
            }
             - Biểu thức lambda vì không có tên nên phải gán vào một biểu thức delegate để thực thi
             - Biểu thức lambda có dữ liệu trả về => Dùng Func<>
             - Biểu thức lambda không có dữ liệu trả vê => Dùng Action<>
             */
            #region Bieu thuc lamda test
            //Không có giá trị trả về 
            Action ShowAddress;
            ShowAddress = () =>
            {
                Console.WriteLine("Địa chỉ: Tân Hòa - Quốc Oai - Hà Nội");
            };
            ShowAddress.Invoke();
            Action<string> Showinfo;
            Showinfo = (string Name) =>
            {
                Console.WriteLine(Name);
            };
            Showinfo.Invoke("Họ và tên: Lê Văn Tùng\n");

            // Có giá trị trả về
            Func<int, int, int> TinhTich;
            TinhTich = (int a, int b) =>
            {
                return a * b;
            };
            var tich = TinhTich.Invoke(10, 20);
            Console.WriteLine("Kế quả phép nhân: " + tich);

            int [] mangso = { 3, 4, 5, 7, 12, 43, 65, 7, 988, 53, 3, 12, 42 };
            var kqselect = mangso.Select((int x) => 
            {
                return x/2;
            });
            
            foreach(var inkqselect in kqselect)
            {
                Console.WriteLine(""+inkqselect);
            }

            var kqwhere = mangso.Where((int x)=> {
                if (x > 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            Console.WriteLine("Kết quả Where ");
            foreach (var inkqselect in kqwhere)
            {
                Console.WriteLine("" + inkqselect);
            }


            #endregion

            Action<string> In;
            In = (string Name) => Console.WriteLine(Name);
            In.Invoke("Le Van Tung");
            Action ThongBao;
            ThongBao = () =>
            {
                Console.WriteLine("Bieu Thuc Delegate khong co tham so va khong co gia tri dau vao");
            };
            ThongBao.Invoke();
            Action<string, string> ThongTin;
            ThongTin = (string ho_Ten, string dia_Chi) =>
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ho Ten: " + ho_Ten + " Dia chi: " + dia_Chi);
            };
            ThongTin.Invoke("Le Van Tung", "Tan Hoa Quoc Oai Ha Noi");

            // Biểu thức lambda có dữ liệu trả về => Dùng Func<>
            Func<int, int, int> TinhToan;
            TinhToan = (int a, int b) =>
            {
                int kq = a + b;
                return kq;
            };
            Console.WriteLine("" + TinhToan.Invoke(4, 7));


            // Sử dụng lambda trong tim kiếm (linq)
            int[] mang = { 1, 2, 3, 4, 5, 7, 9, 0, 12, 31, 55, 1 };

            var dsSoLe = mang.Where(
                (int z) =>
            {
                if (z % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            foreach (var z in dsSoLe)
            {
                Console.WriteLine(z);
            }

            var listMang = mang.Select(
                (int x) =>
                {
                    return Math.Sqrt(x);
                }
                );
            foreach (var c in listMang)
            {
                Console.WriteLine("" + c);
            }
            // Bieu thuc chuyen sang mang
            Console.WriteLine("Chuyen sang mang");
            mang.ToList().ForEach(
                (t) =>
                {
                    if (t % 2 == 0)
                    {
                        Console.WriteLine("" + t);
                    }
                }
                );
            // bieu thuc where
            Console.WriteLine("Bieu Thuc Where");
            var ketqua = mang.Where(
                (int z) =>
                {
                    if (z % 4 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                );
            foreach (var z in ketqua)
            {
                Console.WriteLine("" + z);
            }

            Console.ReadKey();
        }
    }
}

