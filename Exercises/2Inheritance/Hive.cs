using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2Inheritance
{
    class Hive
    {
        public Hive(Queen queen)
        {
            QueenBee = queen;
        }

        public Queen QueenBee { get; set; }
        public List<Drone> Drones { get; set; } = new List<Drone>();
    }
}
