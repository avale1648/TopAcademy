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
    public partial class TicketForm : Form
    {
        public DialogResult DialogueResult { get; set; }
        public TicketModel Ticket { get; set; }
        public TicketForm()
        {
            InitializeComponent();
        }
        private void TicketForm_Load(object sender, EventArgs e)
        {
            IEnumerable<EventModel> events = DataLayer.Event.All();
            foreach (var item in events)
                EventComboBox.Items.Add(item.Id.ToString() + ". " + item.Name_);
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Ticket = new TicketModel();
            try
            {
                Ticket.EventId = int.Parse(EventComboBox.SelectedItem.ToString().Split('.')[0]);
                Ticket.Price = decimal.Parse(PriceTextBox.Text);
                DialogueResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogueResult = DialogResult.Cancel;
            Close();
        }
    }
}
