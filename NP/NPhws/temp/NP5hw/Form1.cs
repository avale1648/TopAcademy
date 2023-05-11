using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NP5hw
{
    public partial class Form1 : Form
    {
        private Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private IPEndPoint MulticastEndPoint = new IPEndPoint(IPAddress.Parse("224.100.0.1"), 1648);
        private Task receiver;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.UTF8.GetBytes(textBoxMessage.Text);
            socket.SendTo(message, SocketFlags.None, MulticastEndPoint);
            textBoxMessage.Clear();
        }
        private void PacketReceive()
        {
            EndPoint endPoint = MulticastEndPoint as EndPoint;
            byte[] buffer = new byte[1_024];
            string message = string.Empty;
            int recieve = 0;
            while(true)
            {
                recieve = socket.ReceiveFrom(buffer, ref endPoint);
                message = Encoding.UTF8.GetString(buffer,0, recieve);
                listBoxMessages.Items.Add($"{endPoint.ToString()}: {message}");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, 1648));
            socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse("224.100.0.1")));
            receiver = Task.Run(PacketReceive);
        }
    }
}