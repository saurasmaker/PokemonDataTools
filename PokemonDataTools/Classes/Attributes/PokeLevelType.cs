using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Attributes
{
    class PokeLevelType
    {
        public static string[] LevelTypesNames = new string[] {
            "Fast", "Medium", "Slow", "Parabolic", "Erratic", "Fluctuating"
        };

        public static byte Fast = 0;
        public static byte Medium = 1;
        public static byte Slow = 2;
        public static byte Parabolic = 3;
        public static byte Erratic = 4;
        public static byte Fluctuating = 5;
    }
}
