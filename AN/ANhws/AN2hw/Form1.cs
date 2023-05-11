using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml.Linq;

namespace AN2hw
{
    public partial class Form1 : Form
    {
        string stringPosterConnection = ConfigurationManager.ConnectionStrings["PosterAdd"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            SelectAllCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection posterConnection = new SqlConnection(stringPosterConnection))
            {
                try
                {
                    posterConnection.Open();
                    string stringSqlCommand = "[master].[dbo].[SelectCustomersByTicketID]";
                    SqlCommand sqlCommand = new SqlCommand(stringSqlCommand, posterConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter id = sqlCommand.Parameters.Add("@ticketID", SqlDbType.Int);
                    id.Value = Int32.Parse(textBoxTicketID.Text);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(); label1.Text = string.Empty;
                    while (sqlDataReader.Read())
                    {
                        var column1 = sqlDataReader[0];
                        var column2 = sqlDataReader[1];
                        var column3 = sqlDataReader[2];
                        var column4 = sqlDataReader[3];
                        var column5 = sqlDataReader[4];
                        label1.Text += $"{column1} {column2} {column3} {column4} {column5}";
                    }
                    sqlDataReader.Close();
                    posterConnection.Close();
                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection posterConnection = new SqlConnection(stringPosterConnection))
                {
                    posterConnection.Open();
                    string stringSqlCommand = "[master].[dbo].[CustomersInsertOutput]";
                    SqlCommand sqlCommand = new SqlCommand(stringSqlCommand, posterConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@name", textBoxName1.Text);
                    sqlCommand.Parameters.AddWithValue("@surname", textBoxSurname1.Text);
                    sqlCommand.Parameters.AddWithValue("@birthdate", dateTimePicker1.Value.ToShortDateString());
                    sqlCommand.Parameters.AddWithValue("@ticketID", Int32.Parse(textBoxTicketID1.Text));
                    SqlParameter insertedID = sqlCommand.Parameters.Add("@insertedID", SqlDbType.Int);
                    insertedID.Direction = ParameterDirection.Output;
                    sqlCommand.ExecuteNonQuery();
                    int i = (int)insertedID.Value;
                    label2.Text = $"{i}";
                    posterConnection.Close();
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection posterConnection = new SqlConnection(stringPosterConnection))
                {
                    posterConnection.Open();
                    string stringSqlCommand = "[master].[dbo].[CustomersInsertReturn]";
                    SqlCommand sqlCommand = new SqlCommand(stringSqlCommand, posterConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@name", textBoxName2.Text);
                    sqlCommand.Parameters.AddWithValue("@surname", textBoxSurname2.Text);
                    sqlCommand.Parameters.AddWithValue("@birthdate", dateTimePicker2.Value.ToShortDateString());
                    sqlCommand.Parameters.AddWithValue("@ticketID", Int32.Parse(textBoxTicketID2.Text));
                    SqlParameter insertedID = sqlCommand.Parameters.Add("@insertedID", SqlDbType.Int);
                    insertedID.Direction = ParameterDirection.ReturnValue;
                    sqlCommand.ExecuteNonQuery();
                    int i = (int)insertedID.Value;
                    label3.Text = $"{i}";
                    posterConnection.Close();
                }
            }
            catch (Exception ex)
            {
                label3.Text = ex.Message;
            }
        }
        private void SelectAllCustomers()
        {
            using (SqlConnection posterConnection = new SqlConnection(stringPosterConnection))
            {
                try
                {
                    posterConnection.Open();
                    string stringSqlCommand = "select * from [Poster].[dbo].[Customers]";
                    SqlCommand sqlCommand = new SqlCommand(stringSqlCommand, posterConnection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(); listBox1.Text = string.Empty;
                    while (sqlDataReader.Read())
                    {
                        var column1 = sqlDataReader[0];
                        var column2 = sqlDataReader[1];
                        var column3 = sqlDataReader[2];
                        var column4 = sqlDataReader[3];
                        var column5 = sqlDataReader[4];
                        listBox1.Items.Add($"{column1} {column2} {column3} {column4} {column5}");
                    }
                    sqlDataReader.Close();
                    posterConnection.Close();
                }
                catch (Exception ex)
                {
                    listBox1.Text = ex.Message;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SelectAllCustomers();
        }
    }
}
