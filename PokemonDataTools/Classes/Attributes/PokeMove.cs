using Classes.Attributes;

namespace Classes
{

    public class PokeMove
    {
        #region Static Attributes

        public static string[] CategoryNames = new string[] {
            "Physical", "Special", "State"
        };

        public static byte Physical = 0;
        public static byte Special = 1;
        public static byte State = 2;

        public static string[] TargetNames = new string[] {
            "Can target any adjacent foe Pokémon", "Can target any adjacent okémon", "Can target any Pokémon", "Can target non-adjacent Pokémon",
            "Can target the user or an adjacent ally", "Target all adjacent foes", "Target all adjacent Pokémon", "Target all allies",
            "Target all foes", "Target all Pokémon", "Target one adjacent ally", "Target the user", "Target the user and all allies"
        };

        public static byte CanTargetAnyAdjacentFoePokemon = 0;
        public static byte CanTargetAnyAdjacentPokemon = 1;
        public static byte CanTargetAnyPokemon = 2;
        public static byte CanTargetNonAdjacentPokemon = 3;
        public static byte CanTargetTheUserOrAnAdjacentAlly = 4;
        public static byte TargetAllAdjacentFoes = 5;
        public static byte TargetAllAdjacentPokemons = 6;
        public static byte TargetAllAllies = 7;
        public static byte TargetAllFoes = 8;
        public static byte TargetAllPokemon = 9;
        public static byte TargetOneAdjacentAlly = 10;
        public static byte TargetTheUser = 11;
        public static byte TargetTheUserAndAllAllies = 12;

        #endregion


        #region Attributes
        private byte type;
        private byte category;
        private byte accuracy; //Si está en '0' no se puede esquivar el movimiento. 
        private sbyte power;
        private byte effectProbability;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Repetitions { get; set; } //How many times the movement is repeated after the first use
        public byte RepetitionsInTurn { get; set; } //How many times the movement is repeated after the first use
        public sbyte Recover { get; set; } //percentage of life gained based on damage done. If this attribute is negative, instead of recover will be a recoil of health.
        public byte PP { get; set; }
        public bool Contact { get; set; }
        public byte Target { get; set; }
        public byte Priority { get; set; }
        public string EffectCode { get; set; }

        #endregion

        #region Constructors
        public PokeMove()
        {

        }

        #endregion

        #region Methods
        public void Use()
        {

            return;
        }

        #endregion

        #region Static Methods

        public static PokeMove Zero()
        {


            return null;
        }

        #endregion

        #region Getters & Setters
        public byte Type
        {
            get
            { return type; }
            set
            {
                if (value < PokeType.TypesNames.Length)
                    type = value;
                else type = 0;
            }
        }

        public byte Category
        {
            get
            { return category; }
            set
            {
                if (value < CategoryNames.Length)
                    category = value;
                else category = 0;
            }
        }

        public byte Accuracy
        {
            get { return accuracy; }
            set
            {
                if (value > 100 || value < 0)
                    accuracy = 100;
                else accuracy = value;
            }
        }

        public sbyte Power
        {
            get { return power; }
            set
            {
                if (value < -1)
                    power = value;
                else power = 0;
            }
        }

        public byte EffectProbability
        {
            get { return effectProbability; }
            set
            {
                if (effectProbability > 100)
                    effectProbability = 0;
                else effectProbability = value;
            }
        }


        #endregion


    }
}
