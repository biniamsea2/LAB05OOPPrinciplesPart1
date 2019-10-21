using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Part1
{
    class Fish : Animal
    {
        public bool HasGills { get; set; } = true;
        public bool HasLegs { get; set; } = false;
    }
}
