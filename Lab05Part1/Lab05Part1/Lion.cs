using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    class Lion : Mammal
    {
        public bool HasATail { get; set; } = true;


        public override void Eat()
        {
            Console.WriteLine(" Yes, I Eat, I'm a carnivore");
        }

        public override void Sleep()
        {
            Console.WriteLine(" Yes, I Sleep a lot about 20 hours a day");
        }


    }
}
