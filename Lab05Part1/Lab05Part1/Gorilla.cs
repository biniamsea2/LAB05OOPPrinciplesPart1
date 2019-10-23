using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    public class Gorilla : Mammal, IHunt
    {
        public bool BlackColor { get; set; } = true;
        public override string Size { get; set; }
        public override string TeethSize { get; set; }


        public override string Eat()
        {
            Console.WriteLine("Yes, I Eat");
            return "Yes, I Eat";
        }

        public override string Sleep()
        {
            Console.WriteLine("Yes, I Sleep");
            return "Yes, I Sleep";
        }


        public void HuntOtherAnimals()
        {
            Console.WriteLine("I mainly stick to a vegeterian diet, eating stems, bamboo shoots and fruits.");
        }


    }
}
