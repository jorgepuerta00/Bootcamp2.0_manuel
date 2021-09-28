using System;
namespace Bootcamp2._0
{
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
