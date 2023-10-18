using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class Person
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }
        public string Name { get; set; }
        public string DateofBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Person(string id, string name, string dateofbirth, string email, string address)
        {
            Id = id;
            Name = name;
            DateofBirth = dateofbirth;
            Email = email;
            Address = address;
        }
    }
}
