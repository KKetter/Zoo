using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Animal
    {
        public abstract int Legs { get; set; }
        public abstract string Food { get; set; }
        public abstract int HoursSleep { get; set; }
        public virtual bool Mate { get; set; } = true;

        public abstract bool Sleep();
        public abstract string Eat();
        public abstract bool Breathe();
    }
}
