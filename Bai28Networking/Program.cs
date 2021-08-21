using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Http;

namespace Bai28Networking
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://xuanthulab.net/lap-trinh/csharp/?page=3#acff";
            var uri = new Uri(url);
            var uritype = typeof(Uri);
            uritype.GetProperties().ToList().ForEach(property => {
                Console.WriteLine($"{property.Name,15} {property.GetValue(uri)}");
            });
            Console.WriteLine($"Segments: {string.Join(",", uri.Segments)}");

            /* là hệ thống phân giải tên miền, giúp cho các trình client (như các trình duyệt) truy vấn để chuyển đổi một tên miền (như xuanthulab.net) sang địa chỉ IP vật lý tương ứng của tên miên đó. Sau đó địa chỉ IP này được dùng để kết nối client/server. Dữ liệu DNS được lưu trữ và phục vụ truy vấn từ các Server DNS được vận hành bởi các nhà cung cấp dịch vụ và các tổ chức*/
            var hostName = Dns.GetHostName();
            Console.WriteLine(hostName);
            /*--------------------------------*/
            // Lop Ping
            var ping = new Ping();
            var pingReply = ping.Send("google.com.vn");
            Console.WriteLine(pingReply.Status);
            if (pingReply.Status == IPStatus.Success)
            {
                Console.WriteLine(pingReply.RoundtripTime);
                Console.WriteLine(pingReply.Address);
            }

            Console.ReadKey();
        }
    }
}
