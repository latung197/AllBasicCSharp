using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Program
    {
        #region -- Noi dung 
        /*
         *Delegate là một kiểu dự liệu dùng để tham chiếu, trỏ đến các hàm các phương thức có tham số có kiểu trả về phù hợp với kiểu khai báo 
        public delegate void ShowTen(string name);
        // Kiểu Action sử dụng khi biểu thức không có giá trị trả về .
        public Action<int, string, double> action; // Tương đương delegate void ShowTen(int tuoi,string name,double namsinh)
        
        public delegate int TinhTong(int a, int b);
        // Kiểu Func sử dụng khi biểu thức có dữ liệu trả về
        Func<int, int, int> func; //Tương đương  public delegate int TinhTong(int a, int b);
        public void InHo(string ho)
        {
            Console.WriteLine("Le");
        }

        public void InTenDem(string tenDem)
        {
            Console.WriteLine("Van");
        }
        public void InTen(string tenBan)
        {
            Console.WriteLine("Tung");
        }
        */
        #endregion

        #region - lan 1 
        public delegate void ShowLog(string mess);
        Action<string> showinfo;
        Func<int, int, int> TinhTich;
        public void Info(string s)
        {
            Console.WriteLine(s);
        }

        

        public void Hoten(string s)
        {
            Console.WriteLine("Hien thi ho ten");
            Console.WriteLine(s);
        }
        public delegate int PhepNhan(int a, int b);

        #endregion
        public delegate int TinhCongTru(int a, int b);
        public Func<int, int, int> TinhCongTru1;
        public Action<string> Show;

        public int TinhTichAB(int a, int b)
        {
            return a * b;
        }

        public int TinhTong(int a , int b)
        {
            return a + b;
        }

        public int TinhHieu(int a, int b)
        {
            return a - b;
        }

        public void ShowInfo(string HoTen)
        {
            Console.WriteLine(HoTen);
        }

        static void Main(string[] args)
        {
            /*Program program = new Program();
            ShowTen showTen = null;
            showTen = program.InHo;
            showTen.Invoke("1111");*/
            TinhCongTru tinhCongTru = null;// Voi ham kieu delegate ta phai khoi tao
            Program program = new Program();
            tinhCongTru = program.TinhTong;
            Console.WriteLine($"Tong hai so: {tinhCongTru.Invoke(20, 10)}");
            program.TinhCongTru1 = program.TinhHieu; // Voi ham kieu func hoc Action ta khoi tao tu class

            program.Show = program.ShowInfo;
            program.Show.Invoke("Le Van Tung 1997");

            ShowLog showLog = null;
            showLog = program.Info;
            showLog += program.Info;
            showLog += program.Hoten;
            showLog.Invoke("Xin chao Viet Nam");

            tinhCongTru += program.TinhTong;

            program.showinfo = program.Info;
            program.showinfo.Invoke("Action");
            program.TinhTich = program.TinhTichAB;
            Console.WriteLine("" + program.TinhTich.Invoke(20, 30));
            Console.ReadKey();
        }


    }
}
