using Classes;
using Classes.Attributes;
using Classes.Lists;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;


namespace PokemonDataTools.Classes.Tools
{
    class EssentialsTranslator
    {


        #region Lists
        public static Pokedex Pokedex(MovesList mo, AbilitiesList ab, ItemsList it, string path)
        { 
            Pokedex pokedex = new Pokedex();

            string line;

            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                OPokemon p = new OPokemon();
                if (line[0].Equals('['))
                {
                    p.PokedexNumber = Convert.ToInt32(line.Substring(1, 1)[0]);

                    while (!(line = file.ReadLine())[0].Equals('[')) 
                    {
                        string command = line.Split('=')[0];
                        switch (command)
                        {
                            case "Name":
                                p.Name = line.Split('=')[1];
                                break;

                            case "InternalName":
                                break;

                            case "Type1":
                                for (byte i = 0; i < PokeType.TypesNames.Length; ++i)
                                    if (line.Split('=')[1].ToUpper().Equals(PokeType.TypesNames[i].ToUpper()))
                                    {
                                        p.Types[0] = i;
                                        break;
                                    }
                                break;

                            case "Type2":
                                for (byte i = 0; i < PokeType.TypesNames.Length; ++i)
                                    if (line.Split('=')[1].ToUpper().Equals(PokeType.TypesNames[i].ToUpper()))
                                    {
                                        p.Types[1] = i;
                                        break;
                                    }
                                break;

                            case "BaseStats":
                                string[] stats = line.Split('=')[1].Split(',');
                                p.BaseStats[PokeStat.Health] = Convert.ToByte(stats[PokeStat.Health]);
                                p.BaseStats[PokeStat.Attack] = Convert.ToByte(stats[PokeStat.Attack]);
                                p.BaseStats[PokeStat.Defense] = Convert.ToByte(stats[PokeStat.Defense]);
                                p.BaseStats[PokeStat.SpecialAttack] = Convert.ToByte(stats[PokeStat.SpecialAttack]);
                                p.BaseStats[PokeStat.SpecialDefense] = Convert.ToByte(stats[PokeStat.SpecialDefense]);
                                p.BaseStats[PokeStat.Speed] = Convert.ToByte(stats[PokeStat.Speed]);
                                break;

                            case "GenderRate":
                                string genreRate = line.Split('=')[1];
                                
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
                                break;

                            case "GrowthRate":
                                string growthRate = line.Split('=')[1];
                                for (byte i = 0; i < PokeLevelType.LevelTypesNames.Length; ++i)
                                    if (PokeLevelType.LevelTypesNames[i].ToUpper().Equals(growthRate.ToUpper()))
                                        p.LevelType = i;
                                break;

                            case "BaseEXP":
                                p.ExperienceGives = Convert.ToInt16(line.Split('=')[1]);
                                break;

                            case "EffortPoints":
                                string[] effortPoints = line.Split('=')[1].Split(',');
                                p.GivedEVs[PokeStat.Health] = Convert.ToByte(effortPoints[PokeStat.Health]);
                                p.GivedEVs[PokeStat.Attack] = Convert.ToByte(effortPoints[PokeStat.Attack]);
                                p.GivedEVs[PokeStat.Defense] = Convert.ToByte(effortPoints[PokeStat.Defense]);
                                p.GivedEVs[PokeStat.SpecialAttack] = Convert.ToByte(effortPoints[PokeStat.SpecialAttack]);
                                p.GivedEVs[PokeStat.SpecialDefense] = Convert.ToByte(effortPoints[PokeStat.SpecialDefense]);
                                p.GivedEVs[PokeStat.Speed] = Convert.ToByte(effortPoints[PokeStat.Speed]);
                                break;

                            case "Rareness":
                                p.Rareness = Convert.ToByte(line.Split('=')[1]);
                                break;

                            case "Happiness":
                                p.Happiness = Convert.ToByte(line.Split('=')[1]);
                                break;

                            case "Abilities":

                                if (ab != null)
                                {
                                    string abilities = line.Split('=')[1];
                                    string[] splitedAbilities = abilities.Split(',');

                                    if (splitedAbilities.Length > 1)
                                        splitedAbilities = abilities.Split(',');
                                    else splitedAbilities[0] = abilities;

                                    for (byte i = 0; i < abilities.Length; ++i)
                                        for (int j = 0; j < ab.Abilities.Count; ++j)
                                            if (ab.Abilities[i].Name.ToUpper().Equals(splitedAbilities[i].ToUpper()))
                                            {
                                                p.Abilities[i] = ab.Abilities[i].Id;
                                                break;
                                            }
                                }
                                break;

                            case "HiddenAbility":

                                if (ab != null)
                                {
                                    for (int i = 0; i < ab.Abilities.Count; ++i)
                                        if (ab.Abilities[i].Name.ToUpper().Equals(line.Split('=')[1].ToUpper()))
                                        {
                                            p.HiddenAbility = ab.Abilities[i].Id;
                                            break;
                                        }
                                }
                                break;

                            case "Moves":
                                if (mo != null)
                                {
                                    string[] moves = line.Split('=')[1].Split(',');
                                    for (int i = 0; i < moves.Length; ++i)
                                    {
                                        OPokemon.MoveWillLearnByLevel m = new OPokemon.MoveWillLearnByLevel();
                                        m.level = Convert.ToByte(moves[i]);
                                        m.idMove = moves[++i];
                                        p.MovesWillLearnByLevel.Add(m);
                                    }
                                }
                                break;

                            case "EggMoves":
                                if (mo != null)
                                {
                                    string[] eggMoves = line.Split('=')[1].Split(',');
                                    for (byte i = 0; i < eggMoves.Length; ++i)
                                        p.EggMoves.Add(eggMoves[i]);
                                }
                                break;

                            case "Compatibility":
                                string[] eggGroups = line.Split('=')[1].Split(',');
                                for (byte i = 0; i < eggGroups.Length; ++i)
                                    for (byte j = 0; j < PokeEggGroup.EggGroupNames.Length; ++j)
                                    {
                                        if (PokeEggGroup.EggGroupNames[j].ToUpper().Equals(eggGroups[i].ToUpper()))
                                        {
                                            p.EggGroups[i] = j;
                                            break;
                                        }
                                    }
                                break;

                            case "StepsToHatch":
                                p.StepsToHatch = Convert.ToInt32(line.Split('=')[1]);
                                break;

                            case "Height":
                                p.Height = Convert.ToSingle(line.Split('=')[1]);
                                break;

                            case "Weight":
                                p.Weight = Convert.ToSingle(line.Split('=')[1]);
                                break;

                            case "Color":
                                p.Color = Color.FromName(line.Split('=')[1]);
                                break;

                            case "Habitat":
                                p.Habitat = line.Split('=')[1];
                                break;

                            case "Kind":
                                p.Category = line.Split('=')[1];
                                break;

                            case "Pokedex":
                                p.Description = line.Split('=')[1];
                                break;

                            case "WildItemCommon":
                                if (it != null)
                                {
                                    string wildItem1 = line.Split('=')[1];
                                    OPokemon.WildItem item1 = new OPokemon.WildItem();
                                    for (int i = 0; i < it.Items.Count; ++i)
                                        if (it.Items[i].Name.ToUpper().Equals(wildItem1.ToUpper()))
                                        {
                                            item1.probabilityPercentage = 50;
                                            item1.itemId = it.Items[i].Id;
                                            break;
                                        }

                                    p.WildItems.Add(item1);
                                }
                                break;

                            case "WildItemUncommon":
                                if (it != null)
                                {
                                    string wildItem2 = line.Split('=')[1];
                                    OPokemon.WildItem item2 = new OPokemon.WildItem();
                                    for (int i = 0; i < it.Items.Count; ++i)
                                        if (it.Items[i].Name.ToUpper().Equals(wildItem2.ToUpper()))
                                        {
                                            item2.probabilityPercentage = 5;
                                            item2.itemId = it.Items[i].Id;
                                            break;
                                        }

                                    p.WildItems.Add(item2);
                                }
                                break;

                            case "WildItemRare":
                                if (it != null)
                                {
                                    string wildItem3 = line.Split('=')[1];
                                    OPokemon.WildItem item3 = new OPokemon.WildItem();
                                    for (int i = 0; i < it.Items.Count; ++i)
                                        if (it.Items[i].Name.ToUpper().Equals(wildItem3.ToUpper()))
                                        {
                                            item3.probabilityPercentage = 5;
                                            item3.itemId = it.Items[i].Id;
                                            break;
                                        }

                                    p.WildItems.Add(item3);
                                }
                                break;

                            case "Evolutions":
                                string[] evolutions = line.Split('=')[1].Split(',');
                                try
                                {
                                    for (int i = 0; i < evolutions.Length; ++i)
                                    {
                                        OPokemon.Evolution e = new OPokemon.Evolution
                                        {
                                            namePokemon = evolutions[i],
                                            evolutionType = evolutions[i++],
                                            need = evolutions[i++]
                                        };
                                        p.Evolutions.Add(e);
                                    }
                                }
                                catch (Exception)
                                {

                                }
                                break;
                        }     
                    }
                }
                if (p.Name != null)
                {
                    pokedex.AddPokemon(p);
                    //Debug.WriteLine(p.Show());
                }
            }

