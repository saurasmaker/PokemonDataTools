using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Attributes
{
    class PokeStatus
    {
        public static string[] StatusNames = new string[] {
            "Burn", "Freeze", "Paralysis", "Poison", "Badly Poison", "Sleep"
        };

        public static byte Burn = 0;
        public static byte Freeze = 1;
        public static byte Paralysis = 2;
        public static byte Poison = 3;
        public static byte BadlyPoison = 4;
        public static byte Sleep = 5;
    }
}
