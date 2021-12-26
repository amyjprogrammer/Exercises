using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._7ValueType
{
    class Exercise
    {
        public static void Start()
        {
            House ourHouse = new House(12, "12 Candy Cane Lane");
            UpdateHouse(ourHouse);
            Console.WriteLine(ourHouse.ToString());
        }

        static void UpdateHouse(House updateHouse)
        {
            updateHouse.NumberOfWindows = 100;
            updateHouse.Address = "New Address";
        }
    }
}
