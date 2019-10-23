using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    public class Lion : Mammal, IRun
    {
        public bool HasATail { get; set; } = true;

        public override string Size { get; set; }
        public override string TeethSize { get; set; }

        public override string Eat()
        {
            Console.WriteLine("Yes, I Eat, I'm a carnivore");
            return "Yes, I Eat, I'm a carnivore";
        }

        public override string Sleep()
        {
            Console.WriteLine("Yes, I Sleep a lot about 20 hours a day");
            return "Yes, I Sleep a lot about 20 hours a day";
        }



        public void AbleToRun()
        {
            Console.WriteLine("I'm able to run really fast, on all four legs.");
        }

    }
}
