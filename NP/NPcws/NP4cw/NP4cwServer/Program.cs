using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;

using (Socket receiver = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP))
{
    EndPoint endPoint = new IPEndPoint(GetLocalIPAdress(), 1648);
    receiver.Bind(endPoint);
    byte[] buffer = new byte[1024];
    receiver.ReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPoint);
    Console.WriteLine(Encoding.UTF8.GetString(buffer));
    receiver.Shutdown(SocketShutdown.Both);
}
IPAddress GetLocalIPAdress()
{
    var host = Dns.GetHostEntry(Dns.GetHostName());
    foreach (var ip in host.AddressList)
        if (ip.AddressFamily == AddressFamily.InterNetwork)
            return ip;
    throw new Exception();
}