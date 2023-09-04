using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Bai32NetworkHttpMessageHandler
{
    public class Program
    {
        /*
         * Lớp HttpMessageHandler là lớp trừu tượng, nó là lớp cơ sở được thư viện .NET Core triển khai ra các lớp như DelegatingHandler, HttpMessageHandler, HttpClientHandler ... các lớp triển khai này (hoặc nếu tự xây dựng lớp triển khai HttpMessageHandler) thì phải nạp chồng phương thức SendAsync:
         */
        //public static async Task<string> GetData()
        //{

        //    var url = "https://postman-echo.com/post";

        //    var httpCliet = new HttpClient();
        //    var httpRequesMessage = new HttpRequestMessage();
        //    httpRequesMessage.Method = HttpMethod.Post;
        //    httpRequesMessage.RequestUri = new Uri(url);
        //    httpRequesMessage.Headers.Add("User-Agent", "Mozilla/5.5");
        //    var paremeter = new List<KeyValuePair<string, string>>();
        //    paremeter.Add(new KeyValuePair<string, string>("key1", "value1"));
        //    paremeter.Add(new KeyValuePair<string, string>("key2", "value2"));
        //    paremeter.Add(new KeyValuePair<string, string>("key3", "value3"));
        //    httpRequesMessage.Content = new FormUrlEncodedContent(paremeter);
        //    var repon = await httpCliet.SendAsync(httpRequesMessage);
        //    var html = await repon.Content.ReadAsStringAsync();
        //    Console.WriteLine(html);
        //    return html;
        //}

        //public static async Task<string> GetCookies()
        //{
        //    var url = "https://postman-echo.com/post";
        //    var cookies = new CookieContainer();

        //}

        public static async Task<string> GetWebContent(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
            string html = await httpResponseMessage.Content.ReadAsStringAsync();
            return html;
        }


        public static async Task<byte[]> DowloadDataBytes(string url)
        {
            HttpClient httpClient = new HttpClient();
            try
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

                var bytes = await httpResponseMessage.Content.ReadAsByteArrayAsync();
                return bytes;
            }
            catch
            {
                return null;
            };
           

        }


        static void  Main(string[] args)
        {
            //Console.WriteLine(GetData().Result);

            string url = "https://www.google/search?q=xuanthulab";
            string url1 = "https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png";

            //var bytes = await DowloadDataBytes(url1);

            //var task = GetWebContent(url);
            //task.Wait();
            //var html = task.Result;
            //Console.WriteLine(html);
            //var uri = new Uri(url);
            //var urltype = typeof(Uri);
            //urltype.GetProperties().ToList().ForEach(property =>
            //{
            //    Console.WriteLine($"{property.Name,15}  {property.GetValue(uri)}");
            //});
            //Console.WriteLine("hii");
            //var ping = new Ping();
            //Console.WriteLine(Dns.GetHostName());
            Console.ReadKey();
        }
    }
}
