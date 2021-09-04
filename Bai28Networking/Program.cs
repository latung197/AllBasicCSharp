using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;

namespace Bai28Networking
{

    class Program
    {
        public static void ShowHeaders(HttpResponseHeaders responseHeader)
        {
            Console.WriteLine("Cac headers");
            foreach(var header in responseHeader)
            {
             Console.WriteLine(header.Key +"----"+ header.Value);

            }
        }

        public static async Task<string> GetWebContant(string url)
        {
            var httpClient = new HttpClient();
            try
            {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
            ShowHeaders(httpResponseMessage.Headers);
            string html = await httpResponseMessage.Content.ReadAsStringAsync();
            return html;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Lỗi!";
            }
        }


        public static async Task<byte[]> DownloadDataBytes(string url)
        {
            var httpClient = new HttpClient();
            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                ShowHeaders(httpResponseMessage.Headers);
                var  html = await httpResponseMessage.Content.ReadAsByteArrayAsync();
                return html;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static async Task DownloadStream(string url, string filesName)
        {
            var httpClient = new HttpClient();
            try
            {
                var streamwrite = File.OpenWrite(filesName);

                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                var stream = await httpResponseMessage.Content.ReadAsStreamAsync();
                int SIZEBUFFER = 500;
                var buffer = new byte[SIZEBUFFER];
                bool endread = false;
                do
                {
                    int numByte = await stream.ReadAsync(buffer, 0, SIZEBUFFER);
                    if (numByte == 0)
                    {
                        endread = true;
                    }
                    else
                    {
                      await streamwrite.WriteAsync(buffer, 0, numByte);
                    }
                }
                while (!endread);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static async Task<string> GetMessage()
        {
            var httpClient = new HttpClient();
            var httpMessageRequest = new HttpRequestMessage();
            httpMessageRequest.Method = HttpMethod.Get;
            httpMessageRequest.RequestUri = new Uri("https://www.google.com.vn");
            //httpMessageRequest.Headers.Add("User_name", "Moghila 5.0");

            var httpReponMessage = await httpClient.SendAsync(httpMessageRequest);
            var html = await httpReponMessage.Content.ReadAsStringAsync();
            return html;

        }
        public static async Task<string> PostMessage()
        {
            var httpClient = new HttpClient();
            var httpMessageRequest = new HttpRequestMessage();
            httpMessageRequest.Method = HttpMethod.Post;
            httpMessageRequest.RequestUri = new Uri("https://www.googlhttps://postman-echo.com/post");
            //httpMessageRequest.Headers.Add("User_name", "Moghila 5.0");
            var parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string> ( "Key1", "Value1" ));
            parameters.Add(new KeyValuePair<string, string> ( "Key2", "Value2" ));
            parameters.Add(new KeyValuePair<string, string> ( "Key3", "Value3" ));
            parameters.Add(new KeyValuePair<string, string> ( "Key4", "Value4" ));
            parameters.Add(new KeyValuePair<string, string> ( "Key5", "Value5" ));
            var constent = new FormUrlEncodedContent(parameters);
            httpMessageRequest.Content = constent;
            var httpReponMessage = await httpClient.SendAsync(httpMessageRequest);
            var html = await httpReponMessage.Content.ReadAsStringAsync();
            return html;

        }


        static void Main(string[] args)
        {
            /*
             * Phân tích url : https://xuanthulab.net/lap-trinh/csharp/?page=3#acff#section
             * https : Giao thức chuyền http hoặc https....
             * xuanthulab.net : Host hoăc domain
             * csharp : Đường dẫn trên server để dẫn đến tài nguyên, hiện này không hẳn là đường dẫn mà là ánh xạ của đường dẫn trên server
             * ?page=3#acff : query là chuỗi truy vấn, nó chứa các tham số ví dụ ?a=1&b=price, bắt đầu chuỗi query là dấu ? mỗi tham số thường gồm key=value, các tham số cách nhau bởi &
             * #section : fragment (ví dụ #section), trỏ đến một phần củ thể trong tài nguyên, ví dụ một vị trí nào đó trong văn bản HTML.
            */
            string url = "https://xuanthulab.net/lap-trinh/csharp/?page=3#acff";
            var uri = new Uri(url);
            var uritype = typeof(Uri);
            uritype.GetProperties().ToList().ForEach(property => {
                Console.WriteLine($"{property.Name,15} {property.GetValue(uri)}");
            });
            Console.WriteLine($"Segments: {string.Join(",", uri.Segments)}");

            /* là hệ thống phân giải tên miền, giúp cho các trình client (như các trình duyệt) truy vấn để chuyển đổi một tên miền (như xuanthulab.net) sang địa chỉ IP vật lý tương ứng của tên miên đó. Sau đó địa chỉ IP này được dùng để kết nối client/server. Dữ liệu DNS được lưu trữ và phục vụ truy vấn từ các Server DNS được vận hành bởi các nhà cung cấp dịch vụ và các tổ chức*/
            Console.WriteLine("----------------------------DNS \n");
            /*
             * Lớp tính DNS : Là lớp cung cấp các phương thức để lấy thông tin về host về hệ thống phân giải tên miền Dns. Các thông tin truy vấn được trả về một đối tượng giai diện IpHostEntry
             * 
             */
            var hostName = Dns.GetHostName();
            Console.WriteLine(hostName);

            Console.WriteLine("----------------xuan thu lap\n");
            var Url = "https://xuanthulab.net";
            var Uri = new Uri(Url);
            Console.WriteLine(Uri.Host);

            Console.WriteLine("---------------- lớp Ping \n");
            /*--------------------------------*/
            // Lop Ping
            //var ping = new Ping();
            //var pingReply = ping.Send("google.com.vn"); 
            //Console.WriteLine(pingReply.Status);
            //if (pingReply.Status == IPStatus.Success)
            //{
            //    Console.WriteLine(pingReply.RoundtripTime);
            //    Console.WriteLine(pingReply.Address);
            //}
            /*
            Console.WriteLine("---------------- Http \n");
            var task = GetWebContant("https://www.google.com/search?q=xuanthulap");
            task.Wait();
            Console.WriteLine(task.Result);

            Console.WriteLine("------------------ Dowload");
            var dataByte  =  DownloadDataBytes("");
            */
            Console.WriteLine("------------------ Senmessage");
            //var task = GetMessage();
            //task.Wait();
            //Console.WriteLine(task.Result);
            Console.WriteLine("-----------------Post");
            Console.WriteLine(PostMessage());
            Console.ReadKey();
        }
    }
}
