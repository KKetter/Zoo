using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Non_Flying : Birds
    {
        public virtual bool CanFly { get; set; } = false;

        public override int HoursSleep { get; set; } = 6;
    }
}
