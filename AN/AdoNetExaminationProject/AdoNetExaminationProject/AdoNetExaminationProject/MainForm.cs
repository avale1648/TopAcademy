using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetExaminationProject.DataLayers;
using AdoNetExaminationProject.DataLayers.Forms;

namespace AdoNetExaminationProject
{
    public partial class MainForm : Form
    {
        private CurrentTable currentTable;
        public MainForm()
        {
            InitializeComponent();
        }
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                currentTable = CurrentTable.Customers;
                DataLayer.ListView.Fill(currentTable, listView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                currentTable = CurrentTable.Events;
                DataLayer.ListView.Fill(currentTable, listView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                currentTable = CurrentTable.Tickets;
                DataLayer.ListView.Fill(currentTable, listView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                currentTable = CurrentTable.Archive;
                DataLayer.ListView.Fill(currentTable, listView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                currentTable = CurrentTable.Customers; 
                DataLayer.ListView.Fill(currentTable, listView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataLayer.Form.Add(currentTable);
            DataLayer.ListView.Fill(currentTable, listView1);
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataLayer.Form.Update(int.Parse(listView1.SelectedItems[0].SubItems[0].Text),currentTable);
            DataLayer.ListView.Fill(currentTable, listView1);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataLayer.Form.Delete(int.Parse(listView1.SelectedItems[0].SubItems[0].Text), currentTable);
            DataLayer.ListView.Fill(currentTable, listView1);
        }
        private void процедура1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeParameterForm form = new DateTimeParameterForm();
            form.CurrentDate = CurrentDate.date1;
            form.ShowDialog();
        }
        private void процедура2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringParameterForm form = new StringParameterForm();
            form.CurrentParameter = CurrentParameter.id;
            form.ShowDialog();
        }
        private void процедура3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringParameterForm form = new StringParameterForm();
            form.CurrentParameter = CurrentParameter.other;
            var res = DataLayer.Procedures.Third();
            foreach(var item in res)
                form.Strings.Add(item.ToString());
            form.ShowDialog();
        }
        private void процедура4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringParameterForm form = new StringParameterForm();
            form.CurrentParameter = CurrentParameter.other;
            var res = DataLayer.Procedures.Fourth();
            foreach (var item in res)
                form.Strings.Add(item.ToString());
            form.ShowDialog();
        }
        private void процедура5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringParameterForm form = new StringParameterForm();
            form.CurrentParameter = CurrentParameter.city;
            form.ShowDialog();
        }
        private void процедура6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringParameterForm form = new StringParameterForm();
            form.CurrentParameter = CurrentParameter.other;
            var res = DataLayer.Procedures.Eigth();
            foreach (var item in res)
                form.Strings.Add(item.ToString());
            form.ShowDialog();
        }
        private void процедура8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTimeParameterForm form = new DateTimeParameterForm();
            form.CurrentDate = CurrentDate.date2;
            form.ShowDialog();
        }
        private void процедура9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringParameterForm form = new StringParameterForm();
            form.CurrentParameter = CurrentParameter.other;
            var res = DataLayer.Procedures.Tenth();
            foreach (var item in res)
                form.Strings.Add(item.ToString());
            form.ShowDialog();
        }
        private void процедура10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringParameterForm form = new StringParameterForm();
            form.CurrentParameter = CurrentParameter.other;
            var res = DataLayer.Procedures.Eleventh();
            foreach (var item in res)
                form.Strings.Add(item.ToString());
            form.ShowDialog();
        }
        private void самыйАктивныйКлиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringParameterForm form = new StringParameterForm();
            form.CurrentParameter = CurrentParameter.other;
            var res = DataLayer.Views.First();
            foreach (var item in res)
                form.Strings.Add(item.ToString());
            form.ShowDialog();
        }
        private void BuyTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataLayer.Form.SaleTicket();
        }
    }
}
