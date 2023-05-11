using System.Net.Sockets;
using System.Net;

namespace NP3hwLib
{
    public class Library
    {
        public async static Task<byte[]> BufferedReadBlock(Stream stream)
        {
            byte[] prefixedBuffer = await BufferedRead(stream, sizeof(int));
            int length = BitConverter.ToInt32(prefixedBuffer);
            byte[] response = await BufferedRead(stream, length);
            return response;
        }
        public async static Task<byte[]> BufferedRead(Stream stream, int length)
        {
            byte[] buffer = new byte[length];
            for (int progress = 0; progress < length;)
            {
                int chunk = await stream.ReadAsync(buffer, progress, length - progress);
                progress += chunk;
            }
            return buffer;
        }
        public static IPAddress GetLocalIPAdress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            throw new Exception();
        }
    }
}