using System;
using FactoryPatternExample.Objects;

namespace FactoryPatternExample
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class FactoryPatternExample
    {
        static void Main()
        {
            Console.WriteLine("B/U/R?");
            try
            {
                var enemyShip = EnemyShipFactory.MakeEnemyShip(Console.ReadLine() ?? "");
                TestShipFunctionality(enemyShip);
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void TestShipFunctionality(EnemyShip enemyShip)
        {
            enemyShip.Display();
            enemyShip.Shoot();
            enemyShip.FollowHeroShip();
        }
    }
}