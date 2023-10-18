using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class Student : Person
    {

        public string stdClass { get; set; }

        public Student(string id, string name, string dateofbirth, string email, string address, string _class)
            : base(id, name, dateofbirth, email, address)
        {
            stdClass = _class;
        }
    }
}
