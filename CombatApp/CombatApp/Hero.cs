using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatApp
{
    class Hero : Stats
    {
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }

        public Hero()
        {
            Health = 100;
            Mana = 50;
            Experience = 0;
            Gold = 0;
            Level = 1;
        }

        private void checkExp()
        {
            int nextExpTarget = (Level * 100) + (5 * Level);
            if (Experience >= nextExpTarget)
                levelUp();
        }

        public void levelUp()
        {
            Health += 18;
            Mana += 8;
            Level++;
            Experience = 0;
        }
    }
}
