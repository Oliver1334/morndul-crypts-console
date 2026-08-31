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
                if (Game.currentStage == 1 && Game.currentPlayer.level == 5)
                {
                    Encounters.BossEncounter();
                    Game.currentStage++;
                } else if (Game.currentStage == 2 && Game.currentPlayer.level == 10)
                {
                    Encounters.BossEncounter();
                    Game.currentStage++;
                }
                else if (Game.currentStage == 3 && Game.currentPlayer.level == 15)
                {
                    Encounters.BossEncounter();
                    gameNotOver = false;
                }
                else
                {
                    Encounters.RunEncounter();
                }
                
            }

            Clear();
            WriteLine("You win! Game over.");
            ReadKey();

        }
    }
}




