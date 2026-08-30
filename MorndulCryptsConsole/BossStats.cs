using System;
using System.Collections.Generic;
using System.Text;

namespace MorndulCryptsConsole
{
    internal class BossStats
    {

        //Fields
        public int health;
        public int maxHealth;
        public int attack;
        public int gold;
        public int xp;


        //Constructor

        public BossStats(int health, int maxHealth, int attack, int gold, int xp)
        {
            this.health = health;
            this.maxHealth = maxHealth;
            this.attack = attack;
            this.gold = gold;
            this.xp = xp;
        }
    }
}
