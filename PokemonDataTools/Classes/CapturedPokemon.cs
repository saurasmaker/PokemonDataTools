using System;
using Classes.Attributes;

namespace Classes
{
    class CapturedPokemon : FreePokemon
    {
        #region Attributes
        private byte[] eVs;

        public ulong Experience { get; set; }
        public byte Pokeball { get; set; }

        #endregion

        #region Constructors
        public CapturedPokemon()
        {
            eVs = new byte[PokeStat.StatsNames.Length];
        }

        #endregion


        #region Getters & Setters
        public byte[] EVs
        {
            get { return eVs; }
            set
            {
                for (byte i = 0; 0 < 5; ++i)
                    if (value[i] > 255)
                    {
                        Console.WriteLine("Not valid EVs {0} in position {1}", PokeStat.StatsNames[i], i);
                        return;
                    }
                    else eVs[i] = value[i];

            }
        }

        #endregion


        #region LevelCalculator
        public byte LevelCalculator(byte lvlType)
        {
            byte level;

            switch (lvlType)
            {
                case 0:
                    level = FastLevelCalculator();
                    break;
                case 1:
                    level = MediumLevelCalculator();
                    break;
                case 2:
                    level = SlowLevelCalculator();
                    break;
                case 3:
                    level = ParabolicLevelCalculator();
                    break;
                case 4:
                    level = ErraticLevelCalculator();
                    break;
                case 5:
                    level = FluctuatingLevelCalculator();
                    break;
                default:
                    level = 1;
                    break;
            }
            return level;
        }

        private byte FastLevelCalculator() //Fórmula: E = 4 * n^3 / 5
        {
            byte newLevel = (byte)(Level + 1);
            ulong newExp = Experience;

            if ((newExp -= (ulong)(Math.Pow(newLevel, 3) * 4 / 5)) <= 0)
            {
                Experience = newExp;
                return newLevel;
            }

            return Level;
        }

        private byte MediumLevelCalculator() //Fórmula: E = n^3
        {
            byte newLevel = (byte)(Level + 1);
            ulong newExp = Experience;

            if ((newExp -= (ulong)Math.Pow(Level + 1, 3)) <= 0)
            {
                Experience = newExp;
                return newLevel;
            }

            return Level;
        }

        private byte SlowLevelCalculator() //Fórmula: E = 5 * n^3 / 4
        {
            byte newLevel = (byte)(Level + 1);
            ulong newExp = Experience;

            if ((newExp -= (ulong)Math.Pow(newLevel, 3) * 5 / 4) <= 0)
            {
                Experience = newExp;
                return newLevel;
            }

            return Level;
        }

        private byte ParabolicLevelCalculator() //Fórmula: E = 6/5*n^3 − 15*n^2 + 100*n − 140
        {
            byte newLevel = (byte)(Level + 1);
            ulong newExp = Experience;

            if ((newExp -= (ulong)((6 / 5 * Math.Pow(newLevel, 3)) - (15 * Math.Pow(newLevel, 2)) + (100 * newLevel) - 140)) <= 0)
            {
                Experience = newExp;
                return newLevel;
            }

            return Level;
        }

        private byte ErraticLevelCalculator()
        {
            byte newLevel = (byte)(Level + 1);
            ulong newExp = Experience;

            if (0 < Level && Level <= 50)
            {
                if ((newExp -= (ulong)(Math.Pow(newLevel, 3) * (2 - (0.02 * newLevel)))) <= 0)
                {
                    Experience = newExp;
                    return newLevel;
                }
            }

            else if (51 <= Level && Level <= 68)
            {
                if ((newExp -= (ulong)(Math.Pow(newLevel, 3) * (1.5 - (0.01 * newLevel)))) <= 0)
                {
                    Experience = newExp;
                    return newLevel;
                }
            }

            else if (69 <= Level && Level <= 98)
            {
                if ((newExp -= (ulong)(Math.Pow(newLevel, 3) * (1.274 - (0.02 * newLevel / 3) - (newLevel % 3)))) <= 0)
                {
                    Experience = newExp;
                    return newLevel;
                }
            }

            else if (99 <= Level && Level <= 100)
            {
                if ((newExp -= (ulong)(Math.Pow(newLevel, 3) * (1.6 - (0.01 * newLevel)))) <= 0)
                {
                    Experience = newExp;
                    return newLevel;
                }
            }

            return Level;
        }

        private byte FluctuatingLevelCalculator()
        {
            byte newLevel = (byte)(Level + 1);
            ulong newExp = Experience;

            if (0 < Level && Level <= 15)
            {
                if ((newExp -= (ulong)(Math.Pow(newLevel, 3) * ((24 + ((newLevel + 1) / 3)) / 50))) <= 0)
                {
                    Experience = newExp;
                    return newLevel;
                }
            }

            else if (16 <= Level && Level <= 35)
            {
                if ((newExp -= (ulong)(Math.Pow(newLevel, 3) * ((14 + newLevel) / 50))) <= 0)
                {
                    Experience = newExp;
                    return newLevel;
                }
            }

            else if (36 <= Level && Level <= 100)
            {
                if ((newExp -= (ulong)(Math.Pow(newLevel, 3) * ((32 + (newLevel / 2)) / 50))) <= 0)
                {
                    Experience = newExp;
                    return newLevel;
                }
            }

            return Level;
        }
        #endregion
    }
}
