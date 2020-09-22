using Classes;
using Classes.Attributes;
using Classes.Lists;
using System;
using System.Drawing;
using System.IO;


namespace PokemonDataTools.Classes.Tools
{
    class EssentialsTranslator
    {


        #region Lists
        public static Pokedex Pokedex(string path)
        {
            /*
             * Gender rate
             * AlwaysMale
             * FemaleOneEighth
             * Female25Percent
             * Female50Percent
             * Female75Percent
             * FemaleSevenEighths
             * AlwaysFemale
             * GenderLess
             */

            Pokedex pokedex = new Pokedex();

            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                OPokemon p = new OPokemon();
                if (line[0].Equals('['))
                {                 
                    p.PokedexNumber = Convert.ToInt32(line.Substring(1,1)[0]);
                    p.Name = file.ReadLine().Split('=')[1];

                    file.ReadLine();
                    string type1 = file.ReadLine().Split('=')[1];
                    string[] type2 = file.ReadLine().Split('=');
                    for (byte i = 0; i < PokeType.TypesNames.Length; ++i)
                        if (PokeType.TypesNames[i].ToUpper().Equals(type1.ToUpper()))
                            p.Types[0] = i;

                    if (type2[0].Equals("Type2"))
                    {
                        for (byte i = 0; i < PokeType.TypesNames.Length; ++i)
                            if (PokeType.TypesNames[i].ToUpper().Equals(type2[1].ToUpper()))
                                p.Types[1] = i;

                        string[] stats = file.ReadLine().Split('=')[1].Split(',');
                        p.BaseStats[PokeStat.Health] = Convert.ToByte(stats[PokeStat.Health]);
                        p.BaseStats[PokeStat.Attack] = Convert.ToByte(stats[PokeStat.Attack]);
                        p.BaseStats[PokeStat.Defense] = Convert.ToByte(stats[PokeStat.Defense]);
                        p.BaseStats[PokeStat.SpecialAttack] = Convert.ToByte(stats[PokeStat.SpecialAttack]);
                        p.BaseStats[PokeStat.SpecialDefense] = Convert.ToByte(stats[PokeStat.SpecialDefense]);
                        p.BaseStats[PokeStat.Speed] = Convert.ToByte(stats[PokeStat.Speed]);
                    }
                    else
                    {
                        string[] stats = type2[1].Split(',');
                        p.BaseStats[PokeStat.Health] = Convert.ToByte(stats[PokeStat.Health]);
                        p.BaseStats[PokeStat.Attack] = Convert.ToByte(stats[PokeStat.Attack]);
                        p.BaseStats[PokeStat.Defense] = Convert.ToByte(stats[PokeStat.Defense]);
                        p.BaseStats[PokeStat.SpecialAttack] = Convert.ToByte(stats[PokeStat.SpecialAttack]);
                        p.BaseStats[PokeStat.SpecialDefense] = Convert.ToByte(stats[PokeStat.SpecialDefense]);
                        p.BaseStats[PokeStat.Speed] = Convert.ToByte(stats[PokeStat.Speed]);
                    }

                    string genreRate = file.ReadLine().Split('=')[1];
                    switch (genreRate.ToUpper())
                    {
                        case "ALWAYSMALE":
                            p.GenresPercentage[0] = 100;
                            p.GenresPercentage[1] = 0;
                            break;

                        case "FEMALEONEEIGHTH":
                            p.GenresPercentage[0] = 85;
                            p.GenresPercentage[1] = 15;
                            break;

                        case "FEMALE25PERVENT":
                            p.GenresPercentage[0] = 75;
                            p.GenresPercentage[1] = 25;
                            break;

                        case "FEMALE50PERCENT":
                            p.GenresPercentage[0] = 50;
                            p.GenresPercentage[1] = 50;
                            break;

                        case "FEMALE75PERCENT":
                            p.GenresPercentage[0] = 25;
                            p.GenresPercentage[1] = 75;
                            break;

                        case "FEMALESEVENEIGHTHS":
                            p.GenresPercentage[0] = 15;
                            p.GenresPercentage[1] = 85;
                            break;

                        case "ALWAYSFEMALE":
                            p.GenresPercentage[0] = 0;
                            p.GenresPercentage[1] = 100;
                            break;

                        case "GENDERLESS":
                            p.GenresPercentage[0] = 0;
                            p.GenresPercentage[1] = 0;
                            break;

                        default:
                            break;

                    }

                    string growthRate = file.ReadLine().Split('=')[1];
                    for (byte i = 0; i < PokeLevelType.LevelTypesNames.Length; ++i)
                        if (PokeLevelType.LevelTypesNames[i].ToUpper().Equals(growthRate.ToUpper()))
                            p.LevelType = i;

                    p.ExperienceGives = Convert.ToInt16(file.ReadLine().Split('=')[1]);

                    string[] effortPoints = file.ReadLine().Split('=')[1].Split(',');
                    p.GivedEVs[PokeStat.Health] = Convert.ToByte(effortPoints[PokeStat.Health]);
                    p.GivedEVs[PokeStat.Attack] = Convert.ToByte(effortPoints[PokeStat.Attack]);
                    p.GivedEVs[PokeStat.Defense] = Convert.ToByte(effortPoints[PokeStat.Defense]);
                    p.GivedEVs[PokeStat.SpecialAttack] = Convert.ToByte(effortPoints[PokeStat.SpecialAttack]);
                    p.GivedEVs[PokeStat.SpecialDefense] = Convert.ToByte(effortPoints[PokeStat.SpecialDefense]);
                    p.GivedEVs[PokeStat.Speed] = Convert.ToByte(effortPoints[PokeStat.Speed]);

                    p.Rareness = Convert.ToByte(file.ReadLine().Split('=')[1]);
                    p.Happiness = Convert.ToByte(file.ReadLine().Split('=')[1]);

                    string[] abilities = file.ReadLine().Split('=')[1].Split(',');
                    for (byte i = 0; i < abilities.Length; ++i)
                        for (short j = 0; j < PokeAbility.AbilitiesNames.Length; ++j)
                            if(abilities[i].ToUpper().Equals(PokeAbility.AbilitiesNames[j].ToUpper()))
                                p.Abilities[i] = abilities[j];

                    string isHiddenAbility = file.ReadLine();
                    if (isHiddenAbility.Split('=')[0].Equals("HiddenAbility"))
                    {
                        string hiddenAbility = isHiddenAbility.Split('=')[1];
                        for (short j = 0; j < PokeAbility.AbilitiesNames.Length; ++j)
                            if (hiddenAbility.ToUpper().Equals(PokeAbility.AbilitiesNames[j].ToUpper()))
                                p.Abilities[2] = abilities[j];

                        string[] moves = file.ReadLine().Split('=')[1].Split(',');
                        for (int i = 0; i < moves.Length; ++i)
                        {
                            OPokemon.MoveWillLearnByLevel m = new OPokemon.MoveWillLearnByLevel();
                            m.level = Convert.ToByte(moves[i]);
                            m.idMove = moves[++i];
                            p.MovesWillLearnByLevel.Add(m);
                        }
                    }
                    else
                    {
                        string[] moves = isHiddenAbility.Split('=')[1].Split(',');
                        for (int i = 0; i < moves.Length; ++i)
                        {
                            OPokemon.MoveWillLearnByLevel m = new OPokemon.MoveWillLearnByLevel();
                            m.level = Convert.ToByte(moves[i]);
                            m.idMove = moves[++i];
                            p.MovesWillLearnByLevel.Add(m);
                        }
                    }
                    

                    string isEggMoves = file.ReadLine();
                    string[] eggGroups;
                    if (isEggMoves.Split('=')[0].Equals("EggMoves"))
                    {
                        string[] eggMoves = isEggMoves.Split('=')[1].Split(',');
                        for (byte i = 0; i < eggMoves.Length; ++i)
                            p.EggMoves.Add(eggMoves[i]);

                        eggGroups = file.ReadLine().Split('=')[1].Split(',');
                        for (byte i = 0; i < eggGroups.Length; ++i)
                            for (byte j = 0; j < PokeEggGroup.EggGroupNames.Length; ++j)
                                if (PokeEggGroup.EggGroupNames[i].ToUpper().Equals(eggGroups))
                                    p.EggGroups[i] = j;
                    }
                    else if(isEggMoves.Split('=')[0].Equals("Compatibility"))
                    {
                        eggGroups = isEggMoves.Split('=')[1].Split(',');

                        for (byte i = 0; i < eggGroups.Length; ++i)
                            for (byte j = 0; j < PokeEggGroup.EggGroupNames.Length; ++j)
                                if (PokeEggGroup.EggGroupNames[i].ToUpper().Equals(eggGroups))
                                    p.EggGroups[i] = j;
                    }
                    

                    p.StepsToHatch = Convert.ToInt32(file.ReadLine().Split('=')[1]);                        
                    p.Height = Convert.ToSingle(file.ReadLine().Split('=')[1]);
                    p.Weight = Convert.ToSingle(file.ReadLine().Split('=')[1]);
                    p.Color = Color.FromName(file.ReadLine().Split('=')[1]);
                    
                    string isHabitat = file.ReadLine();
                    if (isHabitat.Split('=')[0].Equals("Habitat"))
                    {
                        p.Habitat = isHabitat.Split('=')[1];
                        p.Category = file.ReadLine().Split('=')[1];
                    }
                    else
                    {
                        p.Category = isHabitat.Split('=')[1];

                    }
                    p.Description = file.ReadLine().Split('=')[1];

                    file.ReadLine();
                    file.ReadLine();
                    file.ReadLine();

                    string[] evolutions = file.ReadLine().Split('=')[1].Split(',');
                    try
                    {
                        for (int i = 0; i < evolutions.Length; ++i)
                        {
                            OPokemon.Evolution e = new OPokemon.Evolution
                            {
                                namePokemon = evolutions[i],
                                evolutionType = evolutions[++i],
                                need = evolutions[++i]
                            };
                            p.Evolutions.Add(e);
                        }
                    }
                    catch (Exception)
                    {

                    }  
                }
                System.Console.WriteLine(line);
                counter++;
                if(p.Name != null)
                    pokedex.AddPokemon(p);
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();

            return pokedex;
        }

        public static MovesList MovesList(string path)
        {

            return null;
        }

        public static AbilitiesList AbilitiesList(string path)
        {


            return null;
        }

        public static ItemsList ItemsList(string path)
        {

            return null;
        }
        #endregion


        #region Singular
        public static OPokemon Pokemon(string path)
        {

            return null;
        }

        public static PokeMove Move(string path)
        {

            return null;
        }

        public static PokeAbility Ability(string path)
        {

            return null;
        }

        public static PokeItem Item(string path)
        {

            return null;
        }
        #endregion
    }
}
