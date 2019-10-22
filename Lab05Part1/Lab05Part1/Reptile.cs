using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
   abstract class Reptile : Animal
    {
        public virtual bool IsColdBlooded { get; set; } = true;
    }
}
