using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MorndulCryptsConsole
{
    internal class ConsoleUtils
    {
        //Methods
        public static void WaitForKeyPress()
        {
            WriteLine("\nPress any key to continue...");
        }

        public static void QuitConsole()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}
