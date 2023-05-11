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
using System.Linq.Expressions;
////////////////////////////
namespace AN4cw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try 
            {
                using (SqlConnection connectionToCompany = new SqlConnection(ConfigurationManager.ConnectionStrings["Company"].ConnectionString.ToString()))
                {
                    //1
                    connectionToCompany.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from [dbo].[Customers]", connectionToCompany);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Customers");
                    DataTable customers = dataSet.Tables["Customers"];
                    customers.PrimaryKey = new DataColumn[] { customers.Columns["id"] };
                    foreach (DataRow row in customers.Rows)
                    {
                        var ID = row["id"];
                        var Name = row["FirstName"] + " " + row["LastName"];
                        var BD = row["DateOfBirth"];
                        label1.Text += $"{ID} {Name} {BD}\n";
                    }
                    DataRow row1 = customers.NewRow();
                    row1[0] = 1111;
                    row1[1] = "Andrei";
                    row1[2] = "Mironov";
                    row1[3] = "2000-01-01";
                    customers.Rows.Add(row1);
                    adapter.Update(dataSet, "Customers");
                    customers.Clear();
                    adapter.Fill(dataSet, "Customers");
                    foreach (DataRow row in customers.Rows)
                    {
                        var ID = row["id"];
                        var Name = row["FirstName"] + " " + row["LastName"];
                        var BD = row["DateOfBirth"];
                        label2.Text += $"{ID} {Name} {BD}\n";
                    }
                    //2
                    customers.PrimaryKey = new DataColumn[] { customers.Columns["id"] };
                    DataRow deleteRow = customers.Rows.Find(18);
                    if (deleteRow != null)
                        deleteRow.Delete();
                    adapter.Update(dataSet, "Customers");
                    customers.Clear();
                    adapter.Fill(dataSet, "Customers");
                    foreach (DataRow row in customers.Rows)
                    {
                        var ID = row["id"];
                        var Name = row["FirstName"] + " " + row["LastName"];
                        var BD = row["DateOfBirth"];
                        label3.Text += $"{ID} {Name} {BD}\n";
                    }
                    adapter.InsertCommand = new SqlCommand("stp_CustomerAdd", connectionToCompany);
                    adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adapter.InsertCommand.Parameters.AddWithValue("@FirstName", "Ndrei");
                    adapter.InsertCommand.Parameters.AddWithValue("@LastName", "Ironov");
                    adapter.InsertCommand.Parameters.AddWithValue("@DateOfBirth", "2020-01-01");
                    adapter.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    adapter.InsertCommand.ExecuteNonQuery();
                    customers.Clear();
                    adapter.Fill(dataSet, "Customers");
                    label4.Text = string.Empty;
                    foreach (DataRow row in customers.Rows)
                    {
                        var ID = row["id"];
                        var Name = row["FirstName"] + " " + row["LastName"];
                        var BD = row["DateOfBirth"];
                        label4.Text += $"{ID} {Name} {BD}\n";
                    }
                    connectionToCompany.Close();
                }
                
            }
            catch(Exception ex)
            {
                label5.Text = ex.Message;
            }
        }
    }
}
