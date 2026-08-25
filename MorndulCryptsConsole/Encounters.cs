using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MorndulCryptsConsole
{
    internal class Encounters
    {
        //Fields
        static Random rand = new Random();

        //Methods

        public static void BasicFightEncounter()
        {
            int health = rand.Next(4, 8);
            int attack = rand.Next(2, 4);
            int gold = rand.Next(1, 6);
            int xp = rand.Next(12, 19);




            Enemy porkman = Enemy.MakePorkMan(health, health, attack, gold, xp);
            Clear();
            WriteLine(porkman.combatLines[Game.currentPlayer.currentClass.ToString()]["IntroLines"][0]);
            ReadKey();
            Combat.CombatLoop(porkman);
        }

        public static void StageOneEncounter()
        {
            int health = rand.Next(4, 8);
            int attack = rand.Next(2, 4);
            int gold = rand.Next(1, 6);
            int xp = rand.Next(12, 19);
            Enemy enemy;

            switch (rand.Next(0, 2))
            {
                case 0:

                    enemy = Enemy.MakePorkMan(health, health, attack, gold, xp);
                    break;
                case 1:
                    
                    enemy = Enemy.MakeSpider(health, health, attack, gold, xp);
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

    }
}
