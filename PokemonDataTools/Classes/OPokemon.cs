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
            public string namePokemon;
            public string evolutionType;
            public string need;

            public Evolution(string namePokemon, string evolutionType, string need)
            {
                this.namePokemon = namePokemon;
                this.evolutionType = evolutionType;
                this.need = need;
                
            }
        }

        public struct MoveWillLearnByLevel
        {
            public byte level;
            public string idMove;

            public MoveWillLearnByLevel(byte level, string idMove)
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
        public float Height { get; set; }
        public float Weight { get; set; }
        public Color Color { get; set; }
        public byte Rareness { get; set; }
        public byte Happiness { get; set; }
        public int StepsToHatch { get; set; }
        public bool IsMega { get; set; }
        public bool IsLegendary { get; set; }
        public string[] Abilities { get; set; }
        public string HiddenAbility { get; set; }

        public List<Evolution> Evolutions { get; set; }

        public short ExperienceGives { get; set; }

        private string description;
        private byte[] types;
        private byte[] givedEVs;
        private byte[] baseStats;
        private byte levelType;
        private byte[] eggGroups;
        private byte[] genresPercentage;
        private List<MoveWillLearnByLevel> movesWillLearnByLevel;
        private List<string> eggMoves; //Moves Id. Movements that the pokémon can learn by breeding.

        #endregion

        #region Constructors
        public OPokemon()
        {
            Types = new byte[2] { 0, 0 };
            EggGroups = new byte[2] { 0, 0 };
            EggMoves = new List<string>();
            GivedEVs = new byte[6] { 0, 0, 0, 0, 0, 0 };
            BaseStats = new byte[6] { 0, 0, 0, 0, 0, 0 };
            GenresPercentage = new byte[2] { 0, 0 };
            Abilities = new string[2] { "", ""};
            MovesWillLearnByLevel = new List<MoveWillLearnByLevel>();
            Evolutions = new List<Evolution>();
        }
        #endregion

        #region Methods
        public string Show()
        {
            string pokemonInfo = "\n ||----- " + Name + " -----||" +
            "\n Category: " + Category +
            "\n Description: " + Description +
            "\n Height: " + Height +
            "\n Weight: " + Weight +
            "\n Types: " + PokeType.TypesNames[Types[0]] + " / " + PokeType.TypesNames[Types[1]] +
            "\n\n ---Abilities--- ";

            for (int i = 0; i < Abilities.Length; ++i)
                pokemonInfo += "\n  -Ability" + i + ": " + Abilities[i];

            pokemonInfo += "\n  -Hidden: " + HiddenAbility;

            pokemonInfo +=
            "\n\n ---Base Stats--- " +
            "\n Health: " + BaseStats[PokeStat.Health] +
            "\n Attack: " + BaseStats[PokeStat.Attack] +
            "\n Defense: " + BaseStats[PokeStat.Defense] +
            "\n Special Attack: " + BaseStats[PokeStat.SpecialAttack] +
            "\n Special Defense: " + BaseStats[PokeStat.SpecialDefense] +
            "\n Speed: " + BaseStats[PokeStat.Speed] +

            "\n\n ---Reproduction---" +
            "\n  -Male: " + GenresPercentage[0] +
            "\n  -Female: " + GenresPercentage[1] +
            "\n  -Egg Groups: ";

            for (int i = 0; i < eggGroups.Length; ++i)
            {
                if (i != 0) pokemonInfo += ", " + PokeEggGroup.EggGroupNames[EggGroups[i]];
                else pokemonInfo += PokeEggGroup.EggGroupNames[EggGroups[i]];
            }

            pokemonInfo += "\n\n ---EVs it Gives--- " +
            "\n Health: " + GivedEVs[PokeStat.Health] +
            "\n Attack: " + GivedEVs[PokeStat.Attack] +
            "\n Special Attack: " + GivedEVs[PokeStat.SpecialAttack] +
            "\n Defense: " + GivedEVs[PokeStat.Defense] +
            "\n Special Defense: " + GivedEVs[PokeStat.SpecialDefense] +
            "\n Speed: " + GivedEVs[PokeStat.Speed] +

            "\n\n Level Type: " + PokeLevelType.LevelTypesNames[LevelType] + "\n";

            return pokemonInfo;
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

        public byte[] BaseStats
        {
            get { return baseStats; }
            set
            {
                baseStats = new byte[6] { 0, 0, 0, 0, 0, 0 };

                for (byte i = 0; i < 6; ++i)
                    if (value[i] > 255)
                    {
                        Console.WriteLine("Not valid EVs {0} in position {1}", PokeStat.StatsNames[i], i);
                        return;
                    }
                    else baseStats[i] = value[i];

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

        public byte[] EggGroups
        {
            get
            {
                return eggGroups;
            }
            set {          
                for(int i = 0; i < 2; ++i)
                    if (!(value[i] < 16)) eggGroups = value;

                else Console.WriteLine("Not valid Egg Group value");
            }
        }


        public List<MoveWillLearnByLevel> MovesWillLearnByLevel
        {
            get { if (movesWillLearnByLevel == null) movesWillLearnByLevel = new List<MoveWillLearnByLevel>(); return movesWillLearnByLevel; }
            set { movesWillLearnByLevel = value; }
        }

        public List<string> EggMoves
        {
            get { if (eggMoves == null) eggMoves = new List<string>(); return eggMoves; }
            set { eggMoves = value; }
        }

        #endregion

    }

}
