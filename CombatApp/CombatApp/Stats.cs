using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatApp
{
    public abstract class Stats
    {
        public int Health { get; set; }
        public int Mana { get; set; }

        public bool isDead()
        {
            if (Health > 0)
                return false;
            else
            {
                Console.WriteLine("You died!");
                return true;
            }
        }
    }
}
