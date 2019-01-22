using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Bear : Mammals
    {
        public virtual bool HasClaws { get; set; } = true;

        //public override int Legs { get; set; } = 4;
        public override string Food { get; set; } = "salmon";
        public override int HoursSleep { get; set; } = 8;
    }
}
