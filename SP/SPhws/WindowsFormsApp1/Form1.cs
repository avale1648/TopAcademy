using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private Semaphore semaphore = new Semaphore(4,4);
        private int currentIndex = 0;
        private ProgressBar[] progressBars = new ProgressBar[4];
        public Form1()
        {
            InitializeComponent();
        }
        private void Copy()
        {
            semaphore.WaitOne();
            byte[] buffer = new byte[1024];
            int total = 0;
            using (Stream @out = File.Create(currentIndex + "in.dat"))
            {
                using (Stream @in = File.OpenRead(currentIndex + "out.dat"))
                {
                    int read = @in.Read(buffer, 0, buffer.Length);
                    @out.Write(buffer, 0, read);
                    total += read;
                    progressBars[currentIndex].Value = total;
                }
                currentIndex++;
            }
            semaphore.Release();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBars[0] = progressBar2;
            progressBars[1] = progressBar3;
            progressBars[2] = progressBar4;
            progressBars[3] = progressBar5;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < progressBars.Length; i++)
                new Thread(Copy).Start();
        }
    }
}
