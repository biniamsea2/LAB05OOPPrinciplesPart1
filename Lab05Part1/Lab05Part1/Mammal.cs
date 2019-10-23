using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    public abstract class Mammal : Animal
    {
        public virtual bool HasFur { get; set; } = true;
        public abstract string Size { get; set; } 
        public abstract string TeethSize { get; set; }



      



    }



}
