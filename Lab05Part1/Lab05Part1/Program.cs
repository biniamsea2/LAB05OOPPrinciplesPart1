using System;

namespace Lab05Part1
{
    public class Program
    {
        static void Main()
        {

            Dinosaur TRex = new Dinosaur();
            Console.WriteLine($"I'm TRex, a new Dinosaur am I alive? True/False: {TRex.Alive}");
            TRex.ColorOfDinosaur = "Black";
            Console.WriteLine($"ttt {TRex.ColorOfDinosaur}");







        }
    }
}
