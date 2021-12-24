using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._3Polymorphism
{
    abstract class Person
    {
        protected Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; }  }

        public abstract void GetPaid();

    }
}
