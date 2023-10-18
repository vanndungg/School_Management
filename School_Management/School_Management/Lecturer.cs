using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class Lecturer : Person
    {
        public string Department { get; set; }

        public Lecturer(string id, string name, string dateOfBirth, string email, string address, string department)
            : base(id, name, dateOfBirth, email, address)
        {
            Department = department;
        }
    }
}
