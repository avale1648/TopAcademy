using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExaminationProject.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name_ { get; set; }
        public string Surname { get; set; }
        public System.DateTime Birthdate { get; set; }
        public Nullable<int> TicketId { get; set; }
        public string Name_1 { get; set; }
    }
}
