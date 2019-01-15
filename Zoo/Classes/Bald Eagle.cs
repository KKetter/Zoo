using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Bald_Eagle : Flying
    {
        public override string Food { get; set; } = "Freedom";
        public override string Sound()
        {
            return "Birds sound like freedom";
        }
    }
}
