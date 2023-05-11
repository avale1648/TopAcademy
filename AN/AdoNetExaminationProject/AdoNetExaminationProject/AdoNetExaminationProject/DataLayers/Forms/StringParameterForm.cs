using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetExaminationProject.DataLayers.Forms
{
    public enum CurrentParameter { id, city, other }
    public partial class StringParameterForm : Form
    {
        public List<string> Strings { get; set; } = new List<string>();
        public CurrentParameter CurrentParameter { get; set; } = CurrentParameter.other;
        public StringParameterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                switch (CurrentParameter)
                {
                    case CurrentParameter.id:
                        {
                            var res = DataLayer.Procedures.Second(int.Parse(textBox1.Text));
                            foreach (var item in res)
                                listBox1.Items.Add(item);
                            break;
                        }
                    case CurrentParameter.city:
                        {
                            var res = DataLayer.Procedures.Sixth(textBox1.Text);
                            foreach (var item in res)
                                listBox1.Items.Add(item);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void StringParameterForm_Load(object sender, EventArgs e)
        {
            if (CurrentParameter == CurrentParameter.other)
            {
                textBox1.Enabled = false;
                foreach(var item in Strings)
                    listBox1.Items.Add(item.ToString());
            }
        }
    }
}
