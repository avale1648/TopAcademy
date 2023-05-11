using AdoNetExaminationProject.DataLayers;
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

namespace AdoNetExaminationProject.Forms
{
    public partial class CustomerForm : Form
    {
        public DialogResult DialogueResult { get; set; }
        public CustomerModel Customer { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            IEnumerable<TicketModel> tickets = DataLayer.Ticket.All();
            foreach (var item in tickets)
                ticketComboBox.Items.Add(item.Id.ToString() + ". " + item.Name_);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer = new CustomerModel();
            try
            {
                Customer.Name_ = nameTextBox.Text;
                Customer.Surname = surnameTextBox.Text;
                Customer.Birthdate = dateTimePicker1.Value;
                Customer.TicketId = int.Parse(ticketComboBox.SelectedItem.ToString().Split('.')[0]);
                DialogueResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogueResult = DialogResult.Cancel;
            Close();
        }
    }
}
