using AdoNetExaminationProject.Models;
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
    public partial class SaleTicketForm : Form
    {
        public int EventId { get; set; }
        public int CustomerId { get; set; }
        public SaleTicketForm()
        {
            InitializeComponent();
        }
        private void SaleTicketForm_Load(object sender, EventArgs e)
        {
            IEnumerable<EventModel> events = DataLayer.Event.All();
            foreach (var item in events)
                comboBox1.Items.Add(item.Id.ToString() + ". " + item.Name_);
            IEnumerable<CustomerModel> customers = DataLayer.Customer.All();
            foreach(var item in customers)
                comboBox2.Items.Add(item.Id.ToString() + "." + item.Name_ + " " + item.Surname);
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                EventId = int.Parse(comboBox1.SelectedItem.ToString().Split('.')[0]);
                CustomerId = int.Parse((comboBox2.SelectedItem.ToString().Split('.')[0]));
                DialogResult= DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
