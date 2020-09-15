using System;
using System.Collections.Generic;
using Classes.Attributes;

namespace Classes
{
    class FreePokemon : OPokemon
    {
        #region Attributes

        private byte genre;
        private byte nature;
        private byte ability;
        private byte[] iVs;

        private int[] actualMoves; //Moves Id. Four movements that the pokémon has actually.
        private List<int> learnedMoves; //Moves Id. Movements that the pokémon has learned throughout its life.

        public byte Level { get; set; }
        public bool Shiny { get; set; }
        public string Nickname { get; set; }

        #endregion


        #region Constructors
        public FreePokemon()
        {
            IVs = new byte[PokeStat.StatsNames.Length];
        }

        #endregion



        #region Getters & Setters
        public byte[] IVs
        {
            get { return iVs; }
            set
            {
                for (byte i = 0; 0 < 5; ++i)
                    if (value[i] > 255)
                    {
                        Console.WriteLine("Not valid EVs {0} in position {1}", PokeStat.StatsNames[i], i);
                        return;
                    }
                    else iVs[i] = value[i];

            }
        }

        public byte Genre
        {
            get { return genre; }
            set
            {
                if (value < 3) genre = value;
                else genre = 0;
            }
        }
        public byte Nature
        {
            get { return nature; }
            set
            {
                if (value < 25) nature = value;
                else nature = 0;
            }
        }

        public byte Ability
        {
            get { return ability; }
            set
            {
                if (value < 3) ability = value;
                else ability = 0;
            }
        }

        public int[] ActualMoves
        {
            get { if (actualMoves == null) actualMoves = new int[4]; return actualMoves; }
            set { actualMoves = value; }
        }

        public List<int> LearnedMoves
        {
            get { if (learnedMoves == null) learnedMoves = new List<int>(); return learnedMoves; }
            set { learnedMoves = value; }
        }

        #endregion


        #region static Methods

        public static FreePokemon GenerateFreePokemon(string map)
        {
            FreePokemon fp = new FreePokemon();



            return fp;
        }


        #endregion
    }
}
