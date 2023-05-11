using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
///////////////////////////////
namespace AN5cw.Entities
{
    [Table (Name = "Customers")]
    internal class Customer
    {
        [Column (IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }
        [Column]
        public string FirstName { get; set; }
        [Column]
        public string LastName { get; set; }
        [Column (CanBeNull = true)]
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"{id} {FirstName} {LastName} {DateOfBirth.ToShortDateString()}";
        }
    }
}
