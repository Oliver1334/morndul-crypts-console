using System;
using System.Collections.Generic;
using System.Text;

namespace MorndulCryptsConsole
{
    internal class EnemyStatRanges
    {

        //Fields
        public int minHealth;
        public int maxHealth;
        public int minAttack;
        public int maxAttack;
        public int minGold;
        public int maxGold;
        public int minExp;
        public int maxExp;
        


        //Constructor

        public EnemyStatRanges(int minHealth, int maxHealth, int minAttack, int maxAttack, int minGold, int maxGold, int minExp, int maxExp)
        {
            this.minHealth = minHealth;
            this.maxHealth = maxHealth;
            this.minAttack = minAttack;
            this.maxAttack = maxAttack;
            this.minGold = minGold;
            this.maxGold = maxGold;
            this.minExp = minExp;
            this.maxExp = maxExp;

        }



    }
}
