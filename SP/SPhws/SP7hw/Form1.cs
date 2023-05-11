using System.Drawing.Text;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SP7hw
{
    public partial class Form1 : Form
    {
        private TextBox[] originals = new TextBox[0];
        private TextBox[] encryptings = new TextBox[0];
        private bool areFilesOpened = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.Multiselect = true;
            originals = new TextBox[] { textBox1, textBox2, textBox3, textBox4 };
            foreach (var original in originals)
                original.Enabled = false;
            encryptings = new TextBox[] { textBox5, textBox6, textBox7, textBox8 };
            foreach (var encrypting in encryptings)
                encrypting.Enabled = false;
        }
        private async void tsButtonSelectFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            areFilesOpened = true;
            if (openFileDialog1.FileNames.Length != 4)
            {
                MessageBox.Show("You have to select four files", "Incorrect number of selected files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                areFilesOpened = false;
                return;
            }
            await Task.Run(() =>
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    using (FileStream reader = File.OpenRead(openFileDialog1.FileNames[i]))
                    {
                        byte[] buffer = new byte[reader.Length];
                        reader.ReadAsync(buffer, 0, (int)reader.Length);
                        Invoke(() => originals[i].Text = Encoding.UTF8.GetString(buffer));
                    }
                }
            });
        }
        private async void tsButtonEncrypt_Click(object sender, EventArgs e)
        {
            if(!areFilesOpened)
            {
                MessageBox.Show("Files aren't selected", "Files aren't selected", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
            await Task.Run(() =>
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    using (FileStream writer = File.OpenWrite(openFileDialog1.FileNames[i]))
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes(originals[i].Text);
                        for (int j = 0; j < buffer.Length; j++)
                        {
                            buffer[j]++;
                            if (buffer[j] > 255) buffer[j] = 0;
                        }
                        Invoke(() => encryptings[i].Text = Encoding.UTF8.GetString(buffer));
                        writer.WriteAsync(buffer, 0, buffer.Length);
                    }
                }
            }
            );
        }
        private async void tsButtonDecrypt_Click(object sender, EventArgs e)
        {
            if (!areFilesOpened)
            {
                MessageBox.Show("Files aren't selected", "Files aren't selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await Task.Run(() =>
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    using (FileStream writer = File.OpenWrite(openFileDialog1.FileNames[i]))
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes(originals[i].Text);
                        for (int j = 0; j < buffer.Length; j++)
                        {
                            buffer[j]--;
                            if (buffer[j] < 0) buffer[j] = 255;
                        }
                        Invoke(() => encryptings[i].Text = Encoding.UTF8.GetString(buffer));
                        writer.WriteAsync(buffer, 0, buffer.Length);
                    }
                }
            }
            );
        }
    }
}