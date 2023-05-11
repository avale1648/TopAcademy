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
using System.Reflection.Emit;

namespace AN3cw
{
    public partial class Form1 : Form
    {
        private string conn_str = ConfigurationManager.ConnectionStrings["AcademyAdd"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }
        private int P3()
        {
            using (SqlConnection conn = new SqlConnection(conn_str))
            {
                conn.Close();
                conn.Open();
                string sqlcommand = "[master].[dbo].[P3]";
                SqlCommand cmd = new SqlCommand(sqlcommand, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(cmd);
                cmd.Parameters[0].Value = DBNull.Value;
                cmd.Parameters[1].Value = DateTime.Now.ToShortDateString();
                cmd.Parameters[2].Value = "Andrei";
                cmd.Parameters[3].Value = "Mironov";
                cmd.Parameters[4].Value = 100.0;
                cmd.Parameters[5].Value = 500.0;
                cmd.Parameters[6].Value = 1;
                cmd.Parameters[7].Value = 1;
                cmd.Parameters[8].Value = "Teacher";
                cmd.ExecuteNonQuery();
                return (int)cmd.Parameters[0].Value;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = P3().ToString();
        }
    }
}
