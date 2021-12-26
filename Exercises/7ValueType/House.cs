using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._7ValueType
{
    //if you change to struct House- it changes to a value instead of a reference type
    class House 
    {
        public House(int numberOfWindows, string address)
        {
            NumberOfWindows = numberOfWindows;
            Address = address;
        }

        public int NumberOfWindows { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Windows: {NumberOfWindows} Address: {Address}";
        }

    }
    
}
