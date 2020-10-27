
namespace Classes.Attributes
{
    static class PokeLevelType
    {
        public static readonly string[] LevelTypesNames = new string[] {
            "Fast", "Medium", "Slow", "Parabolic", "Erratic", "Fluctuating"
        };

        public static readonly byte Fast = 0;
        public static readonly byte Medium = 1;
        public static readonly byte Slow = 2;
        public static readonly byte Parabolic = 3;
        public static readonly byte Erratic = 4;
        public static readonly byte Fluctuating = 5;
    }
}
