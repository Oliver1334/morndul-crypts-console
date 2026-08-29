using System;
using static System.Console;


namespace MorndulCryptsConsole
{
    class Program
    {
        //Fields
        public static bool gameNotOver = true;



        // Methods
        static void Main(string[] args)
        {
            Title = "~|Crypts of Morn'Dul|~";

            Game myGame = new Game();
            myGame.Start();
            
            while (gameNotOver)
            {
                Encounters.RunEncounter();


                if (Game.currentPlayer.level == 5) { Game.currentStage = 2; }
                else if (Game.currentPlayer.level == 10) { Game.currentStage = 3; }
            }

        }
    }
}




