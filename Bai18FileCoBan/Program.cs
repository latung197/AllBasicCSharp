using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Bai18FileCoBan
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo drive = new DriveInfo("C");
            Console.WriteLine($"Ten o dia {drive.Name}");
            Console.WriteLine($"Dung luong con trong{drive.TotalFreeSpace}");
            Console.WriteLine($"Ding dang o dia{drive.DriveFormat}");

            string path = "Abc";
            // cu phap tao file voi duong dan path
            Directory.CreateDirectory(path);
            if (Directory.Exists(path))
            {
                Console.WriteLine($"Thu muc da duoc tao");
            }
            // cu phap xoa file voi duong dan path
            Directory.Delete(path);

            if (!Directory.Exists(path))
            {
                Console.WriteLine($"Thu muc da xoa");
            }
            // Lay tat ca ten cac file trong thu muc nao do vd: C:\Users\Admin\Downloads\ITG WORK
            var files = Directory.GetFiles(@"C:\Users\Admin\Desktop\ITG WORK");
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("\n--------------------------");
            // Lop path
            // Sinh mot ten file ramdom
            var randomNameFile = Path.GetRandomFileName();
            Console.WriteLine(randomNameFile);

            // Lop File
            String fileName = @"D:\TongHopKienThuc\AllBasicCSharp\Bai18FileCoBan\DanhSachFileTest\lopFile.txt";
            File.WriteAllText(fileName,"Xin chao cac ban 2021");
            //File.WriteAllText : chay tiep se xoa file hien tai va cap nhap moi
            //File.AppendAllText: chay tiep se ghi tiep file da co
            // Doc file
            string conten = File.ReadAllText(fileName);
            Console.WriteLine(conten);
            //File.Move(fileName, "abc.txt"): Di chuyen file
            //File.Copy(fileName, fileName2): Copy fileName sang fileName2
            Console.WriteLine("\n--------------------------");
            // Lop FileStream
            string fileNameStream = @"D:\TongHopKienThuc\AllBasicCSharp\Bai18FileCoBan\DanhSachFileTest\lopFileStream.txt";
            using (var stream = new FileStream(fileNameStream, FileMode.OpenOrCreate))
            {

            }

            Console.ReadKey();
        }
    }
}
