using System.Net;
using System.Net.Sockets;
using System.Text;
using NP3hwLib;
namespace NP3hwClient
{
    public partial class Form1 : Form
    {
        private TcpClient server;
        private string filename = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            server = new TcpClient();
            await server.ConnectAsync(Library.GetLocalIPAdress(), 1648);
            ListenToServer();
        }
        private async void ListenToServer()
        {
            while (true)
            {
                byte[] buffer = new byte[1024];
                int count = await server.GetStream().ReadAsync(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, count);
            }
        }
        private void toolStripButtonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                filename = openFileDialog1.FileName;
        }
        private async void toolStripButtonSendFile_Click(object sender, EventArgs e)
        {
            
            if (filename != string.Empty)
            {
                Stream stream = server.GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(filename);
                await stream.WriteAsync(BitConverter.GetBytes(buffer.Length));
                await stream.WriteAsync(buffer);
                buffer = Encoding.UTF8.GetBytes(new FileInfo(filename).Length.ToString());
                await stream.WriteAsync(BitConverter.GetBytes(buffer.Length));
                await stream.WriteAsync(buffer);
                buffer = File.ReadAllBytesAsync(filename).Result;
                await stream.WriteAsync(BitConverter.GetBytes(buffer.Length));
                await stream.WriteAsync(buffer);
                filename = string.Empty;
            }
            
        }
    }
}