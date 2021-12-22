using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._3Polymorphism
{
    class Rocket : Vehicle 
    {
        public override void Start()
        {
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            base.Start();
        }

        public override void Stop()
        {
            Console.WriteLine("Landing Rocket");
        }

        public override string ToString()
        {
            return "Rocket";
        }
    }
}
