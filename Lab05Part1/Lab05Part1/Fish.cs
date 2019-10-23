using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    public abstract class Fish : Animal
    {
        public virtual bool HasGills { get; set; } = true;
        public virtual bool HasLegs { get; set; } = false;

        

    }
}
