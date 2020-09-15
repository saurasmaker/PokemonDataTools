using System;
using System.Collections.Generic;
using System.Drawing;
using Classes.Attributes;

namespace Classes
{
    public class OPokemon
    {
        public struct Evolution
        {
            public int idPokemon;
            public byte evolutionType;

            public Evolution(int idPokemon, byte evolutionType)
            {
                this.idPokemon = idPokemon;
                this.evolutionType = evolutionType;
            }
        }

        public struct MoveWillLearnByLevel
        {
            public byte level;
            public int idMove;

            public MoveWillLearnByLevel(byte level, int idMove)
            {
                this.level = level;
                this.idMove = idMove;
            }
        }


        #region Attributes
        public int Id { get; set; }
        public int PokedexNumber { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Habitat { get; set; }
        public string FileName { get; set; }
        public ushort Height { get; set; }
        public ushort Weight { get; set; }
        public Color Color { get; set; }
        public byte Rareness { get; set; }
        public byte Happiness { get; set; }
        public int StepsToHatch { get; set; }
        public bool IsMega { get; set; }
        public bool IsLegendary { get; set; }
        public byte[] Abilities { get; set; }

        public List<Evolution> Evolutions { get; set; }

        //Satats base of the pokémon.
        public byte Health { get; set; }
        public byte Attack { get; set; }
        public byte SpecialAttack { get; set; }
        public byte Defense { get; set; }
        public byte SpecialDefense { get; set; }
        public byte Speed { get; set; }

        public byte ExperienceGives { get; set; }


        private string description;
        private byte[] types;
        private byte[] givedEVs;
        private byte levelType;
        private byte eggGroup;
        private byte[] genresPercentage;
        private List<MoveWillLearnByLevel> movesWillLearnByLevel;
        private List<int> eggMoves; //Moves Id. Movements that the pokémon can learn by breeding.
        private List<int> canLearnMoves; //Moves Id. Movements that the pokémon can learn byt MT or a tutor. 

        #endregion

        #region Constructors
        public OPokemon()
        {
            Types = new byte[2] { 0, 0 };
            GivedEVs = new byte[6] { 0, 0, 0, 0, 0, 0 };
            GenresPercentage = new byte[2] { 0, 0 };
            Abilities = new byte[3] { 0, 0, 0 };
            MovesWillLearnByLevel = new List<MoveWillLearnByLevel>();
            CanLearnMoves = new List<int>();
        }
        #endregion

        #region Methods
        public string Show()
        {
            return (
            "\n ||----- " + Name + " -----||" +
            "\n Category: " + Category +
            "\n Description: " + Description +
            "\n Height: " + Height +
            "\n Weight: " + Weight +
            "\n Types: " + PokeType.TypesNames[Types[0]] + " / " + PokeType.TypesNames[Types[1]] +

            "\n\n ---Abilities--- " +
            "\n  -Ability 1: " + PokeAbility.AbilitiesNames[Abilities[0]] +
            "\n  -Ability 2: " + PokeAbility.AbilitiesNames[Abilities[1]] +
            "\n  -Hidden: " + PokeAbility.AbilitiesNames[Abilities[1]] +

            "\n\n ---Base Stats--- " +
            "\n Health: " + Health +
            "\n Attack: " + Attack +
            "\n Special Attack: " + SpecialAttack +
            "\n Defense: " + Defense +
            "\n Special Defense: " + SpecialDefense +
            "\n Speed: " + Speed +

            "\n\n ---Reproduction---" +
            "\n  -Male: " + GenresPercentage[0] +
            "\n  -Female: " + GenresPercentage[1] +
            "\n  -Egg Group: " + PokeEggGroup.EggGroupNames[EggGroup] +

            "\n\n ---EVs it Gives--- " +
            "\n Health: " + GivedEVs[PokeStat.Health] +
            "\n Attack: " + GivedEVs[PokeStat.Attack] +
            "\n Special Attack: " + GivedEVs[PokeStat.SpecialAttack] +
            "\n Defense: " + GivedEVs[PokeStat.Defense] +
            "\n Special Defense: " + GivedEVs[PokeStat.SpecialDefense] +
            "\n Speed: " + GivedEVs[PokeStat.Speed] +

            "\n\n Level Type: " + PokeLevelType.LevelTypesNames[LevelType] + "\n"
            );
        }



        #endregion

        #region Static Methods
        public static OPokemon Zero()
        {

            return null;
        }

        #endregion

        #region Getters && Setters

        public string Description
        {
            get { return description; }
            set { if (value.Length < 1000) description = value; }
        }

        public byte[] Types
        {
            get
            {
                return types;
            }
            set
            {
                if (value[0] < 0 || value[0] > 17)
                    types = new byte[] { 0, value[1] };
                if (value[1] < 0 || value[1] > 17)
                    types = new byte[] { value[0], 0 };

                else
                    types = value;
            }
        }

        public byte[] GivedEVs
        {
            get { return givedEVs; }
            set
            {
                givedEVs = new byte[6] { 0, 0, 0, 0, 0, 0 };

                for (byte i = 0; i < 6; ++i)
                    if (value[i] > 255)
                    {
                        Console.WriteLine("Not valid EVs {0} in position {1}", PokeStat.StatsNames[i], i);
                        return;
                    }
                    else givedEVs[i] = value[i];

            }
        }

        public byte[] GenresPercentage
        {
            get { return genresPercentage; }
            set
            {
                if (value[0] + value[1] != 100) genresPercentage = value;
                else genresPercentage = new byte[2] { 0, 0 };
            }
        }

        public byte LevelType
        {
            get
            {
                return levelType;
            }
            set
            {
                if (value < 6) levelType = value;
                else Console.WriteLine("Not valid Level type value");
            }
        }

        public byte EggGroup
        {
            get
            {
                return eggGroup;
            }
            set
            {
                if (value < 16) eggGroup = value;
                else Console.WriteLine("Not valid Egg Group value");
            }
        }


        public List<MoveWillLearnByLevel> MovesWillLearnByLevel
        {
            get { if (movesWillLearnByLevel == null) movesWillLearnByLevel = new List<MoveWillLearnByLevel>(); return movesWillLearnByLevel; }
            set { movesWillLearnByLevel = value; }
        }

        public List<int> EggMoves
        {
            get { if (eggMoves == null) eggMoves = new List<int>(); return eggMoves; }
            set { eggMoves = value; }
        }

        public List<int> CanLearnMoves
        {
            get { if (canLearnMoves == null) canLearnMoves = new List<int>(); return canLearnMoves; }
            set { canLearnMoves = value; }
        }


        #endregion

    }

}
