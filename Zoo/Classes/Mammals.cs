using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Mammals : Animal
    {
        //concrete property
        public bool Cuddly { get; set; }

        public override bool Sleep()
        {
            return true;
        }
        public override string Eat()
        {
            return "Nom Nom";
        }
        public override bool Breathe()
        {
            return true;
        }

    }
}
