using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AN6cw.Models;
using System.Data.Entity.Core.Objects;
namespace AN6cw.DataLayer
{
    public static class DL
    {
        public static class Customer
        {
            public static CustomerModel ByID(int id)
            {
                using(var db= new Company_DB_PV_113Entities())
                {
                    CustomerModel model = new CustomerModel();
                    var customerResult = db.stp_CustomerByID(id).First();
                    model.id = customerResult.id;
                    model.FirstName = customerResult.FirstName;
                    model.LastName = customerResult.LastName;
                    model.DateOfBirth= customerResult.DateOfBirth;
                    return model;
                }
            }
            public static IEnumerable<CustomerModel> All()
            {
                using (var db = new Company_DB_PV_113Entities())
                {
                    List<CustomerModel> customers = new List<CustomerModel>();
                    var res = db.stp_CustomerALL().ToList();
                    foreach (var customerResult in res)
                    {
                        CustomerModel model = new CustomerModel();
                        model.id = customerResult.id;
                        model.FirstName = customerResult.FirstName;
                        model.LastName = customerResult.LastName;
                        model.DateOfBirth = customerResult.DateOfBirth;
                        customers.Add(model);
                    }
                    return customers;
                }
            }
            public static int Add(CustomerModel model)
            {
                using(var db = new Company_DB_PV_113Entities())
                {
                    ObjectParameter newCustomerIdParameter = new ObjectParameter("CustomerId", 0);
                    var res = db.stp_CustomerAdd(firstName:model.FirstName, lastName:model.LastName, dateOfBirth:model.DateOfBirth, customerID:newCustomerIdParameter);
                    return (int)newCustomerIdParameter.Value;
                }
            }
        }
        
    }
}
