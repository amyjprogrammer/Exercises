using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._3Polymorphism
{
    class Boat : Vehicle
    {
        public override void Stop()
        {
            Console.WriteLine("Docking Boat");
        }

        public override string ToString()
        {
            return "Boat";
        }
    }
}
