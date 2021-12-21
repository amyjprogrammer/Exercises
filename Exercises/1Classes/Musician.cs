using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._1Classes
{
    class Musician
    {
        public Musician(string name, Guitar guitar)
        {
            Name = name;
            Guitar = guitar;
        }
        public string Name { get; set; }
        public Guitar Guitar { get; set; }

        public void Play()
        {
            Console.WriteLine($"{Name} plays the {Guitar.Brand} guitar!");
        }
    }
}
