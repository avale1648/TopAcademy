using System.Net;
using System.Net.Sockets;
using System.Text;

using (Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP))
{
    string message = Console.ReadLine();
    byte[] buffer = Encoding.UTF8.GetBytes(message);
    sender.SendTo(buffer, 0, buffer.Length, SocketFlags.None, new IPEndPoint(GetLocalIPAdress(), 1648));
    sender.Shutdown(SocketShutdown.Both);
}
IPAddress GetLocalIPAdress()
{
    var host = Dns.GetHostEntry(Dns.GetHostName());
    foreach (var ip in host.AddressList)
        if (ip.AddressFamily == AddressFamily.InterNetwork)
            return ip;
    throw new Exception();
}