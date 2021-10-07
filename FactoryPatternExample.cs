using System;
using FactoryPatternExample.Objects;

namespace FactoryPatternExample
{
    /*
    * The majority of this code is mocked or directly taken from the Derek Banas YouTube series in
    * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
    * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
    * I'm happy that you're here and here's proof that I have at least heard of this particular
    * pattern!
    *
    * Author: Nicholas Larsen
    * Date: 2021/10/07
    */
    
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class FactoryPatternExample
    {
        static void Main()
        {
            Console.WriteLine("B/U/R?");
            try
            {
                // Factory patterns are used to create classes dynamically, in this case
                // Classes are created based on user input. This line is the crux of the code
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