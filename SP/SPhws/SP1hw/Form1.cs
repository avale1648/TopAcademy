using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
///////////////////////////
namespace SP1hw
{
    public partial class Form1 : Form
    {
        private int timeLeft = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void task1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!", "Greetings", MessageBoxButtons.OK);
            MessageBox.Show("I'm Andrei Mironov", "Name", MessageBoxButtons.OK);
            MessageBox.Show("I'm 22 years old", "Age", MessageBoxButtons.OK);
            MessageBox.Show("I'm the Shark of Cyber-sport and IT Business", "Field of Activity", MessageBoxButtons.OK);
        }
        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeLeft = 5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                SystemSounds.Beep.Play();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void textBoxTask3Interval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = Int32.Parse(textBoxTask3Interval.Text) * 1000;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
