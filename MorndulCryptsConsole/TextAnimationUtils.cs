using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace MorndulCryptsConsole
{
    internal class TextAnimationUtils
    {
        //Methods
        public static void AnimateTyping(string text, int delay = 50)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Write(text[i]);
                Thread.Sleep(delay);

                //Skip animation if enter key is pressed
                if (KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Write(text.Substring(i + 1));
                        break;
                    }
                }
            }
        }
    }
}
