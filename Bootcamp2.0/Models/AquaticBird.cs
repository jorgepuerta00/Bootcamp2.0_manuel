﻿namespace Bootcamp2._0.Models
{
    using System;
    using Bootcamp2._0.Base;
    using Bootcamp2._0.Interfaces;

    public class AquaticBird : BaseBird, IAquaticBird
    {
        public AquaticBird(string Name) : base(Name)
        {
        }

        public void DoSwim()
        {
            Console.WriteLine("Bird: " + Name + " is swiming.");
        }
    }
}
