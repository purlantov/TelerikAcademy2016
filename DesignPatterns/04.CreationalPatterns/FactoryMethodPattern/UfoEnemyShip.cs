using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class UfoEnemyShip : EnemyShip
    {   
        public UfoEnemyShip():base("UFO Enemy Ship", 20.0)
        {

        }
    }
}
