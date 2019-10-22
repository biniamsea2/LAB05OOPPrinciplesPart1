using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
     abstract class Animal
    {
        public virtual bool Alive { get; set; }
        public abstract void Eat();
        public abstract void Sleep();

    }
}
