using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class Lecturer
    {
        public string lecId { get; set; }
        public string lecName { get; set; }
        public string lecDoB { get; set; }
        public string lecEmail { get; set; }
        public string lecAddress { get; set; }
        public string lecDept { get; set; }

        public Lecturer(string id, string name, string dob, string email, string address, string dept)
        {
            lecId = id;
            lecName = name;
            lecDoB = dob;
            lecEmail = email;
            lecAddress = address;
            lecDept = dept;
        }
    }
}
