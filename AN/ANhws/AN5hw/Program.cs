using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using An5hw.Entities;

namespace AN5hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string posterConnectionString = ConfigurationManager.ConnectionStrings["Poster"].ConnectionString;
            DataContext dc = new DataContext(posterConnectionString);
            Table<Customer> customers = dc.GetTable<Customer>();
            Console.WriteLine("All Customers\n");
            foreach (Customer customer in customers)
                Console.WriteLine(customer);
            Console.WriteLine("\n1. Find customer in Id's diapasone.\nEnter first value:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            int b = int.Parse(Console.ReadLine());
            var query = from c in customers where c.ID >= a && c.ID <= b select c;
            foreach (Customer customer in query)
                Console.WriteLine(customer);
            Console.WriteLine("\n2. Find customers by first letter in their names.\nEnter first letter:");
            string s = Console.ReadLine();
            query = from c in customers where c.Name_.StartsWith(s) select c;
            foreach (Customer customer in query)
                Console.WriteLine(customer);
            Console.WriteLine("\n3. Find customer by id and edit their name.\nEnter id:");
            a = int.Parse(Console.ReadLine());
            Customer edit = customers.Where(c => c.ID == a).FirstOrDefault();
            Console.WriteLine("Enter new name:");
            s = Console.ReadLine();
            edit.Name_ = s;
            dc.SubmitChanges();
            foreach (Customer customer in customers)
                Console.WriteLine(customer);
            Console.WriteLine("\n4. Add new customer.\nEnter name:");
            s = Console.ReadLine();
            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter year of birth:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of birth:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day of birth:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ticket's id:");
            int ticketId = int.Parse(Console.ReadLine());
            Customer newCustomer = new Customer
            {
                Name_ = s,
                Surname = surname,
                Birthdate = new DateTime(year, month, day),
                TicketID = ticketId
            };
            customers.InsertOnSubmit(newCustomer);
            dc.SubmitChanges();
            foreach (Customer customer in customers)
                Console.WriteLine(customer);
            Console.WriteLine("\n5. Delete customer by id.\nEnter id:");
            a = int.Parse(Console.ReadLine());
            customers.DeleteOnSubmit(customers.Where(c => c.ID == a).First());
            dc.SubmitChanges();
            foreach (Customer customer in customers)
                Console.WriteLine(customer);
            Console.ReadKey();
        }
    }
}
