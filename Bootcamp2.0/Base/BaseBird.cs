﻿namespace Bootcamp2._0
{
    using System;

    public abstract class BaseBird : IAnimal
    {
        public string Name { get; set; }

        public BaseBird(string Name)
        {
            this.Name = Name;
        }

        public void DoFeed()
        {
            Console.WriteLine("Bird: " + Name + " is fedding.");
        }

        public void DoRun()
        {
            Console.WriteLine("Bird: " + Name + " is running.");
        }

        public void DoWalk()
        {
            Console.WriteLine("Bird: " + Name + " is walking.");
        }
    }
}
