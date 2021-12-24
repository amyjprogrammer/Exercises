using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._4Interface
{
    class Person
    {
        protected Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
