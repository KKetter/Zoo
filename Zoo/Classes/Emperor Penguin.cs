using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Emperor_Penguin : Non_Flying
    {
        public override string Food { get; set; } = "cute fish";
        public override int Legs { get; set; } = 2;
    }
}
