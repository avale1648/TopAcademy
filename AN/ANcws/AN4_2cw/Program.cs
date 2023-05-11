using AN4_2cw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/////////////////////////////
namespace AN4_2cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerModel customer = DataLayer.DataLayer.Customer.ByID(1);
            Console.WriteLine(customer.ToString());
            Console.ReadKey();
        }
    }
}
