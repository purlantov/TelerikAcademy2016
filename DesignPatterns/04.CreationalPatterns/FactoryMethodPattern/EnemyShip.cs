using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class EnemyShip
    {
        public string Name { get; private set; }

        public double Damage { get; private set; }

        public EnemyShip()
        {
                
        }

        public EnemyShip(string name, double damage)
        {
            this.Name = name;
            this.Damage = damage;
        }

        public void FollowHeroShip()
        {
            Console.WriteLine(Name + " is following the hero");
        }

        public void DisplayEnemyShip()
        {
            Console.WriteLine(Name + " is on the screen");
        }

        public void EnemyShipShoots()
        {
            Console.WriteLine(Name + " attacks and does " + Damage + " damage to hero");
        }
    }

}
