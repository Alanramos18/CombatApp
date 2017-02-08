using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Health = 1;
            hero.isDead();
            Console.WriteLine("Hero survived!");

            Monster monster = new Monster();
            monster.Health = 0;
            if(!monster.isDead())
                Console.WriteLine("Monster survived as well");
        }
    }
}
