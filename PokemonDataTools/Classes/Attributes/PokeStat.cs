using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Attributes
{

    class PokeStat
    {
        public static string[] StatsNames = new string[] {
            "Health", "Attack", "Defense",  "Special Attack", "Special Defense", "Speed", "Precision", "Evasion"
        };

        public static byte Health = 0;
        public static byte Attack = 1;
        public static byte Defense = 2;
        public static byte SpecialAttack = 3;
        public static byte SpecialDefense = 4;
        public static byte Speed = 5;
        public static byte Precision = 6;
        public static byte Evasion = 7;
    }
}
