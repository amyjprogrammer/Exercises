using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._1Classes
{
    class Exercise
    {
        public static void Start()
        {
            /*var g1 = new Guitar("Fender", 1000);
            var g2 = new Guitar("Gibson", 2000);*/

          /*  Console.WriteLine(g1.Brand);
            Console.WriteLine(g2.Brand);*/

            var m1 = new Musician("Bob Marley", new Guitar(Brand.Fender, 1000));//instead of g1
            var m2 = new Musician("Dylan", new Guitar(Brand.Gibson, 2000));

            m1.Play();
            m2.Play();

            Console.WriteLine(m1.Guitar.Price);
        }
    }
    enum Brand
    {
        Fender,
        Gibson,
        Ibanez
    }
}
