using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9Even
{
    /* Mô hình lập trình hướng sự kiện.
     Publisher -> Class --> phát sự kiện
     subseriber -> Class --> nhận sự kiện
         */

    public delegate void SuKienNhapSo(int x);
    public class UserInput
    {
        public SuKienNhapSo suKienNhapSo;

        public event EventHandler suKienNhapSoEV;
        // Khai báo kiểu dữ liệu EventHandler tương đương với delegate trả về Void kiểu (object  Sender, EventArgs args)


        public void InPut()
        {
            do
            {
                Console.WriteLine("Hay nhap so nguyen:");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                // Gọi hành động trong delegate tương tự như hành động phát đi sự kiện.
                suKienNhapSo?.Invoke(i);
                suKienNhapSoEV(this, new Dulieunhap (i));
            }
            while (true);

        }
    }

    public class Dulieunhap: EventArgs
    {
        public int data { set; get; }
        public Dulieunhap(int daTa)
        {
            this.data = daTa;

        }
    }

    public class TinhTrituyetdoi
    {
        public void sub(UserInput input)
        {
            input.suKienNhapSoEV += trituyetdoi;
        }
        public void trituyetdoi(object sender, EventArgs e)
        {
            Dulieunhap dulieunhap = (Dulieunhap) e;
            int i = dulieunhap.data;
            Console.WriteLine($"Tri tuyet doi cua A : {Math.Abs(i)}");
        }
    }

    public class TinhCan
    {
        public void sub(UserInput input)
        {
            input.suKienNhapSo += Can;
        }
        public void Can(int i)
        {
            Console.WriteLine($"Can bac hai cua so {i} laf {Math.Sqrt(i)}");
        }

    }

    public class Tinhbinhphuong
    {
        public void sub(UserInput userInput)
        {
            userInput.suKienNhapSo += BinhPhuong;
        }
        public void BinhPhuong(int i)
        {
            Console.WriteLine($"Binh phuong cua I la: {i * i}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
     
            TinhCan tinhCan = new TinhCan();
            tinhCan.sub(userInput);
            Tinhbinhphuong tinhbinhphuong = new Tinhbinhphuong();
            tinhbinhphuong.sub(userInput);

            TinhTrituyetdoi Ttrituyetdoi = new TinhTrituyetdoi();
            

            userInput.suKienNhapSoEV += (sender, e) =>
             {
                 Dulieunhap dulieunhap = (Dulieunhap)e;
                 Console.WriteLine($"Ban vua nhap so: {dulieunhap.data}");
             }; 

            userInput.InPut();
        }
    }
}
