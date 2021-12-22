using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2Inheritance
{
    class Drone : Bee
    {
        public Drone(string name, double honeyProduced) : base(name)
        {
            HoneyProduced = honeyProduced;
        }

        public double HoneyProduced { get; set; }
    }
}
