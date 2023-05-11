using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExaminationProject.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public Nullable<int> EventId { get; set; }
        public string Name_ { get; set; }
        public decimal Price { get; set; }
    }
}
