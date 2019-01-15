using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Flying : Birds
    {
        public virtual bool CanFly { get; set; } = true;

        public override int HoursSleep { get; set; } = 2;
        public override int Legs { get; set; } = 2;
    }
}
