using System;
using static System.Console;


namespace MorndulCryptsConsole
{
    class Program
    {
        //Fields
        public static bool mainLoop = true;



        // Methods
        static void Main(string[] args)
        {
            Title = "~|Crypts of Morn'Dul|~";

            Game myGame = new Game();
            myGame.Start();

        }
    }
}




