using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal abstract class Person //Abstraction
    {
        private string id; //Encapsulation
        public string Id { get { return id; } set { id = value; } }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Person(string id, string name, string dateOfBirth, string email, string address)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Email = email;
            Address = address;
        }
    }
}
