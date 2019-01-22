using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Bald_Eagle : Flying
    {
        public override string Food { get; set; } = "Freedom";
        /// <summary>
        /// Override for the 100% accurate sound this animal makes 
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "Birds sound like freedom";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string RepresentingMyTeam()
        {
            Console.WriteLine("Go team! Fly Eagles Fly");
            return "Go team! Fly Eagles Fly";
        }
    }
}
