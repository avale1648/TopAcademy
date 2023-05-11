using System.Net;
using System.Net.Sockets;
using System.Text;
using NP3hwLib;

namespace NP3hwServer
{
    public class Program
    {
        private ICollection<TcpClient> clients = new List<TcpClient>();
        public static void Main(string[] args) => new Program().Run().Wait();
        private async Task Run()
        {
            TcpListener listener = new TcpListener(new IPEndPoint(IPAddress.Any, 1648));
            listener.Start();
            Console.WriteLine("Ожидание входящих соеднинений");
            WaitIncomingConnectionsAsync(listener);
            Console.ReadKey();
        }
        private async void WaitIncomingConnectionsAsync(TcpListener listener)
        {
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                lock (clients)
                    clients.Add(client);
                ServeClient(client);
            }
        }
        private async void ServeClient(TcpClient client)
        {
            while (true)
            {
                byte[] buffer = await Library.BufferedReadBlock(client.GetStream());
                string response = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                IEnumerable<TcpClient> copy;
                lock (clients)
                    copy = clients.ToList();
                await Task.WhenAll(copy.Select(other => other.GetStream().WriteAsync(buffer, 0, buffer.Length)));
            }
        }
    }
}
