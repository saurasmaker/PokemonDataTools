using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Classes.Attributes;
using Classes.Tools;
using Tools;

namespace Classes.Lists
{
    public class Pokedex
    {

        #region Attributes
        private static string defaultPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\Saves\\pokedex.xml";

        public string FilePath { get; set; }

        public List<OPokemon> PokemonList { get; set; }
        #endregion

        #region Constructors
        public Pokedex()
        {
            PokemonList = new List<OPokemon>();
        }

        public Pokedex(List<OPokemon> pokemonList)
        {
            this.PokemonList = pokemonList;
        }
        #endregion

        #region CRUD Methods
        public bool AddPokemon(OPokemon pokemon)
        {
            try
            {
                PokemonList.Add(pokemon);
                return true;
            }
            catch (Exception) { return false; }
        }

        public OPokemon SearchPokemon(string name)
        {
            for (int i = 0; i < PokemonList.Count; ++i)
                if (PokemonList[i].Name.ToUpper().Equals(name.ToUpper()))
                    return PokemonList[i];

            return null;
        }

        public bool RemovePokemon(string name)
        {
            for (int i = 0; i < PokemonList.Count; ++i)
                if (PokemonList[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    PokemonList.RemoveAt(i);
                    return true;
                }

            return false;
        }

        public bool UpdatePokemon(string name, OPokemon pokemon)
        {
            for (int i = 0; i < PokemonList.Count; ++i)
                if (PokemonList[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    PokemonList[i] = pokemon;
                    return true;
                }

            return false;
        }

        public string ShowPokemon(string name)
        {
            for (int i = 0; i < PokemonList.Count; ++i)
                if (PokemonList[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    return PokemonList[i].Name;
                }

            return "Pokemon not finded";
        }

        public string ShowAllPokemon()
        {
            string s = "---- Pokédex ----";
            for (int i = 0; i < PokemonList.Count; ++i)
                s = (string)s.Concat("\n -" + PokemonList[i].Id + ") " + PokemonList[i].Name);

            return s;
        }
        #endregion

        #region XML Instance CRUD
        public void Save()
        {
            Console.WriteLine("\n\n Guardando cambios...");

            XDocument doc = XmlTools.CreateXMLDocument();
            XElement root = new XElement("pokedex");

            for (int i = 0; i < PokemonList.Count; ++i)
                root.Add(AddPokemonDataInElement(PokemonList[i], root));

            doc.Add(root);

            doc.Save(FilePath + "\\pokedex.xml");
            
            Debug.WriteLine(File.ReadAllText(FilePath + "\\pokedex.xml"));
            Debug.WriteLine(FilePath + "\\pokedex.xml");                     
        }

        public void Load()
        {
            XDocument doc = XmlTools.GetXMLDocument(FilePath);
            if (doc != null)
            {
                XElement root = doc.Root;

                if (root != null)
                {
                    foreach (XElement e in root.Elements("pokemon"))
                    {
                        try
                        {
                            OPokemon newPoke = LoadDataInPokemon(e);
                            PokemonList.Add(newPoke);
                        }
                        catch (Exception)
                        {
                            Log.Execute("Error to load the data selected in the pokémon.");
                        }
                    }
                }
            }
        }


        #endregion

        #region XML Default CRUD
        public void DefaultSave()
        {
            Console.WriteLine("\n\n Guardando cambios...");
        }

        public static List<OPokemon> DefaultLoad()
        {
            List<OPokemon> pokemon = new List<OPokemon>();

            XDocument doc = XmlTools.GetXMLDocument(defaultPath);
            

            if (doc != null)
            {
                XElement root = doc.Root;

                foreach (XElement e in root.Elements("pokemon"))
                {
                    try
                    {
                        OPokemon newPoke = LoadDataInPokemon(e);
                        pokemon.Add(newPoke);
                    }
                    catch (Exception)
                    {
                        Log.Execute("Was an error loading pokemon in the position");
                    }
                }
            }

            return pokemon;
        }
        #endregion

        #region XML Methods
        private static XElement AddPokemonDataInElement(OPokemon p, XElement root)
        {
            XElement pokemon = new XElement("pokemon");
            pokemon.Add(new XAttribute("id", GenerateId(root)));
            pokemon.Add(new XElement("pokedexNumber", p.PokedexNumber));
            pokemon.Add(new XElement("name", p.Name));
            pokemon.Add(new XElement("category", p.Category));
            pokemon.Add(new XElement("habitat", p.Habitat));
            pokemon.Add(new XElement("description", p.Description));
            pokemon.Add(new XElement("filename", p.FileName));
            pokemon.Add(new XElement("height", p.Height));
            pokemon.Add(new XElement("weight", p.Weight));
            pokemon.Add(new XElement("color", p.Color.Name));
            pokemon.Add(new XElement("rareness", p.Rareness));
            pokemon.Add(new XElement("happiness", p.Happiness));
            pokemon.Add(new XElement("stepsToHatch", p.StepsToHatch));

            pokemon.Add(new XElement("type1", p.Types[0]));
            pokemon.Add(new XElement("type2", p.Types[1]));

            pokemon.Add(new XElement("health", p.BaseStats[PokeStat.Health]));
            pokemon.Add(new XElement("attack", p.BaseStats[PokeStat.Attack]));
            pokemon.Add(new XElement("defense", p.BaseStats[PokeStat.Defense]));
            pokemon.Add(new XElement("specialAttack", p.BaseStats[PokeStat.SpecialAttack]));
            pokemon.Add(new XElement("specialDefense", p.BaseStats[PokeStat.SpecialDefense]));
            pokemon.Add(new XElement("seed", p.BaseStats[PokeStat.Speed]));

            XElement abilities = new XElement("abilities");
            foreach (int a in p.Abilities)
                abilities.Add(new XElement("ability", a));

            pokemon.Add(abilities);
            pokemon.Add(new XElement("hiddenAbility", p.HiddenAbility));

            XElement movesWillLearnByLevel = new XElement("movesWillLearnByLevel");
            for (int i = 0; i < p.MovesWillLearnByLevel.Count; ++i)
            {
                XElement move = new XElement("move",p.MovesWillLearnByLevel[i].IdMove);
                move.Add(new XAttribute("level", p.MovesWillLearnByLevel[i].Level));
                movesWillLearnByLevel.Add(move);
            }
            pokemon.Add(movesWillLearnByLevel);

            XElement genresPercentaje = new XElement("genresPercentage");
            genresPercentaje.Add(new XElement("male", p.GenresPercentage[0]));
            genresPercentaje.Add(new XElement("female", p.GenresPercentage[1]));
            pokemon.Add(genresPercentaje);

            XElement eggMoves = new XElement("eggMoves");
            for (int i = 0; i < p.EggMoves.Count; ++i)
                eggMoves.Add(new XElement("move", p.EggMoves[i]));
            pokemon.Add(eggMoves);

            XElement eggGroups = new XElement("eggGroups");
            for(int i = 0; i < p.EggGroups.Length; ++i)
                eggGroups.Add(new XElement("eggGroup", p.GenresPercentage[i]));
            pokemon.Add(eggGroups);

            pokemon.Add(new XElement("levelType", p.LevelType));
            pokemon.Add(new XElement("isMega", p.IsMega));
            pokemon.Add(new XElement("isLegendary", p.IsLegendary));

            pokemon.Add(new XElement("healthEV", p.GivedEVs[PokeStat.Health]));
            pokemon.Add(new XElement("attackEV", p.GivedEVs[PokeStat.Attack]));
            pokemon.Add(new XElement("defenseEV", p.GivedEVs[PokeStat.Defense]));
            pokemon.Add(new XElement("specialAttackEV", p.GivedEVs[PokeStat.SpecialAttack]));
            pokemon.Add(new XElement("specialDefenseEV", p.GivedEVs[PokeStat.SpecialDefense]));
            pokemon.Add(new XElement("speedEV", p.GivedEVs[PokeStat.Speed]));

            pokemon.Add(new XElement("experienceGives", p.ExperienceGives));

            return pokemon;
        }

        private static OPokemon LoadDataInPokemon(XElement e)
        {
            OPokemon p = new OPokemon();
            p.Id = Convert.ToInt32(e.Attribute("id").Value);
            p.PokedexNumber = Convert.ToInt32(e.Element("pokedexNumber").Value);
            p.Name = e.Element("name").Value;
            p.Category = e.Element("category").Value;
            p.Habitat = e.Element("habitat").Value;
            p.Description = e.Element("description").Value;
            p.FileName = e.Element("name").Value.ToLower();
            p.Height = Convert.ToUInt16(e.Element("height").Value);
            p.Weight = Convert.ToUInt16(e.Element("weight").Value);
            p.Color = Color.FromName(e.Element("color").Value);
            p.Rareness = Convert.ToByte(e.Element("rareness").Value);
            p.Happiness = Convert.ToByte(e.Element("happiness").Value);
            p.StepsToHatch = Convert.ToInt32(e.Element("stepsToHatch").Value);

            p.Types[0] = Convert.ToByte(e.Element("type1").Value);
            p.Types[1] = Convert.ToByte(e.Element("type2").Value);

            p.BaseStats[PokeStat.Health] = Convert.ToByte(e.Element("health").Value);
            p.BaseStats[PokeStat.Attack] = Convert.ToByte(e.Element("attack").Value);
            p.BaseStats[PokeStat.Defense] = Convert.ToByte(e.Element("defense").Value);
            p.BaseStats[PokeStat.SpecialAttack] = Convert.ToByte(e.Element("specialAttack").Value);
            p.BaseStats[PokeStat.SpecialDefense] = Convert.ToByte(e.Element("specialDefense").Value);
            p.BaseStats[PokeStat.Speed] = Convert.ToByte(e.Element("speed").Value);

            List<XElement> abilities = e.Element("abilities").Elements("ability").ToList();
            for (int i = 0; i < abilities.Count; ++i)
                p.Abilities[i] = Convert.ToInt16(abilities[i].Value);

            p.HiddenAbility = Convert.ToInt16(e.Element("hiddenAbility").Value);

            List<XElement> movesWillLearnByLevel = e.Element("movesWillLearnByLevel").Elements("move").ToList();
            for (int i = 0; i < movesWillLearnByLevel.Count; ++i)
            {
                string s = movesWillLearnByLevel[i].Value;
                if (s != null)
                    p.MovesWillLearnByLevel.Add(new OPokemon.MoveWillLearnByLevel(Convert.ToByte(movesWillLearnByLevel[i].Attribute("level").Value), Convert.ToInt16(s)));
            }

            List<XElement> eggMoves = e.Element("eggMoves").Elements("move").ToList();
            for (int i = 0; i < eggMoves.Count; ++i)
                    p.EggMoves.Add(Convert.ToInt16(eggMoves[i].Value));         

            XElement genres = e.Element("genresPercentage");
            p.GenresPercentage[0] = Convert.ToByte(genres.Element("male").Value);
            p.GenresPercentage[1] = Convert.ToByte(genres.Element("female").Value);

            List<XElement> eggGroups = e.Element("eggGroups").Elements("eggGroup").ToList();
            p.EggGroups[0] = Convert.ToByte(eggGroups[0].Value);
            p.EggGroups[1] = Convert.ToByte(eggGroups[1].Value);

            p.LevelType = Convert.ToByte(e.Element("levelType").Value);
            p.IsMega = Convert.ToBoolean(e.Element("isMega").Value);
            p.IsLegendary = Convert.ToBoolean(e.Element("isLegendary").Value);

            p.GivedEVs[PokeStat.Health] = Convert.ToByte(e.Element("healthEV").Value);
            p.GivedEVs[PokeStat.Attack] = Convert.ToByte(e.Element("attackEV").Value);
            p.GivedEVs[PokeStat.SpecialAttack] = Convert.ToByte(e.Element("specialAttackEV").Value);
            p.GivedEVs[PokeStat.Defense] = Convert.ToByte(e.Element("defenseEV").Value);
            p.GivedEVs[PokeStat.SpecialDefense] = Convert.ToByte(e.Element("specialDefenseEV").Value);
            p.GivedEVs[PokeStat.Speed] = Convert.ToByte(e.Element("speedEV").Value);

            p.ExperienceGives = Convert.ToInt16(e.Element("experienceGives").Value);

            return p;
        }

        private static int GenerateId(XElement root)
        {
            IEnumerable<XElement> elements;
            try
            {
                elements = root.Elements();
            }
            catch (NullReferenceException)
            {
                return 0;
            }

            if (elements.Any())
                return (Convert.ToInt32(elements.Last().Attribute("id").Value) + 1);
            else
                return 0;
        }
        #endregion

    }
}
