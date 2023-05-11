using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace AN4hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connectionToCompany = new SqlConnection(ConfigurationManager.ConnectionStrings["Poster"].ConnectionString.ToString()))
                {
                    connectionToCompany.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from [dbo].[Customers]", connectionToCompany);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customers");
                    DataTable customers = dataSet.Tables["Customers"];
                    customers.PrimaryKey = new DataColumn[] { customers.Columns["id"] };
                    FillListBox(customers, listBox1);
                    foreach (DataRow row in customers.Rows)
                    {
                        var id = row["ID"];
                        var name = row["Name_"] + " " + row["Surname"];
                        var birthdate = row["Birthdate"];
                        var ticket = row["TicketID"];
                        listBox1.Items.Add($"{id} {name} {birthdate} {ticket}");
                    }
                    DataRow row1 = customers.NewRow();
                    row1[0] = 1111;
                    row1[1] = "Andrei";
                    row1[2] = "Mironov";
                    row1[3] = "2000-01-01";
                    row1[4] = 2;
                    customers.Rows.Add(row1);
                    adapter.Update(dataSet, "Customers");
                    customers.Clear();
                    adapter.Fill(dataSet, "Customers");
                    FillListBox(customers, listBox2);
                    foreach (DataRow row in customers.Rows)
                    {
                        var id = row["ID"];
                        var name = row["Name_"] + " " + row["Surname"];
                        var birthdate = row["Birthdate"];
                        var ticket = row["TicketID"];
                        listBox2.Items.Add($"{id} {name} {birthdate} {ticket}");
                    }
                    customers.PrimaryKey = new DataColumn[] { customers.Columns["id"] };
                    DataRow deleteRow = customers.Rows.Find(11);
                    if (deleteRow != null)
                        deleteRow.Delete();
                    adapter.Update(dataSet, "Customers");
                    customers.Clear();
                    adapter.Fill(dataSet, "Customers");
                    FillListBox(customers, listBox3);
                    foreach (DataRow row in customers.Rows)
                    {
                        var id = row["ID"];
                        var name = row["Name_"] + " " + row["Surname"];
                        var birthdate = row["Birthdate"];
                        var ticket = row["TicketID"];
                        listBox3.Items.Add($"{id} {name} {birthdate} {ticket}");
                    }
                    connectionToCompany.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillListBox(DataTable dataTable, ListBox listBox)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                var id = row["ID"];
                var name = row["Name_"] + " " + row["Surname"];
                var birthdate = row["Birthdate"];
                var ticket = row["TicketID"];
                listBox.Items.Add($"{id} {name} {birthdate} {ticket}");
            }
        }
    }
}
