using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip() : base("Rocket Enemy Ship",10.0)
        {
        }
    }
}
