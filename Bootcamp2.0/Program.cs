using System;
using Bootcamp2._0.Models;

namespace Bootcamp2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            LandBird objLandBird = new LandBird("Avestrus");
            objLandBird.DoFeed();
            objLandBird.DoWalk();
            objLandBird.DoRun();

            Console.WriteLine();

            FlyingBird objFlyingBird = new FlyingBird("Loro");
            objFlyingBird.DoFeed();
            objFlyingBird.DoWalk();
            objFlyingBird.DoRun();
            objFlyingBird.DoFly();

            Console.WriteLine();

            AquaticBird objAquaticBird = new AquaticBird("Pinguino");
            objAquaticBird.DoFeed();
            objAquaticBird.DoWalk();
            objAquaticBird.DoRun();
            objAquaticBird.DoSwim();

            Console.WriteLine();

            Bird objBird = new Bird("Pato");
            objBird.DoFeed();
            objBird.DoWalk();
            objBird.DoRun();
            objBird.DoSwim();
            objBird.DoFly();
        }
    }
}
