using System.Net.Sockets;

namespace _Client_NP2cw
{
    public partial class Form1 : Form
    {
        private TcpClient server;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            server = new TcpClient();
            await server.ConnectAsync("192.168.1.127", 1648);
            ListenToServer();
        }

    }
}