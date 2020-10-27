
namespace Classes.Attributes
{

    static class PokeStat
    {
        public static readonly string[] StatsNames = new string[] {
            "Health", "Attack", "Defense",  "Special Attack", "Special Defense", "Speed", "Precision", "Evasion"
        };

        public static readonly byte Health = 0;
        public static readonly byte Attack = 1;
        public static readonly byte Defense = 2;
        public static readonly byte SpecialAttack = 3;
        public static readonly byte SpecialDefense = 4;
        public static readonly byte Speed = 5;
        public static readonly byte Precision = 6;
        public static readonly byte Evasion = 7;
    }
}
