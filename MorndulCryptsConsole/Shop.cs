using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MorndulCryptsConsole
{
    internal class Shop
    {
        //Fields
        //static int armourMod;
        //static int weaponMod;
        //static int difMod;


        //Methods
        internal static void LoadShop(Player p)
        {
            //armourMod = p.armourValue;
            //weaponMod = p.weaponValue;
            //difMod = p.mods;

            RunShop(p);
        }

        internal static void RunShop(Player p)
        {

            int potionPrice;
            int armourPrice;
            int weaponPrice;
            int difPrice;


            while (true)
            {
                Clear();
                potionPrice = 20 + 10 * p.mods;
                armourPrice = 100 * (p.armourValue + 1);
                weaponPrice = 100 * p.weaponValue;
                difPrice = 300 + 100 * p.mods;

                WriteLine($"          Shop          ");
                WriteLine($"========================");
                WriteLine($"|  (W)eapon:${weaponPrice}         |");
                WriteLine($"|  (A)rmour:${armourPrice}         |");
                WriteLine($"|  (P)otions:${potionPrice}        |");
                WriteLine($"|  (D)ifficulty Mod:${difPrice} |");
                WriteLine($"========================");
                WriteLine($"(E)xit ");

                WriteLine($"\n\n       {p.name}'s Stats     ");
                WriteLine($"========================");
                WriteLine($"Current Health: {p.health}");
                WriteLine($"Coins: {p.gold}");
                WriteLine($"Weapon Strength: {p.weaponValue}");
                WriteLine($"Armour Toughness: {p.armourValue}");
                WriteLine($"Potions: {p.potion}");
                WriteLine($"Difficulty Mods: X{p.mods}");

                WriteLine("Xp:");
                Write("[");
                Player.ProgressBar("█", "░", ((decimal)p.xp / (decimal)p.GetLevelUpValue()), 25);
                Write("]");


                WriteLine($"Level: {p.level}");
                WriteLine($"========================");
                //Wait for input
                string input = ReadLine().Trim().ToUpper();
                if (input == "W" || input == "WEAPON")
                {
                    TryBuy("weapon", weaponPrice, p);
                }
                else if (input == "A" || input == "ARMOUR")
                {
                    TryBuy("armour", armourPrice, p);
                }
                else if (input == "P" || input == "POTION")
                {
                    TryBuy("potion", potionPrice, p);
                }
                else if (input == "D" || input == "DIFFICULTY")
                {
                    TryBuy("dif", difPrice, p);
                }
                else if (input == "E" || input == "EXIT")
                    break;
            }
        }

        static void TryBuy(string item, int cost, Player p)
        {
            if (p.gold >= cost)
            {
                if (item == "potion")
                    p.potion++;
                else if (item == "weapon")
                    p.weaponValue++;
                else if (item == "armour")
                    p.armourValue++;
                else if (item == "dif")
                    p.mods++;

                p.gold -= cost;
            }
            else
            {
                WriteLine("Not enough gold!");
                ReadKey();
            }
        }
    }
}
