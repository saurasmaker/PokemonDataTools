
namespace Classes.Attributes
{
    static class PokeStatus
    {
        public static readonly string[] StatusNames = new string[] {
            "Burn", "Freeze", "Paralysis", "Poison", "Badly Poison", "Sleep"
        };

        public static readonly byte Burn = 0;
        public static readonly byte Freeze = 1;
        public static readonly byte Paralysis = 2;
        public static readonly byte Poison = 3;
        public static readonly byte BadlyPoison = 4;
        public static readonly byte Sleep = 5;
    }
}
