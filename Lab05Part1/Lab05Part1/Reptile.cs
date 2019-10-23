using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    public abstract class Reptile : Animal
    {
        public virtual bool IsColdBlooded { get; set; } = true;


        public virtual void Height()
        {
            Console.WriteLine("I'm 2 feet tall");
        }
        

        public virtual string Friendly()
        {
            Console.WriteLine("I'm friendly");
            return Friendly();

        }

    }
}
