using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bai33NetworkHttplistener
{
    class Program
    {
        public static async Task<string> CreateServer()
        {
            var server = new HttpListener();
            server.Prefixes.Add("http://*:8080/");
            server.Start();
            Console.WriteLine("Openserver");
            do
            {
                var context = await server.GetContextAsync();
                var reponen = context.Response;
                var outputstream = reponen.OutputStream;
                var html = "<H1>Xin Chao </H1>";
                var bytes = Encoding.UTF8.GetBytes(html);
                await outputstream.WriteAsync(bytes, 0, bytes.Length);
                outputstream.Close();
            }
            while (server.IsListening);
            return "aaa";
        }
        static void Main(string[] args)
        {
            if(HttpListener.IsSupported)// Kiểm tra xem hệ thống có hõ trợ HttpListener không
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NO");
            }
            var a =  CreateServer();
            a.Wait();
            Console.ReadKey();
        }
    }
}
