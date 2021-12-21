using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._1Classes
{
    class Guitar
    {
        public Guitar(Brand brand, double price)
        {
            Brand = brand;
            Price = price;
        }
        public Brand Brand { get; set; }

        public double Price { get; set; }
    }
}
