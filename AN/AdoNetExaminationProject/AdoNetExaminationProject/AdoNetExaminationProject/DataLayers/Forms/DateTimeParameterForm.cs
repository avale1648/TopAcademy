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
    public enum CurrentDate { date1, date2 };
    public partial class DateTimeParameterForm : Form
    {
        public CurrentDate CurrentDate { get; set; }
        public DateTimeParameterForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                switch (CurrentDate)
                {
                    case CurrentDate.date1:
                        {
                            var res = DataLayer.Procedures.First(dateTimePicker1.Value);
                            foreach (var item in res)
                                listBox1.Items.Add(item);
                            break;
                        }
                    case CurrentDate.date2:
                        {
                            var res = DataLayer.Procedures.Ninth(dateTimePicker1.Value);
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
    }
}
