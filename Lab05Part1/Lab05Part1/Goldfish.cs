using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    class Goldfish : Fish
    {
        public int CanSeeHowManyColors { get; set; }

        public override void Eat()
        {
            Console.WriteLine(" Yes, I Eat, I eat a wide variety of things");
        }

        public override void Sleep()
        {
            Console.WriteLine(" Yes, I Sleep, with my eyes open anytime of the day");
        }


    }
}
