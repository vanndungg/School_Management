using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class Student
    {
        public string stdId { get; set; }
        public string stdName { get; set; }
        public string stdDoB { get; set; }
        public string stdEmail { get; set; }
        public string stdAddress { get; set; }
        public string stdClass { get; set; }

        public Student(string id, string name, string dob, string email, string address, string _class)
        {
            stdId = id;
            stdName = name;
            stdDoB = dob;
            stdEmail = email;
            stdAddress = address;
            stdClass = _class;
        }
    }
}
