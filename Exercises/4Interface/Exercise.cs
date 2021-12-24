using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._4Interface
{
    class Exercise
    {
        public static void Start()
        {
            var company = new Company("Pepsi");
            var employee = new Employee("Jane", "Doe");

            Pay(employee);
            Pay(company);

            Pay(new Company("Coca Cola"));
            Pay(new Employee("Tom", "Smith"));
        }

        static void Pay(IPayable payable)
        {
            payable.GetPaid();
        }
    }
}
