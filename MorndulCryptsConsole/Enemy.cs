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

        public Dictionary<string, Dictionary<string, List<string>>> combatLines; 

        public string art;
        public ConsoleColor colour;
        public int health;
        public int maxHealth;
        public int attack;
        public int gold;









        public static Enemy MakePorkMan(int health, int maxHealth, int attack, int gold)
        {
            Enemy porkman = new Enemy();
            porkman.stageOneName = "PorkMan Grunt";
            porkman.stageTwoName = "Horrendous PorkMan";
            porkman.stageThreeName = "Horrendous PorkMan";
            porkman.enemyType = Enemy.EnemyType.Humanoid;

            porkman.combatLines = new Dictionary<string, Dictionary<string, List<string>>>
        {
            {  "Barbarian", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> {"Porkman Barbarian IntroLine text" } },
                    { "AttackLines", new List<string> { "Porkman Barbarian Attack Line one", "Porkman Barbarian Attack Line Two", "Porkman Barbarian Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "Porkman Barbarian Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "Porkman Barbarian Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "Porkman Barbarian Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "Porkman Barbarian Run Success Line one" } },
                    { "RunFailLines", new List<string> { "Porkman Barbarian Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "Porkman Barbarian Defeat Line one" } },
                    { "VictoryLines", new List<string> { "Porkman Barbarian Victory Line one" } },

                }
            },
            {  "Cleric", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "Porkman Cleric IntroLine text" } },
                    { "AttackLines", new List<string> { "Porkman Cleric Attack Line one", "Porkman Cleric Attack Line Two", "Porkman Cleric Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "Porkman Cleric Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "Porkman Cleric Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "Porkman Cleric Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "Porkman Cleric Run Success Line one" } },
                    { "RunFailLines", new List<string> { "Porkman Cleric Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "Porkman Cleric Defeat Line one" } },
                    { "VictoryLines", new List<string> { "Porkman Cleric Victory Line one" } },

                }
            },
            {  "Thief", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "Porkman Thief IntroLine text" } },
                    { "AttackLines", new List<string> { "Porkman Thief Attack Line one", "Porkman Thief Attack Line Two", "Porkman Thief Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "Porkman Thief Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "Porkman Thief Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "Porkman Thief Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "Porkman Thief Run Success Line one" } },
                    { "RunFailLines", new List<string> { "Porkman Thief Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "Porkman Thief Defeat Line one" } },
                    { "VictoryLines", new List<string> { "Porkman Thief Victory Line one" } },

                }
            }
        };

            porkman.art = ArtAssets.PorkMan;
            porkman.colour = ConsoleColor.Magenta;
            porkman.health = health;
            porkman.maxHealth = maxHealth;
            porkman.attack = attack;
            porkman.gold = gold;

            return porkman;
        }




    }
}
