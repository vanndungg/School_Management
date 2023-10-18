using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class Student : Person //Inheritance ;Student va Lecturer: Polymorphism
    {
        public string stdClass { get; set; }

        public Student(string id, string name, string dateOfBirth, string email, string address, string studentClass)
            : base(id, name, dateOfBirth, email, address)
        {
            stdClass = studentClass;
        }
    }
}
