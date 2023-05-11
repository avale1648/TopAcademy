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
using System.Configuration;

namespace AN3_2cw
{
    public partial class Form1 : Form
    {
        private SqlConnection connectionToCompany = null;
        private SqlDataAdapter dataAdapter = null;
        private DataSet dataSet = null;
        private string filename = string.Empty;
        string StringConnectiontoCompany = ConfigurationManager.ConnectionStrings.["CustomerAdd"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
