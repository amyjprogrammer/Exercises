using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._3Polymorphism
{
    abstract class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine($"{this.ToString()} Started");//can also use {this}
        }
        public abstract void Stop();
       
    }
}
