using System.Net;
using System.Net.Sockets;

namespace NP5hw
{
    class Program
    {
        private readonly UdpClient client = new UdpClient();
        private readonly CancellationTokenSource cts = new CancellationTokenSource();
        public static void Main(string[] args) => new Program().Run().Wait();
        private async void Listen()
        {

        }
        private async Task Run()
        {

        }
        IPAddress GetLocalIPAdress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            throw new Exception();
        }
    }
}