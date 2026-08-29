using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using static System.Console;

namespace MorndulCryptsConsole
{
    internal class Combat
    {
        //Fields
        static Random rand = new Random();

        //Methods
        public static void CombatLoop(Enemy enemy)
        {
          

            while(enemy.health > 0)
            {
                Clear();
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"Location: {Game.stageName[Game.currentStage]}");
                ResetColor();
                WriteLine(enemy.stageOneName);
                Write($"ATK:{enemy.attack}  ");
                DisplayHealth(enemy.stageOneName, enemy.health, enemy.maxHealth);
                ForegroundColor = enemy.colour;
                WriteLine(enemy.art);
                ResetColor();
                WriteLine("========================");
                WriteLine("|  (A)ttack  (D)efend  |");
                WriteLine("|  (R)un     (H)eal    |");
                WriteLine("========================");
                if (Game.currentPlayer.currentClass == Player.PlayerClass.Barbarian)
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"{Game.currentPlayer.name} the {Game.currentPlayer.currentClass} | Lvl({Game.currentPlayer.level})");
                    ResetColor();
                }
                else if (Game.currentPlayer.currentClass == Player.PlayerClass.Cleric)
                {
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine($"{Game.currentPlayer.name} the {Game.currentPlayer.currentClass} | Lvl({Game.currentPlayer.level})");
                    ResetColor();
                }
                else if (Game.currentPlayer.currentClass == Player.PlayerClass.Thief)
                {
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine($"{Game.currentPlayer.name} the {Game.currentPlayer.currentClass} | Lvl({Game.currentPlayer.level})");
                    ResetColor();
                }
                DisplayHealth(Game.currentPlayer.name, Game.currentPlayer.health, Game.currentPlayer.maxHealth);
                WriteLine($"Potions: {Game.currentPlayer.potion}");

                string input = ReadLine().Trim().ToUpper();
                if (input == "A" || input == "ATTACK")
                {
                    //Attack
                    List<string> attackLines = enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["AttackLines"];
                    WriteLine(attackLines[rand.Next(attackLines.Count)]);
                    int damage = enemy.attack - Game.currentPlayer.armourValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Game.currentPlayer.weaponValue) + rand.Next(1, 4) + ((Game.currentPlayer.currentClass == Player.PlayerClass.Barbarian) ? 2 : 0);
                    //Barbarian does 2 extra damage
                    WriteLine($"You lose {damage} health and deal {attack} damage.");
                    Game.currentPlayer.health -= damage;
                    enemy.health -= attack;
                }
                else if (input == "D" || input == "DEFEND")
                {
                    //Defend
                    List<string> defendLines = enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["DefendLines"];
                    WriteLine(defendLines[rand.Next(defendLines.Count)]);
                    int damage = (enemy.attack / 4) - Game.currentPlayer.armourValue; // power of opponent divided by 4
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Game.currentPlayer.weaponValue) / 2; //attack divided by two so you do significantly less dmg when defending
                    WriteLine($"You lose {damage} health and deal {attack} damage.");
                    Game.currentPlayer.health -= damage;
                    enemy.health -= attack;
                }
                else if (input == "R" || input == "RUN")
                {
                    //Run
                    if (Game.currentPlayer.currentClass != Player.PlayerClass.Thief && rand.Next(0, 2) == 0) //Thief can 100% run from combat, 50/50 chance of running for other classes
                    {
                        List<string> runFailLines = enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["RunFailLines"];
                        WriteLine(runFailLines[rand.Next(runFailLines.Count)]);
                        int damage = enemy.attack - Game.currentPlayer.armourValue;
                        if (damage < 0)
                            damage = 0;
                        Game.currentPlayer.health -= damage;
                        WriteLine($"You lose {damage} health and are unable to escape.");
                        ReadKey(true);
                    }
                    else
                    {
                        List<string> runSuccessLines = enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["RunSuccessLines"];
                        WriteLine(runSuccessLines[rand.Next(runSuccessLines.Count)]);
                        ReadKey(true);
                        //go to store
                        Shop.LoadShop(Game.currentPlayer);
                    }
                }
                else if (input == "H" || input == "HEAL")
                {
                    //Heal
                    if (Game.currentPlayer.potion == 0)
                    {
                        List<string> healFailLines = enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["HealFailLines"];
                        WriteLine(healFailLines[rand.Next(healFailLines.Count)]);
                        int damage = enemy.attack - Game.currentPlayer.armourValue;
                        if (damage < 0)
                            damage = 0;
                        WriteLine($"The {enemy.stageOneName} strikes you with a mighty blow! You lose {damage} health.");
                    }
                    else
                    {
                        List<string> healSuccessLines = enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["HealSuccessLines"];
                        WriteLine(healSuccessLines[rand.Next(healSuccessLines.Count)]);
                        int potionValue = 5 + ((Game.currentPlayer.currentClass == Player.PlayerClass.Cleric) ? +4 : 0); // Clerics get extra heal here
                        WriteLine($"You gain {potionValue} health.");
                        Game.currentPlayer.health += potionValue;
                        Game.currentPlayer.potion -= 1;
                        WriteLine($"As you were occupied the {enemy.stageOneName} advanced and struck.");
                        int damage = (enemy.attack / 2) - Game.currentPlayer.armourValue;
                        if (damage < 0)
                            damage = 0;
                        WriteLine($"You lose {damage} health.");
                    }
                } else
                {
                    WriteLine("Invalid input, try again!"); // Stop messing around you are in the throes of combat!
                }

                if (Game.currentPlayer.health <= 0)
                {
                    //Death Code
                    List<string> defeatLines = enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["DefeatLines"];
                    WriteLine(defeatLines[rand.Next(defeatLines.Count)]);
                    ReadKey();
                    ConsoleUtils.QuitConsole();

                }
                ReadKey(true);
            }
         
            
            List<string> victoryLines = enemy.combatLines[Game.currentPlayer.currentClass.ToString()]["VictoryLines"];
            WriteLine(victoryLines[rand.Next(victoryLines.Count)]);
            WriteLine($"As you stand victorious over the {enemy.stageOneName}, its body dissolves into {enemy.gold} gold coins! You have gained {enemy.xp}XP!");
            Game.currentPlayer.gold += enemy.gold;
            Game.currentPlayer.xp += enemy.xp;

            if (Game.currentPlayer.CanLevelUp())
                Game.currentPlayer.LevelUp();
            ReadKey();
        }

        private static void DisplayHealth(string name, int health, int maxHealth)
        {
            Write("HP:[");
            //Draw "Health" hit points that are filled in:
            BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < health; i++)
            {
                Write(" ");
            }
            // Draw the rest that are not filled in:
            BackgroundColor = ConsoleColor.Red;
            for (int i = health; i < maxHealth; i++)
            {
                Write(" ");
            }
            ResetColor();
            WriteLine($"] ({health}/{maxHealth})");
        }














    }
}
