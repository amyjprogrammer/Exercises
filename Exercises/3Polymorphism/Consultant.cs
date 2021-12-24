using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._3Polymorphism
{
    class Consultant : Employee
    {
        public Consultant(string firstName, string lastName, int hoursWorked) : base(firstName, lastName)
        {
            HoursWorked = hoursWorked;
        }

        public int HoursWorked { get; set; }

        public override void GetPaid()
        {
            Console.WriteLine($"{this.FullName} is paid for {HoursWorked} hours.");
        }
    }
}
