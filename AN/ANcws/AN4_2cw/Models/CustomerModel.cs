using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AN4_2cw.Models
{
    public class CustomerModel
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set;}
        public DateTime BirthDate { get; private set; }

        public CustomerModel(int id, string firstname, string lastname, DateTime birthdate)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
        }
    }
}
