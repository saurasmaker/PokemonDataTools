using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Attributes
{
    class PokeEggGroup
    {
        public static string[] EggGroupNames = new string[] {
            "none", "Monster", "Human Like", "Water 1", "Water 3", "Bug", "Mineral", "Flying", "Amorphous", "Field", "Water 2", "Fairy", "Ditto", "Grass", "Dragon",
            "No Eggs Discovered", "Gender Unknown"
        };

        public static byte Monster = 0;
        public static byte HumanLike = 1;
        public static byte Water1 = 2;
        public static byte Water3 = 3;
        public static byte Bug = 4;
        public static byte Mineral = 5;
        public static byte Flying = 6;
        public static byte Amorphous = 7;
        public static byte Field = 8;
        public static byte Water2 = 9;
        public static byte Fairy = 10;
        public static byte Ditto = 11;
        public static byte Grass = 12;
        public static byte Dragon = 13;
        public static byte NoEggsDiscovered = 14;
        public static byte GenderUnknown = 15;
    }
}
