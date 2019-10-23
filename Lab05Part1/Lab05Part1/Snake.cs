using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    public class Snake : Reptile, IRun, IHunt
    {
        public bool HasEars { get; set; } = false;
        

        public override string Eat()
        {
            Console.WriteLine("Yes, I Eat, I'm a carnivore");
            return "Yes, I Eat, I'm a carnivore";
        }

        public override string Sleep()
        {
            Console.WriteLine("Yes, I Sleep but with my eyes open");
            return "Yes, I Sleep but with my eyes open";
        }

        public override void Height()
        {
            Console.WriteLine("I vary in size from 3.9 inches all the way to 9 meters.");
        }


        public override string Friendly()
        {
            Console.WriteLine("I'm not friendly at all, depending on my type I can kill you in one bite");
            return "I'm not friendly at all, depending on my type I can kill you in one bite";
        }


        public string HuntOtherAnimals()
        {
            Console.WriteLine("Duh, I eat other animals I'm a snake.");
            return "Duh, I eat other animals I'm a snake.";
        }


        public string AbleToRun()
        {
            Console.WriteLine("Is this a joke, I'm a snake of course I can't run.");
            return "Is this a joke, I'm a snake of course I can't run.";
        }


    }
}
