using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Attributes
{
    class VolatilePokeStatus
    {
        public static string[] StatusNames = new string[] {
            "Bound", "Can not Scape", "Confusion", "Curse", "Embargo", "Encore", "Flinch", "Heal Block", "Identified", "Infatuation",
            "Leech Seed", "Nightmare", "Perish Song", "Taunt", "Telekinesis", "Torment", 
        };

        public static byte Bound = 0;
        public static byte CanNotScape = 1;
        public static byte Confusion = 2;
        public static byte Curse = 3;
        public static byte Embargo = 4;
        public static byte Encore = 5;
        public static byte Flinch = 6;
        public static byte HealBlock = 7;
        public static byte Identified = 8;
        public static byte Infatuation = 9;
        public static byte LeechSeed = 10;
        public static byte Nightmare = 11;
        public static byte PerishSong = 12;
        public static byte Taunt = 13;
        public static byte Telekinesis = 14;
        public static byte Torment = 15;
    }
}
