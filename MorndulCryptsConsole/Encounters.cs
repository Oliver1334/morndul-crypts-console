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
        public static void FirstEncounter()
        {
            WriteLine(@"You throw open the door and grab a rusty metal sword whilst charging toward your captor
He turns..");
            ReadKey(true);
            Combat.CombatLoop(false, "Necromancer", 1, 4);
        }

        public static void BasicFightEncounter()
        {
            Clear();
            WriteLine("You turn the corner and there you see a hulking beast...");
            ReadKey();
            Combat.CombatLoop(true, "", 0, 0);
        }

        public static void WizardEncounter()
        {
            Clear();
            WriteLine(@"The door slowly creaks open as you peer into the dark room. You see a tall man with a
long beard looking at a large tome.
You have entered the Crypt of the Wizard!");
            ReadKey();
            Combat.CombatLoop(false, "Dark Wizard", 4, 2);

        }


        //Encounter Tools
        public static void RandomEncounter()
        {
            switch (rand.Next(0, 2))
            {
                case 0:
                    BasicFightEncounter();
                    break;
                case 1:
                    WizardEncounter();
                    break;
            }
        }

    }
}
