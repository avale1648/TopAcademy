using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace An5hw.Entities
{
    [Table(Name = "Customers")]
    public class Customer
    {
        [Column (IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        [Column]
        public string Name_ { get; set; }
        [Column]
        public string Surname { get; set; }
        [Column]
        public DateTime Birthdate { get; set; }
        [Column (CanBeNull = true)]
        public int TicketID { get; set; }
        public override string ToString()
        {
            return $"{ID} {Name_} {Surname} {Birthdate} {TicketID}";
        }
    }
}
