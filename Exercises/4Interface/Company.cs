using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._4Interface
{
    class Company : IPayable
    {
        public string Name { get; set; }

        public Company(string name)
        {
            Name = name;
        }
        public void GetPaid()
        {
            Console.WriteLine("Paying invoice");
        }
    }
}
