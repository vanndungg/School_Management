using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DoB { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Person(string id, string name, string dob, string email, string address)
        {
            Id = id;
            Name = name;
            DoB = dob;
            Email = email;
            Address = address;
        }
    }
}
