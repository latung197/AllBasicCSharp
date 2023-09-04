using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Bai33NetworkHttplistener
{
    class Program
    {
        static void  Main(string[] args)
        {
            // kiểm tra hệ thống có hỗ trợ Httplistener hay không
            if (HttpListener.IsSupported)
            {
                Console.WriteLine("le Tung");
                
            }

            var server = new HttpListener();
            server.Prefixes.Add("http://*:8080/");
            server.Start();

            do
            {
                var context = server.GetContext();
            }

            while (server.IsListening);
            //var context = await server.GetContextAsync();

        }


    }
}
