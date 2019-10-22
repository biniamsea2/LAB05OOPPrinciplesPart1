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

        public override void Height()
        {
            Console.WriteLine("I vary in size from 3.9 inches all the way to 9 meters.");
        }


        public override void Friendly()
        {
            Console.WriteLine("I'm not friendly at all, depending on my type I can kill you in one bite");
        }

    }
}
