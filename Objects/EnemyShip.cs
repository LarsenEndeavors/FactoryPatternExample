using System;

namespace FactoryPatternExample.Objects
{
    public abstract class EnemyShip
    {
        protected string Name { get; set; }
        protected double AmountOfDamage { get; set; }

        public void FollowHeroShip()
        {
            Console.WriteLine(Name + " is following the hero.");
        }

        public void Display()
        {
            Console.WriteLine(Name + " is on the screen.");
        }

        public void Shoot()
        {
            Console.WriteLine(Name + " shoots the hero ship for " + AmountOfDamage + " damage!");
        }
        
    }
}