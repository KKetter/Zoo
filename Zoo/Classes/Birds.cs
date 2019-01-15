using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Birds : Animal
    {
        public virtual bool Feathers { get; set; } = true;
        public virtual void LayEggs()
        {
            Console.WriteLine("This bird lays 2 egg(s)");
        }

        public virtual string Sound()
        {
            return "Birds chirp";
        }
        
        public override bool Sleep()
        {
            return true;
        }
        public override string Eat()
        {
            return "Munch Munch";
        }
        public override bool Breathe()
        {
            return true;
        }

    }
}
