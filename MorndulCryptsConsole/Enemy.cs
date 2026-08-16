using System;
using System.Collections.Generic;
using System.Text;

namespace MorndulCryptsConsole
{
    internal class Enemy
    {
        //Fields
        public string stageOneName;
        public string stageTwoName;
        public string stageThreeName;

        public enum EnemyType { Beast, Humanoid, Undead }
        public EnemyType enemyType = EnemyType.Beast;

        public Dictionary<string, Dictionary<string, List<string>>> combatLines = new Dictionary<string, Dictionary<string, List<string>>>
        {
            {  "Barbarian", new Dictionary<string, List<string>>
                {
                    {  "IntroLines", new List<string> {"IntroLine text" } },
                    { "AttackLines", new List<string> {"Attack Line one", "Attack Line Two", "Attack Line Three"} },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> {"Defend Line one"} },
                    { "HealLines", new List<string> {"Heal Line one"} },
                    { "RunLines", new List<string> {"Run Line one"} },
                    { "DefeatLines", new List<string> {"Defeat Line one"} },
                    { "VictoryLines", new List<string> {"Victory Line one"} },

                }
            },
            {  "Cleric", new Dictionary<string, List<string>>
                {
                    {  "IntroLines", new List<string> {"IntroLine text" } },
                    { "AttackLines", new List<string> {"Attack Line one", "Attack Line Two", "Attack Line Three"} },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> {"Defend Line one"} },
                    { "HealLines", new List<string> {"Heal Line one"} },
                    { "RunLines", new List<string> {"Run Line one"} },
                    { "DefeatLines", new List<string> {"Defeat Line one"} },
                    { "VictoryLines", new List<string> {"Victory Line one"} },

                }
            },
            {  "Thief", new Dictionary<string, List<string>>
                {
                    {  "IntroLines", new List<string> {"IntroLine text" } },
                    { "AttackLines", new List<string> {"Attack Line one", "Attack Line Two", "Attack Line Three"} },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> {"Defend Line one"} },
                    { "HealLines", new List<string> {"Heal Line one"} },
                    { "RunLines", new List<string> {"Run Line one"} },
                    { "DefeatLines", new List<string> {"Defeat Line one"} },
                    { "VictoryLines", new List<string> {"Victory Line one"} },

                }
            }
        };

        public string art;
        public int health;
        public int maxHealth;
        public int attack;
        public int gold;


    }
}
