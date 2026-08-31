using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using static System.Console;

namespace MorndulCryptsConsole
{
    internal class Encounters
    {
        //Fields
        static Random rand = new Random();

        public static Dictionary<int, List<string>> enemyPools = new Dictionary<int, List<string>>
        {
            { 1, new List<string> {"PorkMan", "Spider"} },
            { 2, new List<string> {"PorkMan", "Spider", "Skeleton"} },
            { 3, new List<string> {"PorkMan", "Spider", "Skeleton", "Necromancer"} }
        };

        public static Dictionary<int, Dictionary<string, EnemyStatRanges>> enemyStatTable = new Dictionary<int, Dictionary<string, EnemyStatRanges>>
        {
            {1, new Dictionary<string, EnemyStatRanges>
                {
                    {"PorkMan", new EnemyStatRanges(4,8,2,5,1,6,12,19) },
                    {"Spider", new EnemyStatRanges(11,14,1,3,1,6,12,19) }
                }
            },
            {2, new Dictionary<string, EnemyStatRanges>
                {
                    {"PorkMan", new EnemyStatRanges(4,8,2,4,1,6,12,19) },
                    {"Spider", new EnemyStatRanges(11,14,1,3,1,6,12,19) },
                    {"Skeleton", new EnemyStatRanges(2,5,2,4,1,6,12,19) }

                } 
            },
            {3, new Dictionary<string, EnemyStatRanges>
                {
                    {"PorkMan", new EnemyStatRanges(4,8,2,4,1,6,12,19) },
                    {"Spider", new EnemyStatRanges(11,14,1,3,1,6,12,19) },
                    {"Skeleton", new EnemyStatRanges(2,5,2,4,1,6,12,19) },
                    {"Necromancer", new EnemyStatRanges(1,4,6,10,1,6,12,19) }

                }
            }
        };

        public static Dictionary<int, BossStats> bossStatTable = new Dictionary<int, BossStats>
        {
            {1, new BossStats(20,20,4,50,40) },
            {2, new BossStats(30,30,6,80,60) },
            {3, new BossStats(45,45,8,120,100) }
        };

        //Methods

        //public static void BasicFightEncounter()
        //{
        //    int health = rand.Next(4, 8);
        //    int attack = rand.Next(2, 4);
        //    int gold = rand.Next(1, 6);
        //    int xp = rand.Next(12, 19);




        //    Enemy porkman = Enemy.MakePorkMan(health, health, attack, gold, xp);
        //    Clear();
        //    WriteLine(porkman.combatLines[Game.currentPlayer.currentClass.ToString()]["IntroLines"][0]);
        //    ReadKey();
        //    Combat.CombatLoop(porkman);
        //}

        public static void RunEncounter()
        {
            int currentStage = Game.currentStage;
            List<string> enemyPool = enemyPools[currentStage];
            string chosenEnemy = enemyPool[rand.Next(0, enemyPool.Count)];
            EnemyStatRanges ranges = enemyStatTable[currentStage][chosenEnemy];

            int health = rand.Next(ranges.minHealth, ranges.maxHealth);
            int attack = rand.Next(ranges.minAttack, ranges.maxAttack);
            int gold = rand.Next(ranges.minGold, ranges.maxGold);
            int xp = rand.Next(ranges.minExp, ranges.maxExp);

            Enemy enemy;

            switch (chosenEnemy)
            {
                case "PorkMan":
                    enemy = Enemy.MakePorkMan(health, health, attack, gold, xp);
                    break;
                case "Spider":
                    enemy = Enemy.MakeSpider(health, health, attack, gold, xp);
                    break;
                case "Skeleton":
                    enemy = Enemy.MakeSkeleton(health, health, attack, gold, xp);
                    break;
                case "Necromancer":
                    enemy = Enemy.MakeNecromancer(health, health, attack, gold, xp);
                    break;
                default:
                    enemy = Enemy.MakePorkMan(health, health, attack, gold, xp);
                    break;
            }

            Clear();
            WriteLine(enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["IntroLines"][0]);
            ReadKey();
            Combat.CombatLoop(enemy);

        }

        public static void BossEncounter()
        {
            int currentStage = Game.currentStage;
            BossStats stats = bossStatTable[currentStage];


            Enemy enemy = Enemy.MakeBoss(stats.health, stats.maxHealth, stats.attack, stats.gold, stats.xp);
            Clear();
            WriteLine(enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["IntroLines"][0]);
            ReadKey();
            Combat.CombatLoop(enemy);

        }

    }
}
