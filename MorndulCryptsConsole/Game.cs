using System;
using System.Collections.Generic;
using System.Text;
using TextBasedAdventure;
using static System.Console;

namespace MorndulCryptsConsole
{
    internal class Game
    {
        //Fields
        public static Player currentPlayer = new Player();

        //Methods
        public void Start()
        {
            ArtAssets.FormatTitle();
            TextAnimationUtils.AnimateTyping("What is your name: ");
            currentPlayer.name = ReadLine();

            WriteLine("");
            TextAnimationUtils.AnimateTyping(@"Choose a class: 
");

            ForegroundColor = ConsoleColor.DarkRed;
            TextAnimationUtils.AnimateTyping(@"Barbarian ");
            ResetColor();
            ForegroundColor = ConsoleColor.DarkCyan;
            TextAnimationUtils.AnimateTyping(@"Cleric ");
            ResetColor();
            ForegroundColor = ConsoleColor.DarkYellow;
            TextAnimationUtils.AnimateTyping(@"Thief ");
            ResetColor();
            WriteLine("");
            WriteLine("");

            bool classChosen = false;
            while (classChosen == false)
            {
                string input = ReadLine().Trim().ToUpper();
                if (input == "BARBARIAN")
                {
                    currentPlayer.currentClass = Player.PlayerClass.Barbarian;
                    classChosen = true;

                    Clear();
                    WriteLine("You have chosen Barbarian!");
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine(ArtAssets.Barbarian);
                    ResetColor();
                    ReadKey(true);
                }
                else if (input == "CLERIC")
                {
                    currentPlayer.currentClass = Player.PlayerClass.Cleric;
                    classChosen = true;

                    Clear();
                    WriteLine("You have chosen Cleric!");
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine(ArtAssets.Barbarian);
                    ResetColor();
                    ReadKey(true);
                }
                else if (input == "THIEF")
                {
                    currentPlayer.currentClass = Player.PlayerClass.Thief;
                    classChosen = true;

                    Clear();
                    WriteLine("You have chosen Thief!");
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine(ArtAssets.Barbarian);
                    ResetColor();
                    ReadKey(true);
                }
                else
                {
                    WriteLine("Please choose a valid class!");
                }
            }

            //Game Intro Sequence
            Clear();
            WriteLine(@"You awake in a cold, dark, stone room. You feel dazed. You are having trouble 
remembering anything about your past");
            if (currentPlayer.name == "")
                WriteLine("You can't even remember your own name, or if you were ever given one...");
            else
                WriteLine($"However, you know that your name is {currentPlayer.name}.");
            ReadKey(true);
            Clear();
            WriteLine(@"You grope around in the darkness until you find a door handle. You feel some resistance 
as you turn the handle, but the rusty lock breaks with little effort. You see your captor 
standing his back to you outside the door.");
            ReadKey(true);
        }
    }
}
