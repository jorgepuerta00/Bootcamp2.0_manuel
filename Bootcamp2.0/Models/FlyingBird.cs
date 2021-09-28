namespace Bootcamp2._0
{
    using System;
    using Bootcamp2._0.Base;
    using Bootcamp2._0.Interfaces;

    public class FlyingBird : BaseBird, IFlyingBird
    {
        public FlyingBird(string Name) : base(Name)
        {
        }

        public void DoFly()
        {
            Console.WriteLine("Bird: " + Name + " is flying.");
        }
    }
}
