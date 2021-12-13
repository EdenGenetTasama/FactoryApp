using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryApp.Models
{
    public class Employee
    {
        public Employee(string name, string lastName, int yearOfBirth, int PhoneNumber)
        {
            this.Name = name;
            this.LastName = lastName;
            this.YearOfBirth = yearOfBirth;
            this.PhoneNumber = PhoneNumber;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public int PhoneNumber { get; set; }

    }
}