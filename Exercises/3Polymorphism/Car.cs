using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._3Polymorphism
{
    class Car : Vehicle
    {
        public override void Stop()
        {
            Console.WriteLine("Parking car");
        }

        public override string ToString()
        {
            return "Car";
        }
    }
}
