using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    class Snake : Reptile
    {
        public bool HasEars { get; set; } = false;

        public override void Eat()
        {
            Console.WriteLine(" Yes, I Eat, I'm a carnivore");
        }

        public override void Sleep()
        {
            Console.WriteLine(" Yes, I Sleep but with my eyes open");
        }


    }
}
