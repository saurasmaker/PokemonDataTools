
namespace Classes.Attributes
{
    static class VolatilePokeStatus
    {
        public static readonly string[] StatusNames = new string[] {
            "Bound", "Can not Scape", "Confusion", "Curse", "Embargo", "Encore", "Flinch", "Heal Block", "Identified", "Infatuation",
            "Leech Seed", "Nightmare", "Perish Song", "Taunt", "Telekinesis", "Torment", 
        };

        public static readonly byte Bound = 0;
        public static readonly byte CanNotScape = 1;
        public static readonly byte Confusion = 2;
        public static readonly byte Curse = 3;
        public static readonly byte Embargo = 4;
        public static readonly byte Encore = 5;
        public static readonly byte Flinch = 6;
        public static readonly byte HealBlock = 7;
        public static readonly byte Identified = 8;
        public static readonly byte Infatuation = 9;
        public static readonly byte LeechSeed = 10;
        public static readonly byte Nightmare = 11;
        public static readonly byte PerishSong = 12;
        public static readonly byte Taunt = 13;
        public static readonly byte Telekinesis = 14;
        public static readonly byte Torment = 15;
    }
}
