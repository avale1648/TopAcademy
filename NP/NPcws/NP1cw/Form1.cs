using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NP1cw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonTime_Click(object sender, EventArgs e)
        {
            using (Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
            {
                server.Connect(new IPEndPoint(IPAddress.Parse("172.20.10.8"), 5678));
                byte[] buffer = new byte[1024];
                int count = server.Receive(buffer);
                string dateStr = Encoding.UTF8.GetString(buffer, 0, count);
                textBox1.Text = dateStr;
                server.Shutdown(SocketShutdown.Both);
            }
        }
    }
}