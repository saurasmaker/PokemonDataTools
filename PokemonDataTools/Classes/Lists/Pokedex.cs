using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml.Linq;
using Classes.Attributes;
using Classes.Tools;

namespace Classes.Lists
{
    public class Pokedex
    {

        #region Attributes
        private static string defaultPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\Saves\\pokedex.xml";
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set
            {
                filePath = value + "\\pokedex.xml";
            }
        }
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
                s += ("\n -" + PokemonList[i].Id + ") " + PokemonList[i].Name);

            return s;
        }
        #endregion

        #region XML Instance CRUD
        public void Save()
        {
            Console.WriteLine("\n\n Guardando cambios...");

            XDocument doc = XMLTools.CreateXMLDocument();
            XElement root = new XElement("pokedex");

            for (int i = 0; i < PokemonList.Count; ++i)
                root.Add(AddPokemonDataInElement(PokemonList[i], root));

            doc.Add(root);

            doc.Save(FilePath);
            return;
        }

        public void Load()
        {
            XDocument doc = XMLTools.GetXMLDocument(FilePath);
            XElement root = doc.Root;

            if (doc != null)
            {
                foreach (XElement e in root.Elements("pokemon"))
                {
                    //try
                    {
                        OPokemon newPoke = LoadDataInPokemon(e);
                        PokemonList.Add(newPoke);
                    }
                    //catch (Exception)
                    {
                    }
                }
            }
            return;
        }


        #endregion

        #region XML Default CRUD
        public void DefaultSave()
        {
            Console.WriteLine("\n\n Guardando cambios...");

            return;
        }

        public static List<OPokemon> DefaultLoad()
        {
            List<OPokemon> pokemon = new List<OPokemon>();

            XDocument doc = XMLTools.GetXMLDocument(defaultPath);
            XElement root = doc.Root;

            if (doc != null)
            {
                foreach (XElement e in root.Elements("pokemon"))
                {
                    try
                    {
                        OPokemon newPoke = LoadDataInPokemon(e);
                        pokemon.Add(newPoke);
                    }
                    catch (Exception)
                    {
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
            pokemon.Add(new XElement("name", p.Name));
            pokemon.Add(new XElement("description", p.Description));


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
            p.FileName = e.Element("fileName").Value;
            p.Description = e.Element("description").Value;
            p.FileName = e.Element("fileName").Value;
            p.Height = Convert.ToUInt16(e.Element("height").Value);
            p.Weight = Convert.ToUInt16(e.Element("weight").Value);
            p.Color = Color.FromName(e.Element("color").Value);
            p.Rareness = Convert.ToByte(e.Element("rareness").Value);
            p.Happiness = Convert.ToByte(e.Element("happiness").Value);
            p.StepsToHatch = Convert.ToInt32(e.Element("stepsToHatch").Value);

            p.Types[0] = Convert.ToByte(e.Element("type1").Value);
            p.Types[0] = Convert.ToByte(e.Element("type2").Value);

            p.Health = Convert.ToByte(e.Element("health").Value);
            p.Attack = Convert.ToByte(e.Element("attack").Value);
            p.SpecialAttack = Convert.ToByte(e.Element("specialAttack").Value);
            p.Defense = Convert.ToByte(e.Element("defense").Value);
            p.SpecialDefense = Convert.ToByte(e.Element("specialDefense").Value);
            p.Speed = Convert.ToByte(e.Element("speed").Value);

            List<XElement> abilities = e.Element("abilities").Elements("ability").ToList();
            for (int i = 0; i < abilities.Count; ++i)
            {
                string s = abilities[i].Value;
                if (s != null)
                    p.Abilities[i] = Convert.ToByte(s);
            }

            List<XElement> movesWillLearnByLevel = e.Element("movesWillLearnByLevel").Elements("move").ToList();
            for (int i = 0; i < movesWillLearnByLevel.Count; ++i)
            {
                string s = movesWillLearnByLevel[i].Value;
                if (s != null)
                    p.MovesWillLearnByLevel.Add(new OPokemon.MoveWillLearnByLevel(Convert.ToByte(movesWillLearnByLevel[i].Attribute("level").Value), Convert.ToInt32(s)));
            }

            List<XElement> canLearnMoves = e.Element("canLearnMoves").Elements("move").ToList();
            for (int i = 0; i < canLearnMoves.Count; ++i)
            {
                string s = canLearnMoves[i].Value;
                if (s != null)
                    p.CanLearnMoves.Add(Convert.ToInt32(s));
            }

            XElement genres = e.Element("genresPercentage");
            p.GenresPercentage[0] = Convert.ToByte(genres.Element("male").Value);
            p.GenresPercentage[1] = Convert.ToByte(genres.Element("female").Value);

            p.EggGroup = Convert.ToByte(e.Element("eggGroup").Value);

            p.LevelType = Convert.ToByte(e.Element("levelType").Value);
            p.IsMega = Convert.ToBoolean(e.Element("isMega").Value);
            p.IsLegendary = Convert.ToBoolean(e.Element("isLegendary").Value);

            p.GivedEVs[PokeStat.Health] = Convert.ToByte(e.Element("healthEV").Value);
            p.GivedEVs[PokeStat.Attack] = Convert.ToByte(e.Element("attackEV").Value);
            p.GivedEVs[PokeStat.SpecialAttack] = Convert.ToByte(e.Element("specialAttackEV").Value);
            p.GivedEVs[PokeStat.Defense] = Convert.ToByte(e.Element("defenseEV").Value);
            p.GivedEVs[PokeStat.SpecialDefense] = Convert.ToByte(e.Element("specialDefenseEV").Value);
            p.GivedEVs[PokeStat.Speed] = Convert.ToByte(e.Element("speedEV").Value);

            p.ExperienceGives = Convert.ToByte(e.Element("experienceGives").Value);

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
