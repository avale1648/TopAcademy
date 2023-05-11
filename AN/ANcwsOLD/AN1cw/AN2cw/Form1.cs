using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Configuration;
//
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;

namespace AN2cw
{
    public partial class Form1 : Form
    {
        string conn_str = ConfigurationManager.ConnectionStrings["AcademyAdd"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
           
            using (SqlConnection conn = new SqlConnection(conn_str))
            {
                conn.Open();
                string sqlcommand = "select * from [Academy].[dbo].[Teachers]";
                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                SqlDataReader dataReader = cmd.ExecuteReader(); label1.Text = string.Empty;
                while (dataReader.Read())
                {
                    var field1 = dataReader[0];
                    var field2 = dataReader[2];
                    var field3 = dataReader[3];
                    label1.Text += $"{field1} {field2}  {field3}\n";
                }
                dataReader.Close();
                conn.Close();
            }
            using (SqlConnection conn = new SqlConnection(conn_str))
            {
                conn.Open();
                string sqlcommand = "[master].[dbo].[P1]";
                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter id = cmd.Parameters.Add("@id", SqlDbType.Int);
                id.Value = 1;
                SqlDataReader dataReader = cmd.ExecuteReader(); label2.Text = string.Empty;
                while (dataReader.Read())
                {
                    var field1 = dataReader[0];
                    var field2 = dataReader[2];
                    label2.Text += $"{field1} {field2}\n";
                }
                dataReader.Close();
                conn.Close();
            }
            using (SqlConnection conn = new SqlConnection(conn_str))
            {
                conn.Open();
                string sqlcommand = "[master].[dbo].[P2]";
                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //@EmploymentDate date,
                //           @Name_ nvarchar(max),
                //           @Surname nvarchar(max),
                //           @Premium money,
                //           @Salary money,
                //           @IsAssistent bit,
                //           @IsProfessor bit,
                cmd.Parameters.AddWithValue("@EmploymentDate", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@Name_", "Andrei");
                cmd.Parameters.AddWithValue("@Surname", "Mironov");
                cmd.Parameters.AddWithValue("@Premium", 100.0);
                cmd.Parameters.AddWithValue("@Salary", 500.0);
                cmd.Parameters.AddWithValue("@IsAssistant", 1);
                cmd.Parameters.AddWithValue("@IsProfessor", 1);
                cmd.Parameters.AddWithValue("@position", "teacher");
                SqlParameter teacherID = cmd.Parameters.Add("@TeacherID", SqlDbType.Int);
                teacherID.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int i = (int)teacherID.Value;
                label3.Text = $"{i}";
                conn.Close();
            }
            using (SqlConnection conn = new SqlConnection(conn_str))
            {
                conn.Open();
                string sqlcommand = "[master].[dbo].[P3]";
                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmploymentDate", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@Name_", "Andrei");
                cmd.Parameters.AddWithValue("@Surname", "Mironov");
                cmd.Parameters.AddWithValue("@Premium", 100.0);
                cmd.Parameters.AddWithValue("@Salary", 500.0);
                cmd.Parameters.AddWithValue("@IsAssistant", 1);
                cmd.Parameters.AddWithValue("@IsProfessor", 1);
                cmd.Parameters.AddWithValue("@pos", "teacher");
                SqlParameter teacherID = cmd.Parameters.Add("@TeacherID", SqlDbType.Int);
                teacherID.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                int i = (int)cmd.Parameters["@TeacherID"].Value;
                label4.Text = $"{i}";
                conn.Close();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conn_str))
            {
                conn.Open();
                string sqlcommand = "[master].[dbo].[P4]";
                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                int result = cmd.ExecuteNonQuery();
                label5.Text = $"({result} rows affected)";
            }
        }
    }
}
