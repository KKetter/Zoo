using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Black : Bear, ISwim, IAmMascot
    {
        public string FurAppearance { get; set; } = "Black";
        public override int Legs { get; set; } = 4;

        public string swimSpeed()
        {
            Console.WriteLine("Im swimming fast to get the fish!");
            return "Im swimming fast to get the fish!";
        }

        public string RepresentingMyTeam()
        {
            Console.WriteLine("Go team? Bear Down!");
            return "Go team? Bear Down!";
        }
    }
}
