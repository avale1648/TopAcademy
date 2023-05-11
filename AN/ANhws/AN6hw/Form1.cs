using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///////////////////////////
namespace AN6hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GetEventResult()
        {
            var db = new PosterEntities();
            var eventResult = db.Procedure8().First();
            return $"{eventResult}";
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetEventResult();
        }
    }
}
