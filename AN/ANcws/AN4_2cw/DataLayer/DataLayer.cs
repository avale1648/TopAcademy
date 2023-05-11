using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AN4_2cw.Models;
using System.Data.SqlClient;
using System.Data;
/*/*//*/*//*/*//*/*//*/*//*/*/
namespace AN4_2cw.DataLayer
{
    public static class DataLayer
    {
        public static string ConnectionString { get; private set; } = ConfigurationManager.ConnectionStrings["Company"].ConnectionString;
        public static class Customer
        {
            public static CustomerModel ByID(int customerID)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();



                    SqlCommand getCustomerCMD = new SqlCommand("stp_CustomerByID", conn);
                    getCustomerCMD.CommandType = CommandType.StoredProcedure;



                    getCustomerCMD.Parameters.AddWithValue("customerID", customerID);



                    SqlDataReader reader = getCustomerCMD.ExecuteReader();



                    CustomerModel customer = null;



                    while (reader.Read())
                    {
                        int ID = (int)reader[0];
                        string FirstName = reader[1].ToString();
                        string LastName = reader[2].ToString();
                        DateTime birtDate = DateTime.Parse(reader[3].ToString());



                        customer = new CustomerModel(ID, FirstName, LastName, birtDate);
                    }



                    reader.Close();



                    return customer;
                }
            }
            public static List<CustomerModel> All()
            {
                return new List<CustomerModel>();
            }
            public static bool Delete(int customerID)
            {
                return true;
            }
            public static bool Update(CustomerModel customer)
            {
                return true;
            }
        }
    }
}
