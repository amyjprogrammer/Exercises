using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._4Interface
{
    class Employee : Person, IPayable
    {
        public Employee(string lastName, string firstName) : base(lastName, firstName)
        {

        }

        public void GetPaid()
        {
            Console.WriteLine("Paying Salary");
        }
    }
}
