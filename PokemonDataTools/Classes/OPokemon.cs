using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Classes.Attributes;
using Classes.Lists;

namespace Classes
{
    public class OPokemon
    {
        public struct Evolution
        {
            public string PokemonName{get; set;}
            public string EvolutionType { get; set;}
            public string ItNeeds{get; set;}

            public Evolution(string pokemonName, string evolutionType, string itNeeds)
            {
                PokemonName = pokemonName;
                EvolutionType = evolutionType;
                ItNeeds = itNeeds;
                
            }
        }

        public struct WildItem
        {
            public int ItemId { get; set; }
            public int ProbabilityPercentage { get; set; }
        }

        public struct MoveWillLearnByLevel
        {
            public byte Level { get; set; }
            public int IdMove { get; set; }

            public MoveWillLearnByLevel(byte level, int idMove)
            {
                Level = level;
                IdMove = idMove;
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
        public int[] Abilities { get; set; }
        public int HiddenAbility { get; set; }

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
        private List<WildItem> wildItems;
        private List<int> eggMoves; //Moves Id. Movements that the pokémon can learn by breeding.

        #endregion

        #region Constructors
        public OPokemon()
        {
            Types = new byte[2] { 0, 0 };
            EggGroups = new byte[2] { 0, 0 };
            EggMoves = new List<int>();
            GivedEVs = new byte[6] { 0, 0, 0, 0, 0, 0 };
            BaseStats = new byte[6] { 0, 0, 0, 0, 0, 0 };
            GenresPercentage = new byte[2] { 0, 0 };
            Abilities = new int[2] { 0, 0};
            MovesWillLearnByLevel = new List<MoveWillLearnByLevel>();
            WildItems = new List<WildItem>();
            Evolutions = new List<Evolution>();
        }
        #endregion

        #region Methods
        public string Show(MovesList movesList, AbilitiesList abilitiesList, ItemsList itemsList)
        {
            StringBuilder pokemonInfo = new StringBuilder();
                
            pokemonInfo.Append("\n ||----- " + Name + " -----||" +
            "\n Category: " + Category +
            "\n Description: " + Description +
            "\n Height: " + Height +
            "\n Weight: " + Weight +
            "\n Types: " + PokeType.TypesNames[Types[0]] + " / " + PokeType.TypesNames[Types[1]] +
            "\n\n ---Abilities--- ");

            for (int i = 0; i < Abilities.Length; ++i)
                for (int j = 0; j < abilitiesList.Abilities.Count; ++j)
                    if (abilitiesList.Abilities[j].Id.Equals(Abilities[i]))
                        pokemonInfo.Append("\n  -Ability " + (i+1) + ": " + abilitiesList.Abilities[j].Name);

            for (int i = 0; i < abilitiesList.Abilities.Count; ++i)
                if (abilitiesList.Abilities[i].Id.Equals(HiddenAbility))
                    pokemonInfo.Append("\n  -Hidden: " + abilitiesList.Abilities[i].Name);

            pokemonInfo.Append(
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
            "\n  -Egg Groups: ");

            for (int i = 0; i < eggGroups.Length; ++i)
            {
                if (i != 0) pokemonInfo.Append(", " + PokeEggGroup.EggGroupNames[EggGroups[i]]);
                else pokemonInfo.Append(PokeEggGroup.EggGroupNames[EggGroups[i]]);
            }

            pokemonInfo.Append("\n\n ---Moves---");
            for (int i = 0; i < movesWillLearnByLevel.Count; ++i)
                for(int j = 0; j < movesList.Moves.Count; ++j)
                    if(movesList.Moves[j].Id.Equals(movesWillLearnByLevel[i].IdMove))
                        pokemonInfo.Append("\n  -" + movesList.Moves[j].Name + " (lvl " + movesWillLearnByLevel[i].Level + ")");

            if (eggMoves.Count > 0)
            {
                pokemonInfo.Append("\n\n ---Egg Moves---");
                for (int i = 0; i < eggMoves.Count; ++i)
                    for (int j = 0; j < movesList.Moves.Count; ++j)
                        if (movesList.Moves[j].Id.Equals(eggMoves[i]))
                            pokemonInfo.Append("\n  -" + movesList.Moves[j].Name);
            }

            pokemonInfo.Append("\n\n ---EVs it Gives--- " +
            "\n Health: " + GivedEVs[PokeStat.Health] +
            "\n Attack: " + GivedEVs[PokeStat.Attack] +
            "\n Special Attack: " + GivedEVs[PokeStat.SpecialAttack] +
            "\n Defense: " + GivedEVs[PokeStat.Defense] +
            "\n Special Defense: " + GivedEVs[PokeStat.SpecialDefense] +
            "\n Speed: " + GivedEVs[PokeStat.Speed] +

            "\n\n Level Type: " + PokeLevelType.LevelTypesNames[LevelType] + "\n");

            if (Evolutions.Count > 0)
            {
                pokemonInfo.Append("\n\n ---Evolution---");
                for (int i = 0; i < Evolutions.Count; ++i)
                    pokemonInfo.Append("\n\n Pokemon: " + Evolutions[i].PokemonName +
                    "\n Kind: " + Evolutions[i].EvolutionType +
                    "\n Need: " + Evolutions[i].ItNeeds);
            }

            return pokemonInfo.ToString();
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
                for (int i = 0; i < 2; ++i) {
                    if (value[i] < 16) eggGroups = value;
                    else Console.WriteLine("Not valid Egg Group value");
                }

                
            }
        }


        public List<MoveWillLearnByLevel> MovesWillLearnByLevel
        {
            get { if (movesWillLearnByLevel == null) movesWillLearnByLevel = new List<MoveWillLearnByLevel>(); return movesWillLearnByLevel; }
            set { movesWillLearnByLevel = value; }
        }

        public List<WildItem> WildItems
        {
            get { if (wildItems == null) wildItems = new List<WildItem>(); return wildItems; }
            set { wildItems = value; }
        }

        public List<int> EggMoves
        {
            get { if (eggMoves == null) eggMoves = new List<int>(); return eggMoves; }
            set { eggMoves = value; }
        }

        #endregion

    }

}
