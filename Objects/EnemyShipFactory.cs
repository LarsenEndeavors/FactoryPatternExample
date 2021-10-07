using System;

namespace FactoryPatternExample.Objects
{
    public static class EnemyShipFactory
    {
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