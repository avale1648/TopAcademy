using AN6cw.DataLayer;
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
using AN6cw.Models;
using AN6cw.Repositories;
///////////////////////////
namespace AN6cw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CustomerModel modelmodel = DL.Customer.ByID(1);
            label1.Text = modelmodel.FirstName;
            //CustomerModel model = new CustomerModel()
            //{
            //    FirstName = "f",
            //    DateOfBirth = DateTime.Now,
            //    LastName = "l"
            //};
            //model.id = DL.Customer.Add(model);
            IEnumerable<CustomerModel> customers = DL.Customer.All();
            foreach (var customer in customers)
                listBox1.Items.Add(customer.FirstName);
            EmployeeRepository er = new EmployeeRepository();
            Employee em = er.GetByID(2);
            label2.Text = em.FirstName;
            List<Employee> employees = er.GetAll(e => e.EmployeeID >= 1 && e.EmployeeID <= 3).ToList();
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
