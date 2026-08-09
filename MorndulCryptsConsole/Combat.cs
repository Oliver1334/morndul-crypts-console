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
        public static void CombatLoop(bool random, string name, int power, int health)
        {
            string nameEnemy = "";
            int attackValueEnemy = 0;
            int healthEnemy = 0;
            int maxHealthEnemy = 0;
            int maxPlayerHealth = Game.currentPlayer.health;

            if (random)
            {
                nameEnemy = GetName();
                attackValueEnemy = Game.currentPlayer.GetPower();
                healthEnemy = Game.currentPlayer.GetHealth();
                maxHealthEnemy = healthEnemy;
            }
            else
            {
                nameEnemy = name;
                attackValueEnemy = power;
                healthEnemy = health;
                maxHealthEnemy = health;
            }

            while(healthEnemy > 0)
            {
                Clear();
                WriteLine(nameEnemy);
                Write($"ATK:{attackValueEnemy}  ");
                DisplayHealth(nameEnemy, healthEnemy, maxHealthEnemy);
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine(ArtAssets.PorkMan);
                ResetColor();
                WriteLine("========================");
                WriteLine("|  (A)ttack  (D)efend  |");
                WriteLine("|  (R)un     (H)eal    |");
                WriteLine("========================");
                if (Game.currentPlayer.currentClass == Player.PlayerClass.Barbarian)
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine($"{Game.currentPlayer.name} the {Game.currentPlayer.currentClass}");
                    ResetColor();
                }
                else if (Game.currentPlayer.currentClass == Player.PlayerClass.Cleric)
                {
                    ForegroundColor = ConsoleColor.DarkCyan;
                    WriteLine($"{Game.currentPlayer.name} the {Game.currentPlayer.currentClass}");
                    ResetColor();
                }
                else if (Game.currentPlayer.currentClass == Player.PlayerClass.Thief)
                {
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine($"{Game.currentPlayer.name} the {Game.currentPlayer.currentClass}");
                    ResetColor();
                }
                DisplayHealth(Game.currentPlayer.name, Game.currentPlayer.health, Game.currentPlayer.maxHealth);
                WriteLine($"Potions: {Game.currentPlayer.potion}");

                string input = ReadLine().Trim().ToUpper();
                if (input == "A" || input == "ATTACK")
                {
                    //Attack
                    WriteLine(@$"You surge forth with haste, your sword flying in your hands! As you pass, the {nameEnemy} strikes you.");
                    int damage = attackValueEnemy - Game.currentPlayer.armourValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Game.currentPlayer.weaponValue) + rand.Next(1, 4) + ((Game.currentPlayer.currentClass == Player.PlayerClass.Barbarian) ? 2 : 0);
                    //Barbarian does 2 extra damage
                    WriteLine($"You lose {damage} health and deal {attack} damage.");
                    Game.currentPlayer.health -= damage;
                    healthEnemy -= attack;
                }
                else if (input == "D" || input == "DEFEND")
                {
                    //Defend
                    WriteLine(@$"As the {nameEnemy} prepares to strike, you ready your sword in a defensive stance...");
                    int damage = (attackValueEnemy / 4) - Game.currentPlayer.armourValue; // power of opponent divided by 4
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Game.currentPlayer.weaponValue) / 2; //attack divided by two so you do significantly less dmg when defending
                    WriteLine($"You lose {damage} health and deal {attack} damage.");
                    Game.currentPlayer.health -= damage;
                    healthEnemy -= attack;
                }
                else if (input == "R" || input == "RUN")
                {
                    //Run
                    if (Game.currentPlayer.currentClass != Player.PlayerClass.Thief && rand.Next(0, 2) == 0) //Thief can 100% run from combat, 50/50 chance of running for other classes
                    {
                        WriteLine($"As you sprint away from the {nameEnemy}, its strike catches you in the back, sending you to the ground.");
                        int damage = attackValueEnemy - Game.currentPlayer.armourValue;
                        if (damage < 0)
                            damage = 0;
                        Game.currentPlayer.health -= damage;
                        WriteLine($"You lose {damage} and are unable to escape.");
                        ReadKey(true);
                    }
                    else
                    {
                        WriteLine($"You use your crazy ninja moves to evade the {nameEnemy} and you successfully escape!");
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
                        WriteLine("As you desperately grasp for a potion in your bag all that you find is empty glass flasks.");
                        int damage = attackValueEnemy - Game.currentPlayer.armourValue;
                        if (damage < 0)
                            damage = 0;
                        WriteLine($"The {nameEnemy} strikes you with a mighty blow! You lose {damage} health.");
                    }
                    else
                    {
                        WriteLine("You reach into your bag and pull out a glowing purple flask. You take a long drink.");
                        int potionValue = 5 + ((Game.currentPlayer.currentClass == Player.PlayerClass.Cleric) ? +4 : 0); // Clerics get extra heal here
                        WriteLine($"You gain {potionValue} health.");
                        Game.currentPlayer.health += potionValue;
                        Game.currentPlayer.potion -= 1;
                        WriteLine($"As you were occupied the human rogue advanced and struck.");
                        int damage = (attackValueEnemy / 2) - Game.currentPlayer.armourValue;
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
                    WriteLine($"As the {nameEnemy} stands tall, you have been slain...");
                    ReadKey();
                    ConsoleUtils.QuitConsole();

                }
                ReadKey(true);
            }
            int gold = Game.currentPlayer.GetGold();
            int experience = Game.currentPlayer.GetXp();
            WriteLine($"As you stand victorious over the {nameEnemy}, its body dissolves into {gold} gold coins! You have gained {experience}XP!");
            Game.currentPlayer.gold += gold;
            Game.currentPlayer.xp += experience;

            if (Game.currentPlayer.CanLevelUp())
                Game.currentPlayer.LevelUp();
            ReadKey();
        }

        private static string GetName()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    return "Skeleton";
                case 1:
                    return "Zombie";
                case 2:
                    return "Necromancer";
                case 3:
                    return "Ghoul";

            }
            return "";
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
