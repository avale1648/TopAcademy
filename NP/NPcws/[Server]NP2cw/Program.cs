using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;



namespace _Server_NP2cw
{
    class Program
    {
        static void Main(string[] args) => new Program().Run().Wait();



        private ICollection<TcpClient> clients = new List<TcpClient>();



        private async Task Run()
        {
            TcpListener listen = new TcpListener(
            new IPEndPoint(IPAddress.Parse("192.168.1.127"), 1648)
            );
            listen.Start();
            Console.WriteLine("Слушаю входящие соединения на порт 1648");



            WaitIncomingConnectionsAsync(listen);



            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }



        private async void WaitIncomingConnectionsAsync(TcpListener listen)
        {
            while (true)
            {
                TcpClient newClient = await listen.AcceptTcpClientAsync();
                lock (clients)
                    clients.Add(newClient);
                ServeClient(newClient);
            }
        }



        private async void ServeClient(TcpClient client)
        {
            while (true)
            {
                byte[] buffer = new byte[1024];
                int count = await client.GetStream()
                .ReadAsync(buffer, 0, buffer.Length);
                // допустим, что сообщение не распилилось
                // string str = Encoding.UTF8.GetString (buffer, 0, count);
                IEnumerable<TcpClient> copy;
                lock (clients)
                    copy = clients.ToList();



                //List<Task> tasks = new List<Task> ();
                //foreach (TcpClient other in copy) {
                //    tasks.Add (other.GetStream().WriteAsync(buffer, 0, count));
                //}
                //await Task.WhenAll (tasks);



                await Task.WhenAll(copy
 .Select(other => other.GetStream().WriteAsync(buffer, 0, count)));
            }
        }
    }
}