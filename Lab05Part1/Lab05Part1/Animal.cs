using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
     public abstract class Animal
    {
        public virtual bool Alive { get; set; }
        public abstract string Eat();
        public abstract string Sleep();

    }
}
