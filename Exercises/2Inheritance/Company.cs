using Exercises._1Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2Inheritance
{
    class Company
    {
        public Company(string name)
        {
            Name = name;
            Employees = new List<Employee>();
            Consultants = new List<Consultant>();
        }

        public string Name { get; set; }

        //can also use = new List<Employee>(); at the end
        public List<Employee> Employees { get; set; }
        public List<Consultant> Consultants { get; set; }
    }
}
