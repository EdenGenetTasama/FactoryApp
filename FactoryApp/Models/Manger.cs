using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryApp.Models
{
    public class Manger
    {

        public Manger(string name , string lastName , int dep)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Dep = dep;
        }

        public Manger() { }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Dep { get; set; }



    }
}