using System;

namespace FactoryPatternExample.Objects
{
    public static class EnemyShipFactory
    {
        // By encapsulating the logic to one class and method, it allows for cleaner reading
        // and better functionality when opposed to putting all this in the main code.
        public static EnemyShip MakeEnemyShip(string shipType)
        {
            var sanitizedShipTypeInput = shipType.ToUpper().ToCharArray()[0];
            if (sanitizedShipTypeInput == 'U')
            {
                return new UfoEnemyShip();
            }
            if (sanitizedShipTypeInput == 'B')
            {
                return new BigUfoEnemyShip();
            }
            if (sanitizedShipTypeInput == 'R')
            {
                return new RocketEnemyShip();
            }

            throw new NotImplementedException("User entered input for ship that does not exist yet.");
        }
    }
}