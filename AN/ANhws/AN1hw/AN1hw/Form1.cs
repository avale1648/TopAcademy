using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AN1hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection AcademyConnection = new SqlConnection("Server=AVALE1648DESKTO;Database=Academy;Trusted_Connection=True");
            string select1 = "select Financing as financing, DepartmentName as departmentName, ID as id from Departments";
            string minSalary = "select min(Salary) from Teachers";
            string insert = "insert into Teachers(Name_,Surname,EmploymentDate,Salary,Premium,IsAssistant,IsProfessor,Position) values" +
                "('Andrei','Mironov','2023-01-12',1000,250,1,0,'Professor')";
            //1.
            AcademyConnection.Open();
            label1.Text = select1;
            SqlCommand command1 = new SqlCommand(select1, AcademyConnection);
            SqlDataReader reader1 = command1.ExecuteReader(); label2.Text = string.Empty;
            while (reader1.Read())
            {
                var column1 = reader1[0];
                var column2 = reader1[1];
                label2.Text += $"{column1} {column2}\n";
            }
            AcademyConnection.Close();
            //2.
            AcademyConnection.Open();
            label3.Text = minSalary;
            SqlCommand command2 = new SqlCommand(minSalary, AcademyConnection);
            object minSalaryResult = command2.ExecuteScalar();
            label4.Text = minSalaryResult.ToString();
            AcademyConnection.Close();
            //3.
            AcademyConnection.Open();
            label5.Text = insert.ToString();
            SqlCommand command3 = new SqlCommand(insert, AcademyConnection);
            int insertResult = command3.ExecuteNonQuery();
            if (insertResult > 0)
                label6.Text = "Values were sucessfully inserted in Teachers...";
            else
                label6.Text = "Values didn't were inserted in Teachers...";
            AcademyConnection.Close();
        }
    }
}
