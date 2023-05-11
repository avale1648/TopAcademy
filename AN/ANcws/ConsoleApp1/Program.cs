using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/////////////////////////////
namespace AN8cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DbFirst - 
            using (var db = new Model1Container())
            {
                Console.WriteLine("Name:");
                var name = Console.ReadLine();
                var student = new Teacher() { Name_ = name};
                db.TeacherSet.Add(student);
                db.SaveChanges();
            }
        }
    }
}
