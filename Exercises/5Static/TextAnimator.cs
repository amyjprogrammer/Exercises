using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercises._5Static
{
    static class TextAnimator
    {
        static public void Animate(string text, int delay)
        {
            foreach (var character in text)
            {
                Console.Write(character);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}
