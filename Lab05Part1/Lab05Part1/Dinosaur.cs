using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    class Dinosaur : Reptile
    {
        public string ColorOfDinosaur { get; set; }


        public override void Eat()
        {
            Console.WriteLine(" Yes, I eat lizards, turtles, egss, sometimes other dinosaurs");
        }

        public override void Sleep()
        {
            Console.WriteLine(" Yes, I Sleep but no one knows how");
        }

        public override bool IsColdBlooded { get => base.IsColdBlooded; set => base.IsColdBlooded = value; }

       
    }
}
