using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._3Polymorphism
{
    class Exercise
    {
        public static void Start()
        {
            List<Vehicle> vehicle = new List<Vehicle>();
            vehicle.Add(new Boat());
            vehicle.Add(new Car());
            vehicle.Add(new Rocket());

            foreach (var item in vehicle)
            {
                item.Start();
                item.Stop();
                Console.WriteLine();
            }

            var employee = new Employee("Amy", "Jones");
            var consultant = new Consultant("John", "Smith", 8);

            Pay(employee);
            Pay(consultant);
        }

        static void Pay(Person person)
        {
            person.GetPaid();
        }
    }
}
