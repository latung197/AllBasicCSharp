using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;



namespace Bai32NetworkHttpMessageHandler
{
    public class Program
    {
        /*
         * Lớp HttpMessageHandler là lớp trừu tượng, nó là lớp cơ sở được thư viện .NET Core triển khai ra các lớp như DelegatingHandler, HttpMessageHandler, HttpClientHandler ... các lớp triển khai này (hoặc nếu tự xây dựng lớp triển khai HttpMessageHandler) thì phải nạp chồng phương thức SendAsync:
         */
         public static async Task<string> GetData()
        {

            var url = "https://postman-echo.com/post";

            var httpCliet = new HttpClient();
            var httpRequesMessage = new HttpRequestMessage();
            httpRequesMessage.Method = HttpMethod.Post;
            httpRequesMessage.RequestUri = new Uri(url);
            httpRequesMessage.Headers.Add("User-Agent", "Mozilla/5.5");
            var paremeter = new List<KeyValuePair<string, string>>();
            paremeter.Add(new KeyValuePair<string, string>("key1", "value1"));
            paremeter.Add(new KeyValuePair<string, string>("key2", "value2"));
            paremeter.Add(new KeyValuePair<string, string>("key3", "value3"));
            httpRequesMessage.Content = new FormUrlEncodedContent(paremeter);
            var repon = await httpCliet.SendAsync(httpRequesMessage);
            var html = await repon.Content.ReadAsStringAsync();
            Console.WriteLine(html);
            return html;
        }

        //public static async Task<string> GetCookies()
        //{
        //    var url = "https://postman-echo.com/post";
        //    var cookies = new CookieContainer();

        //}
        static void Main(string[] args)
        {
           Console.WriteLine(GetData().Result);
            
            Console.WriteLine("hii");
            Console.ReadKey();
        }
    }
}
