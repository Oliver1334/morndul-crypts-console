using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MorndulCryptsConsole
{
    internal class Game
    {
        //Fields
        public static Player currentPlayer = new Player();
        public static int currentStage = 1;

        //Methods
        public void Start()
        {
            ArtAssets.FormatTitle();
            TextAnimationUtils.AnimateTyping("What is your name: ");
            currentPlayer.name = ReadLine();
            WriteLine("");

            bool showClassOptions = true;
            bool classChosen = false;
            while (classChosen == false)
            {
                if (showClassOptions)
                {
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
                }

                string input = ReadLine().Trim().ToUpper();
                if (input == "BARBARIAN")
                {

                    Clear();
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("Barbarian class and abilities description goes here");
                    ResetColor();
                    WriteLine("Are you certain you want to choose this class? (Y)es/(N)o");
                    
                    while (true)
                    {
                    string confirmation = ReadLine().Trim().ToUpper();
                    if(confirmation == "Y" || confirmation == "YES")
                    {
                        currentPlayer.currentClass = Player.PlayerClass.Barbarian;
                        classChosen = true;

                        Clear();
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine("You have chosen Barbarian!");
                        WriteLine(ArtAssets.Barbarian);
                        ResetColor();
                        ReadKey(true);
                            break;
                    } else if(confirmation == "N" || confirmation == "NO")
                    {
                            showClassOptions = true;
                            Clear();
                            break;
                    } else
                    {
                            WriteLine("Invalid input, try again!");
                    }
                    }
                    
                }
                else if (input == "CLERIC")
                {

                    Clear();
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine("Cleric class and abilities description goes here");
                    ResetColor();
                    WriteLine("Are you certain you want to choose this class? (Y)es/(N)o");

                    while (true)
                    {
                        string confirmation = ReadLine().Trim().ToUpper();
                        if (confirmation == "Y" || confirmation == "YES")
                        {
                            currentPlayer.currentClass = Player.PlayerClass.Cleric;
                            classChosen = true;

                            Clear();
                            ForegroundColor = ConsoleColor.DarkCyan;
                            WriteLine("You have chosen Cleric!");
                            WriteLine(ArtAssets.Barbarian);
                            ResetColor();
                            ReadKey(true);
                            break;
                        }
                        else if (confirmation == "N" || confirmation == "NO")
                        {
                            showClassOptions = true;
                            Clear();
                            break;
                        }
                        else
                        {
                            WriteLine("Invalid input, try again!");
                        }
                    }
                }
                else if (input == "THIEF")
                {

                    Clear();
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("Thief class and abilities description goes here");
                    ResetColor();
                    WriteLine("Are you certain you want to choose this class? (Y)es/(N)o");

                    while (true)
                    {
                        string confirmation = ReadLine().Trim().ToUpper();
                        if (confirmation == "Y" || confirmation == "YES")
                        {
                            currentPlayer.currentClass = Player.PlayerClass.Thief;
                            classChosen = true;

                            Clear();
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine("You have chosen Thief!");
                            WriteLine(ArtAssets.Barbarian);
                            ResetColor();
                            ReadKey(true);
                            break;
                        }
                        else if (confirmation == "N" || confirmation == "NO")
                        {
                            showClassOptions = true;
                            Clear();
                            break;
                        }
                        else
                        {
                            WriteLine("Invalid input, try again!");
                        }
                    }
                }
                else
                {
                    WriteLine("Please choose a valid class!");
                    showClassOptions = false;
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
