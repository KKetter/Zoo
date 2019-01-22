using System;
using Zoo.Classes;


namespace Zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Zoo!");
            MakePolarBear();
            MakeBlackBear();
            MakeEmperorPenguin();
            MakeBaldEagle();
            MakeMountainLion();
            Console.ReadLine();
        }
        /// <summary>
        /// Make an instance of Polar(Bear)
        /// </summary>
        public static void MakePolarBear()
        {
            Polar_Bear polarBear = new Polar_Bear();
            Console.WriteLine("-Polar Bear-");
            Console.WriteLine($"Polar bears have {polarBear.Legs} legs.");
            Console.WriteLine($"Polar bears have {polarBear.FurAppearance} fur.");
            polarBear.swimSpeed();
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
        }
        /// <summary>
        /// Make an instance of Black(Bear)
        /// </summary>
        public static void MakeBlackBear()
        {
            Black blackBear = new Black();
            Console.WriteLine("-Black Bear-");
            Console.WriteLine($"Black bears have {blackBear.Legs} legs.");
            Console.WriteLine($"Black bears have {blackBear.FurAppearance} fur.");
            blackBear.swimSpeed();
            blackBear.RepresentingMyTeam();
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
        }
        /// <summary>
        /// Make an instance of Mountain Lion
        /// </summary>
        public static void MakeMountainLion()
        {
            Mountain_Lion mountainLion = new Mountain_Lion();
            Console.WriteLine("-Mountain Lion-");
            Console.WriteLine($"Mountain Lion have {mountainLion.Legs} legs.");
            Console.WriteLine($"Mountain Lions eat {mountainLion.Food}.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~");

        }
        /// <summary>
        /// Make an instance of Bald Eagle
        /// </summary>
        public static void MakeBaldEagle()
        {
            Bald_Eagle baldEagle = new Bald_Eagle();
            Console.WriteLine("-Bald Eagle-");
            Console.WriteLine($"Bald Eagles have {baldEagle.Legs} legs.");
            Console.WriteLine($"Eagles ONLY eat {baldEagle.Food}.");
            baldEagle.RepresentingMyTeam();
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
        }
        /// <summary>
        /// Make an instance of Emperor Penguin
        /// </summary>
        public static void MakeEmperorPenguin()
        {
            Emperor_Penguin emperorPenguin = new Emperor_Penguin();
            Console.WriteLine("-Emperor Penguin-");
            Console.WriteLine($"Emperor Penguins have {emperorPenguin.Legs} legs.");
            Console.WriteLine($"Emperor Penguins eat {emperorPenguin.Food}.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
        }
    }

}