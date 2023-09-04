using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Web;
using System.Net.Http;

namespace Bai24Multithreading
{

    public class Program
    {
        public static void DoSomeThing(int seconds, string mes, ConsoleColor color)
        {
           // Console.WriteLine(mes + "Start");

            for (int i = 0; i < seconds; i++)
            {

                Console.ForegroundColor = color;
                Console.WriteLine(mes);
                Console.ResetColor();
                Thread.Sleep(1000);
            }

        }

        #region Noi dung
        /* 
        - Từ khóa Look : Thực hiện khóa biến _str => Biến chỉ được phép sử dụng trong luồng này khi nào luồng này chạy xong thì       luồng khác với được phép tiếp tục sử dụng.
            Sử dụng từ khóa look để tránh hiện tượng khi luồng A đang sử biên _str dụng thì luồn B nhảy vào sử dụng biến _str.

        string _str="Tung";
        lock (_str)
        {
            _str = "Le Van Tung";
            Console.WriteLine(_str);
        }
            Chạy xong các tác vụ trong look thì luồng khác với được phép gọi đến _str.

        Từ khóa ' async ' Khi sử dụng sẽ phải dụng dụng từ khóa ' await  '  đảm bảo tác vụ chạy xong thì với in ra tác vụ hoàn thành, trong quá trình chạy không khóa luồng mà vẫn cho phép các luông khác chay.

    public async static Task Task2()
    {
        Task t2 = new Task((Object obj) => {
            string _tacVu = obj.ToString();
            DoSomeThing(10, _tacVu, ConsoleColor.White);
        }, "Tac Vu 2");
        t2.Start();
        await t2;
        Console.WriteLine("Tac vu 2 da hoan thanh");
        //return t2;
    }

    // VD tai du lieu tu 1 trang web
    public static async Task<string> GetWeb(string Url)
    {
        HttpClient client = new HttpClient();
        Console.WriteLine("Bat dau tai trang web");
        HttpResponseMessage kq = await client.GetAsync(Url);
        Console.WriteLine("Bat dau doc noi dung ");

        string content =  await kq.Content.ReadAsStringAsync();
        Console.WriteLine("Hoan thanh");

        return content; 
    }

    public async static Task Task3()
    {
        Task t3 = new Task(() => { DoSomeThing(10, "Tac Vu 1", ConsoleColor.Blue); });
        t3.Start();
        await t3;
        Console.WriteLine("Tac vu 1 da hoan thanh");
    }

    static  void Main(string[] args)
    {
        //KHOI TAO TRUC TIEP
        /*
        Task t2 = new Task(()=> { DoSomeThing(10, "Tac Vu 1",ConsoleColor.Blue); });
        Task t3 = new Task((Object obj)=> {
            string _tacVu = obj.ToString();
            DoSomeThing(10, _tacVu, ConsoleColor.White);
        },"Tac Vu 2");

        t2.Start();// Bat dau chay luong t2
        t3.Start();
        DoSomeThing(10, "Tac Vu 3",ConsoleColor.Yellow);

        //Tu khoa:  wait - Từ khóa đảm bảo tác vụ t2, t3 phải hoản thành thì với thực hiện chỉ thị tiếp theo -> ở đây là in ra Bấm phím bất kỳ
        // Từ khóa:  Task.waiAll()  - chức năng tương tự như trên nhưng có thể nhập cho nhiều luồng.
        // Task.WaitAll(t2, t3);
        t2.Wait();
        t3.Wait();

        Console.WriteLine("Bam phim bat ky:");
        */

        /*----------------------------------------*/

        // KHOI TAO QUA HAM
        /*
        // Tu khoa AsYn
        Task t4 = Task2();
        Task t5 = Task3();
        DoSomeThing(10, "Tac Vu 3", ConsoleColor.Yellow);
        Console.WriteLine("Bam phim bat ky:");


        // KHOI TAO TAC VU CO KIEU TRA VE

        //Task<string> t6 = new Task<string>(()=> { DoSomeThing(2, "T6", ConsoleColor.Yellow); return "Ke qua task 6"; });
        //Task<string> t7 = new Task<string>((Object oj) => { string _s = oj.ToString(); DoSomeThing(2, "T7", ConsoleColor.Red);
        //    return $"{_s}";
        //}, "Ke qua task 7");

        //t6.Start();
        //t7.Start();
        //Task.WaitAll(t6, t7);
        //Console.WriteLine(t6.Result.ToString());
        //Console.WriteLine(t7.Result.ToString());

        //var content = await GetWeb("https://xuanthulap.net");
        //Console.WriteLine(content);

        Console.WriteLine("Da thuc thi xong");

        Console.ReadKey();*/
        #endregion

        public static async Task<string> asyn1(string _str1, string _str2)
        {
            Func<object, string> myFunc = (object ob) =>
              {
                  dynamic ts = ob;
                  for (int i = 0; i <= 10; i++)
                  {
                      Console.WriteLine($"{i,5} {Thread.CurrentThread.ManagedThreadId,3} Tham số {ts.x} {ts.y}",
                          ConsoleColor.Green);
                      Thread.Sleep(500);
                  }
                  return $"Ket thuc luong {ts.x}";
              };
            Task<string> task = new Task<string>(myFunc, new { x = _str1, y = _str2 });
           
            await task;
            Console.WriteLine("Sau khi tast 1 chay xong");
            return "Task 1";
           
        }

        public static async Task<string> asyn2()
        {
            Action myAction = () =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i,5} {Thread.CurrentThread.ManagedThreadId,3}",
                         ConsoleColor.Yellow);
                    Thread.Sleep(2000);
                }
            };
            Task task = new Task(myAction);
            await task;
            return "Task 2";
        }

        static void Main(string[] args)
        {
           
            //Task<string> t1 = Program.asyn1("A", "B");
            //Task<string> t2 = Program.asyn2();
            //await t1;
            //await t2;
            DoSomeThing(10, "Xin chao 2", ConsoleColor.Gray);
            Console.WriteLine("Bấm phấm bất kỳ!");
            Console.ReadKey();
       
        }
    }
}

