using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryApp.Models
{
    public class Supervisor
    {
        public Supervisor(string name, string lastName, int yearOfBirth, int timeOfWork)
        {
            this.Name = name;
            this.LastName = lastName;
            this.YearOfBirth = yearOfBirth;
            this.TimeOfWork = timeOfWork;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public int TimeOfWork { get; set; }
    }
}