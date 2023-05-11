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
using static AdoNetExaminationProject.DataLayers.DataLayer;

namespace AdoNetExaminationProject.Forms
{
    public partial class EventForm : System.Windows.Forms.Form
    {
        public DialogResult DialogueResult { get; set; }
        public EventModel Event { get; set; }
        public EventForm()
        {
            InitializeComponent();
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            IEnumerable<EventTypeModel> eventTypes = DataLayer.EventType.All();
            foreach (var item in eventTypes)
            {
                eventTypeComboBox.Items.Add(item.Id.ToString() + ". " + item.Name_);
            }
            IEnumerable<AgeLimitModel> ageLimitModels = DataLayer.AgeLimit.All();
            foreach (var item in ageLimitModels)
            {
                AgeLimitComboBox.Items.Add(item.Id.ToString() + ". " + item.Age.ToString() + "+");
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Event = new EventModel();
            try
            {
                Event.Name_ = nameTextBox.Text;
                Event.DateTime_ = dateTimePicker1.Value;
                Event.Country = countryTextBox.Text;
                Event.City = cityTextBox.Text;
                Event.Adress = adressTextBox.Text;
                Event.EventTypeId = int.Parse(eventTypeComboBox.SelectedItem.ToString().Split('.')[0]);
                Event.Description_ = descriptionTextBox.Text;
                Event.AgeLimitId = int.Parse(AgeLimitComboBox.SelectedItem.ToString().Split('.')[0]);
                Event.Tickets = int.Parse(ticketsTextBox.Text);
                Event.SoldTickets = int.Parse(soldTicketsTextBox.Text);
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
