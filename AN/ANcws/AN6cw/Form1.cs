using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///////////////////////////
namespace AN6cw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = MySql.CustomerResult();
        }
    }
    public class MySql
    {
        public static string CompanyConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["Company"].ConnectionString;
        public static SqlConnection CompanyConnection { get; set; } = new SqlConnection(CompanyConnectionString);

        public static string CustomerResult()
        {
            var db = new Company_DB_PV_113Entities();
            var customerResult = db.stp_CustomerByID(2).First();
            return $"{customerResult.FirstName}";
        }
    }
}
