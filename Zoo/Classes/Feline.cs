using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Feline : Mammals
    {
        public virtual bool LikesBoxes { get; set; } = true;

        public override int Legs { get; set; } = 4;
        public override string Food { get; set; } = "deer";
        public override int HoursSleep { get; set; } = 12;
    }
}
