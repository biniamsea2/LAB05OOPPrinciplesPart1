using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    class Gorilla : Mammal
    {
        public bool BlackColor { get; set; } = true;


        public override string Size { get; set; }
        public override string TeethSize { get; set; }


        public override void Eat()
        {
            Console.WriteLine(" Yes, I Eat");
        }

        public override void Sleep()
        {
            Console.WriteLine(" Yes, I Sleep");
        }


    }
}
