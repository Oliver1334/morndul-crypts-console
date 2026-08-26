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
                if (Game.currentStage == 1) { Encounters.StageOneEncounter(); }
                //else if (Game.currentStage == 2) { Encounters.StageTwoEncounter(); }
                //else if (Game.currentStage == 3) { Encounters.StageThreeEncounter(); }
                
                if (Game.currentPlayer.level == 5) { Game.currentStage = 2; }
                else if (Game.currentPlayer.level == 10) { Game.currentStage = 3; }

                WriteLine($"DEBUG: stage {Game.currentStage}, level {Game.currentPlayer.level}");
                ReadKey();
            }

        }
    }
}




