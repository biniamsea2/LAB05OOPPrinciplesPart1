using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    public class Goldfish : Fish, IRun
    {
        public int CanSeeHowManyColors { get; set; }

        public override string Eat()
        {
            Console.WriteLine("Yes, I Eat, I eat a wide variety of things");
            return "Yes, I Eat, I eat a wide variety of things";
        }

        public override string Sleep()
        {
            Console.WriteLine("Yes, I Sleep, with my eyes open anytime of the day");
            return "Yes, I Sleep, with my eyes open anytime of the day";
        }

        public string AbleToRun()
        {
            Console.WriteLine("Technically I can't run.");
            return "Technically I can't run.";
        }



    }
}
