using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MorndulCryptsConsole
{
    internal class Player
    {

        //Fields
        public string name;
        public int gold = 0;
        public int level = 1;
        public int xp = 0;
        public int health = 10;
        public int maxHealth = 10;
        public int damage = 1;
        public int armourValue = 0;
        public int potion = 5;
        public int weaponValue = 1;
        public int mods = 0;

        Random rand = new Random();

        public enum PlayerClass { Barbarian, Cleric, Thief };
        public PlayerClass currentClass = PlayerClass.Cleric;

        //Methods

        public int GetLevelUpValue()
        {
            return 30 * level + 20;
        }

        public bool CanLevelUp()
        {
            return xp >= GetLevelUpValue();
        }

        public void LevelUp()
        {
            while (CanLevelUp())
            {
                xp -= GetLevelUpValue();
                level++;
            }
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine($"You have leveled up! You are now level {level}");
            ResetColor();
        }

        public static void ProgressBar(string fillerChar, string backgroundChar, decimal value, int size)
        {
            int differentiator = (int)(value * size);
            for (int i = 0; i < size; i++)
            {
                if (i < differentiator)
                    Write(fillerChar);
                else
                    Write(backgroundChar);
            }
        }
    }
}
