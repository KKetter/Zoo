﻿using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Bald_Eagle : Flying, IAmMascot
    {
        public override string Food { get; set; } = "Freedom";
        /// <summary>
        /// Override for the 100% accurate sound this animal makes 
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "Eagles sound like freedom";
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
