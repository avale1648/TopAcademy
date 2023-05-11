using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Configuration;
using AN5cw.Entities;
///////////////////////////
namespace AN5cw
{
    internal class Program
    {
        private static string sConnectionToCompany = ConfigurationManager.ConnectionStrings["Company"].ConnectionString.ToString();
        static DataContext context = new DataContext(sConnectionToCompany);
        static Table<Customer> customers = context.GetTable<Customer>();
        static void Main(string[] args)
        {
            Case2();
            Console.ReadKey();
        }
        private static void Case1()
        {

            foreach (var item in customers)
                Console.Write($"{item}\n");
        }
        private static void Case2()
        {
            var query = from c in customers where c.id == 3 orderby c.FirstName select c;
            foreach (var item in query)
                Console.Write($"{item}\n");
        }
        private static void Case3()

    }
}
