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
        public int xp;
        public int gold;


        public static Enemy MakePorkMan(int health, int maxHealth, int attack, int gold, int xp)
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
            porkman.xp = xp;

            return porkman;
        }

        public static Enemy MakeSpider(int health, int maxHealth, int attack, int gold, int xp)
        {
            Enemy spider = new Enemy();
            spider.stageOneName = "Giant spider";
            spider.stageTwoName = "Elder Giant spider";
            spider.stageThreeName = "Cryptstalker spider";
            spider.enemyType = Enemy.EnemyType.Beast;

            spider.combatLines = new Dictionary<string, Dictionary<string, List<string>>>
        {
            {  "Barbarian", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> {"Spider Barbarian IntroLine text" } },
                    { "AttackLines", new List<string> { "Spider Barbarian Attack Line one", "Spider Barbarian Attack Line Two", "Spider Barbarian Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "Spider Barbarian Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "Spider Barbarian Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "Spider Barbarian Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "Spider Barbarian Run Success Line one" } },
                    { "RunFailLines", new List<string> { "Spider Barbarian Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "Spider Barbarian Defeat Line one" } },
                    { "VictoryLines", new List<string> { "Spider Barbarian Victory Line one" } },

                }
            },
            {  "Cleric", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "Spider Cleric IntroLine text" } },
                    { "AttackLines", new List<string> { "Spider Cleric Attack Line one", "Spider Cleric Attack Line Two", "Spider Cleric Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "Spider Cleric Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "Spider Cleric Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "Spider Cleric Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "Spider Cleric Run Success Line one" } },
                    { "RunFailLines", new List<string> { "Spider Cleric Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "Spider Cleric Defeat Line one" } },
                    { "VictoryLines", new List<string> { "Spider Cleric Victory Line one" } },

                }
            },
            {  "Thief", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "Spider Thief IntroLine text" } },
                    { "AttackLines", new List<string> { "Spider Thief Attack Line one", "Spider Thief Attack Line Two", "Spider Thief Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "Spider Thief Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "Spider Thief Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "Spider Thief Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "Spider Thief Run Success Line one" } },
                    { "RunFailLines", new List<string> { "Spider Thief Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "Spider Thief Defeat Line one" } },
                    { "VictoryLines", new List<string> { "Spider Thief Victory Line one" } },

                }
            }
        };

            spider.art = ArtAssets.PorkMan;
            spider.colour = ConsoleColor.Green;
            spider.health = health;
            spider.maxHealth = maxHealth;
            spider.attack = attack;
            spider.gold = gold;
            spider.xp = xp;

            return spider;
        }

        public static Enemy MakeSkeleton(int health, int maxHealth, int attack, int gold, int xp)
        {
            Enemy skeleton = new Enemy();
            skeleton.stageOneName = "lesser skeleton";
            skeleton.stageTwoName = "Angry skeleton";
            skeleton.stageThreeName = "Evil Dead";
            skeleton.enemyType = Enemy.EnemyType.Undead;

            skeleton.combatLines = new Dictionary<string, Dictionary<string, List<string>>>
        {
            {  "Barbarian", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> {"skeleton Barbarian IntroLine text" } },
                    { "AttackLines", new List<string> { "skeleton Barbarian Attack Line one", "skeleton Barbarian Attack Line Two", "skeleton Barbarian Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "skeleton Barbarian Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "skeleton Barbarian Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "skeleton Barbarian Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "skeleton Barbarian Run Success Line one" } },
                    { "RunFailLines", new List<string> { "skeleton Barbarian Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "skeleton Barbarian Defeat Line one" } },
                    { "VictoryLines", new List<string> { "skeleton Barbarian Victory Line one" } },

                }
            },
            {  "Cleric", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "skeleton Cleric IntroLine text" } },
                    { "AttackLines", new List<string> { "skeleton Cleric Attack Line one", "skeleton Cleric Attack Line Two", "skeleton Cleric Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "skeleton Cleric Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "skeleton Cleric Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "skeleton Cleric Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "skeleton Cleric Run Success Line one" } },
                    { "RunFailLines", new List<string> { "skeleton Cleric Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "skeleton Cleric Defeat Line one" } },
                    { "VictoryLines", new List<string> { "skeleton Cleric Victory Line one" } },

                }
            },
            {  "Thief", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "skeleton Thief IntroLine text" } },
                    { "AttackLines", new List<string> { "skeleton Thief Attack Line one", "skeleton Thief Attack Line Two", "skeleton Thief Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "skeleton Thief Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "skeleton Thief Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "skeleton Thief Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "skeleton Thief Run Success Line one" } },
                    { "RunFailLines", new List<string> { "skeleton Thief Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "skeleton Thief Defeat Line one" } },
                    { "VictoryLines", new List<string> { "skeleton Thief Victory Line one" } },

                }
            }
        };

            skeleton.art = ArtAssets.PorkMan;
            skeleton.colour = ConsoleColor.DarkGray;
            skeleton.health = health;
            skeleton.maxHealth = maxHealth;
            skeleton.attack = attack;
            skeleton.gold = gold;
            skeleton.xp = xp;

            return skeleton;
        }

        public static Enemy MakeNecromancer(int health, int maxHealth, int attack, int gold, int xp)
        {
            Enemy necromancer = new Enemy();
            necromancer.stageOneName = "Necromancer";
            necromancer.stageTwoName = "Necromancer";
            necromancer.stageThreeName = "Necromancer";
            necromancer.enemyType = Enemy.EnemyType.Humanoid;

            necromancer.combatLines = new Dictionary<string, Dictionary<string, List<string>>>
        {
            {  "Barbarian", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> {"necromancer Barbarian IntroLine text" } },
                    { "AttackLines", new List<string> { "necromancer Barbarian Attack Line one", "necromancer Barbarian Attack Line Two", "necromancer Barbarian Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "necromancer Barbarian Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "necromancer Barbarian Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "necromancer Barbarian Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "necromancer Barbarian Run Success Line one" } },
                    { "RunFailLines", new List<string> { "necromancer Barbarian Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "necromancer Barbarian Defeat Line one" } },
                    { "VictoryLines", new List<string> { "necromancer Barbarian Victory Line one" } },

                }
            },
            {  "Cleric", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "necromancer Cleric IntroLine text" } },
                    { "AttackLines", new List<string> { "necromancer Cleric Attack Line one", "necromancer Cleric Attack Line Two", "necromancer Cleric Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "necromancer Cleric Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "necromancer Cleric Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "necromancer Cleric Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "necromancer Cleric Run Success Line one" } },
                    { "RunFailLines", new List<string> { "necromancer Cleric Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "necromancer Cleric Defeat Line one" } },
                    { "VictoryLines", new List<string> { "necromancer Cleric Victory Line one" } },

                }
            },
            {  "Thief", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "necromancer Thief IntroLine text" } },
                    { "AttackLines", new List<string> { "necromancer Thief Attack Line one", "necromancer Thief Attack Line Two", "necromancer Thief Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "necromancer Thief Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "necromancer Thief Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "necromancer Thief Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "necromancer Thief Run Success Line one" } },
                    { "RunFailLines", new List<string> { "necromancer Thief Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "necromancer Thief Defeat Line one" } },
                    { "VictoryLines", new List<string> { "necromancer Thief Victory Line one" } },

                }
            }
        };

            necromancer.art = ArtAssets.Necromancer3;
            necromancer.colour = ConsoleColor.DarkBlue;
            necromancer.health = health;
            necromancer.maxHealth = maxHealth;
            necromancer.attack = attack;
            necromancer.gold = gold;
            necromancer.xp = xp;

            return necromancer;
        }

        public static Enemy MakeBoss(int health, int maxHealth, int attack, int gold, int xp)
        {
            Enemy boss = new Enemy();
            boss.stageOneName = "High Necromancer";
            boss.stageTwoName = "High Necromancer";
            boss.stageThreeName = "High Necromancer";
            boss.enemyType = Enemy.EnemyType.Humanoid;
            
            boss.combatLines = new Dictionary<string, Dictionary<string, List<string>>>
        {
            {  "Barbarian", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> {"boss Barbarian IntroLine text" } },
                    { "AttackLines", new List<string> { "boss Barbarian Attack Line one", "boss Barbarian Attack Line Two", "boss Barbarian Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "boss Barbarian Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "boss Barbarian Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "boss Barbarian Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "boss Barbarian Run Success Line one" } },
                    { "RunFailLines", new List<string> { "boss Barbarian Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "boss Barbarian Defeat Line one" } },
                    { "VictoryLines", new List<string> { "boss Barbarian Victory Line one" } },

                }
            },
            {  "Cleric", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "boss Cleric IntroLine text" } },
                    { "AttackLines", new List<string> { "boss Cleric Attack Line one", "boss Cleric Attack Line Two", "boss Cleric Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "boss Cleric Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "boss Cleric Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "boss Cleric Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "boss Cleric Run Success Line one" } },
                    { "RunFailLines", new List<string> { "boss Cleric Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "boss Cleric Defeat Line one" } },
                    { "VictoryLines", new List<string> { "boss Cleric Victory Line one" } },

                }
            },
            {  "Thief", new Dictionary<string, List<string>>
                {
                    { "IntroLines", new List<string> { "boss Thief IntroLine text" } },
                    { "AttackLines", new List<string> { "boss Thief Attack Line one", "boss Thief Attack Line Two", "boss Thief Attack Line Three" } },
                    { "SpecialAttackLines", new List<string> {"Special Attack Line one", "Special Attack Line Two", "Special Attack Line Three"} },
                    { "DefendLines", new List<string> { "boss Thief Defend Line one" } },
                    { "HealSuccessLines", new List<string> { "boss Thief Heal Success Line one" } },
                    { "HealFailLines", new List<string> { "boss Thief Heal Fail Line one" } },
                    { "RunSuccessLines", new List<string> { "boss Thief Run Success Line one" } },
                    { "RunFailLines", new List<string> { "boss Thief Run Fail Line one" } },
                    { "DefeatLines", new List<string> { "boss Thief Defeat Line one" } },
                    { "VictoryLines", new List<string> { "boss Thief Victory Line one" } },

                }
            }
        };

            boss.art = ArtAssets.Necromancer3;
            boss.colour = ConsoleColor.Red;
            boss.health = health;
            boss.maxHealth = maxHealth;
            boss.attack = attack;
            boss.gold = gold;
            boss.xp = xp;

            return boss;
        }




    }
}
