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
//        public static void FirstEncounter()
//        {
//            WriteLine(@"You throw open the door and grab a rusty metal sword whilst charging toward your captor
//He turns..");
//            ReadKey(true);
//            Combat.CombatLoop(false, "Necromancer", 1, 4);
//        }

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

//        public static void WizardEncounter()
//        {
//            Clear();
//            WriteLine(@"The door slowly creaks open as you peer into the dark room. You see a tall man with a
//long beard looking at a large tome.
//You have entered the Crypt of the Wizard!");
//            ReadKey();
//            Combat.CombatLoop(false, "Dark Wizard", 4, 2);

//        }


        //Encounter Tools
        //public static void RandomEncounter()
        //{
        //    switch (rand.Next(0, 2))
        //    {
        //        case 0:
        //            BasicFightEncounter();
        //            break;
        //        case 1:
        //            WizardEncounter();
        //            break;
        //    }
        //}

    }
}
