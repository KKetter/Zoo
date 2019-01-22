using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Polar_Bear : Bear
    {
        public string FurAppearance { get; set; } = "White";
        public override int Legs { get; set; } = 4;

        public string swimSpeed()
        {
            Console.WriteLine("Im swimming fast because its so cold!");
            return "Im swimming fast because its so cold!";
        }
    }
}
