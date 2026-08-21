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
                    { "IntroLines", new List<string> {"IntroLine text" } },
                    { "AttackLines", new List<string> {"Attack Line one", "Attack Line Two", "Attack Line Three"} },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> {"Defend Line one"} },
                    { "HealSuccessLines", new List<string> {"Heal Success Line one"} },
                    { "HealFailLines", new List<string> {"Heal Fail Line one"} },
                    { "RunSuccessLines", new List<string> {"Run Success Line one"} },
                    { "RunFailLines", new List<string> {"Run Fail Line one"} },
                    { "DefeatLines", new List<string> {"Defeat Line one"} },
                    { "VictoryLines", new List<string> {"Victory Line one"} },

                }
            },
            {  "Cleric", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> {"IntroLine text" } },
                    { "AttackLines", new List<string> {"Attack Line one", "Attack Line Two", "Attack Line Three"} },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> {"Defend Line one"} },
                    { "HealSuccessLines", new List<string> {"Heal Success Line one"} },
                    { "HealFailLines", new List<string> {"Heal Fail Line one"} },
                    { "RunSuccessLines", new List<string> {"Run Success Line one"} },
                    { "RunFailLines", new List<string> {"Run Fail Line one"} },
                    { "DefeatLines", new List<string> {"Defeat Line one"} },
                    { "VictoryLines", new List<string> {"Victory Line one"} },

                }
            },
            {  "Thief", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> {"IntroLine text" } },
                    { "AttackLines", new List<string> {"Attack Line one", "Attack Line Two", "Attack Line Three"} },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> {"Defend Line one"} },
                    { "HealSuccessLines", new List<string> {"Heal Success Line one"} },
                    { "HealFailLines", new List<string> {"Heal Fail Line one"} },
                    { "RunSuccessLines", new List<string> {"Run Success Line one"} },
                    { "RunFailLines", new List<string> {"Run Fail Line one"} },
                    { "DefeatLines", new List<string> {"Defeat Line one"} },
                    { "VictoryLines", new List<string> {"Victory Line one"} },

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
