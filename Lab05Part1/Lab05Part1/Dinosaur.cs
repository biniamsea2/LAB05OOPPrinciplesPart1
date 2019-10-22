using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    class Dinosaur : Reptile
    {
        public string ColorOfDinosaur { get; set; }
        public override bool IsColdBlooded { get; set; } = false;

        public override bool Alive { get; set; } = false;

        public override void Eat()
        {
            Console.WriteLine(" Yes, I eat lizards, turtles, egss, sometimes other dinosaurs");
        }

        public override void Sleep()
        {
            Console.WriteLine(" Yes, I Sleep but no one knows how");
        }

        public override void Height()
        {
            Console.WriteLine("I vary in size from as small as a chicken to as tall as a school building.");
        }


        public override void Friendly()
        {
            Console.WriteLine("I probably wasn't friendly considering my size and appetite");
        }

    }
}