            file.Close();
            //System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            //System.Console.ReadLine();

            return pokedex;
        }

        public static MovesList MovesList(string path)
        {
            MovesList moves = new MovesList();

            string line;

            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                PokeMove p = new PokeMove();
                string[] attributes = line.Split(',');
                p.Id = Convert.ToInt32(attributes[0]);
                p.Name = attributes[2];
                p.EffectCode = attributes[3];
                p.Power = Convert.ToSByte(attributes[4]);
                
                for(byte i = 0; i < PokeType.TypesNames.Length; ++i)
                    if (PokeType.TypesNames[i].ToUpper().Equals(attributes[5]))
                    {
                        p.Type = i;
                        break;
                    }

                for(byte i = 0; i < PokeMove.CategoryNames.Length; ++i)
                    if (PokeMove.CategoryNames[i].ToUpper().Equals(attributes[6]))
                    {
                        p.Category = i;
                        break;
                    }

                p.Accuracy = Convert.ToByte(attributes[7]);
                p.PP = Convert.ToByte(attributes[8]);
                p.EffectProbability = Convert.ToByte(attributes[9]);

                switch (attributes[10])
                {//En desarrollo
                    case "00":
                        p.Target = PokeMove.TargetAllPokemon;
                        break;
                }

                p.Priority = Convert.ToByte(attributes[11]);

                for (int i = 13; i < attributes.Length - 13; ++i)
                    p.Description += attributes[i];

                if (p.Name != null)
                    moves.AddPokeMove(p);
            }

            return moves;
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
