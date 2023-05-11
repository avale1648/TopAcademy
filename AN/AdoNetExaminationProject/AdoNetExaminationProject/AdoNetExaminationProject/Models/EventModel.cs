using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExaminationProject.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name_ { get; set; }
        public System.DateTime DateTime_ { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public Nullable<int> EventTypeId { get; set; }
        public string Name_1 { get; set; }
        public string Description_ { get; set; }
        public Nullable<int> AgeLimitId { get; set; }
        public int Age { get; set; }
        public int Tickets { get; set; }
        public int SoldTickets { get; set; }
    }
    public class ArchiveModel: EventModel { }
}
