using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    public class Dinosaur : Reptile
    {





        public string ColorOfDinosaur { get; set; }
        public override bool IsColdBlooded { get; set; } = false;
        public override bool Alive { get; set; } = false;




        public override string Eat()
        {
            Console.WriteLine("Yes, I eat lizards, turtles, egss, sometimes other dinosaurs");
            return "Yes, I eat lizards, turtles, egss, sometimes other dinosaurs";
        }

        public override string Sleep()
        {
            Console.WriteLine("Yes, I Sleep but no one knows how");
            return "Yes, I Sleep but no one knows how";
        }

        public override void Height()
        {
            Console.WriteLine("I vary in size from as small as a chicken to as tall as a school building.");
        }


        public override string Friendly()
        {
            Console.WriteLine("I probably wasn't friendly considering my size and appetite");
            return Friendly();

        }

    }
}
