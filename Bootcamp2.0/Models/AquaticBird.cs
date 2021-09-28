namespace Bootcamp2._0
{
    using System;

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
