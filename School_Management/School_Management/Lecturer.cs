using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class Lecturer : Person
    {
        public string lecDept { get; set; }

        public Lecturer(string id, string name, string dob, string email, string address, string dept)
            : base(id, name, dob, email, address)
        {
            lecDept = dept;
        }
    }
}
