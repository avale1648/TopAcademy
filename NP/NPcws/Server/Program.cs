// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
Socket listening = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
listening.Bind(new IPEndPoint(IPAddress.Parse("172.20.10.8"), 5678));
listening.Listen(10);
Console.WriteLine("Waiting connections on 5678 port");
while (true)
{
    using (Socket client = listening.Accept())
    {
        Console.WriteLine($"From {client.RemoteEndPoint}");
        DateTime now = DateTime.Now;
        string nowString = now.ToString();
        byte[] buffer = Encoding.UTF8.GetBytes(nowString);
        client.Send(buffer);
        client.Shutdown(SocketShutdown.Both);
    }
}
listening.Shutdown(SocketShutdown.Both);
listening.Close();
