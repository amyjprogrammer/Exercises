using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._3Polymorphism
{
    class Employee : Person
    {
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void GetPaid()
        {
            Console.WriteLine($"{this.FullName} is paid a fixed salary");
        }
    }
}
