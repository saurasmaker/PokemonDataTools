﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Classes.Attributes;
using Classes.Tools;

namespace Classes.Lists
{
    class AbilitiesList
    {
        #region Attributes
        private static string defaultPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\saves\\abilities.xml";
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set
            {
                filePath = value + "\\abilities.xml";
            }
        }

       
        public List<PokeAbility> Abilities { get; set; }
        #endregion

        #region Constructors
        public AbilitiesList()
        {
            Abilities = new List<PokeAbility>();
        }

        public AbilitiesList(List<PokeAbility> abilities)
        {
            Abilities = abilities;
        }
        #endregion

        #region CRUD Methods
        public bool AddPokeAbility(PokeAbility ability)
        {
            try
            {
                Abilities.Add(ability);
                return true;
            }
            catch (Exception) { return false; }
        }

        public PokeAbility SearchPokeAbility(string name)
        {
            for (int i = 0; i < Abilities.Count; ++i)
                if (Abilities[i].Name.ToUpper().Equals(name.ToUpper()))
                    return Abilities[i];

            return null;
        }

        public bool RemovePokeAbility(string name)
        {
            for (int i = 0; i < Abilities.Count; ++i)
                if (Abilities[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    Abilities.RemoveAt(i);
                    return true;
                }

            return false;
        }

        public bool UpdatePokeAbility(string name, PokeAbility ability)
        {
            for (int i = 0; i < Abilities.Count; ++i)
                if (Abilities[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    Abilities[i] = ability;
                    return true;
                }

            return false;
        }

        public string ShowPokeAbility(string name)
        {
            for (int i = 0; i < Abilities.Count; ++i)
                if (Abilities[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    return Abilities[i].Name;
                }

            return "Pokemon not finded";
        }

        public string ShowAllPokeAbilities()
        {
            string s = "---- MovesList ----";
            for (int i = 0; i < Abilities.Count; ++i)
                s += ("\n -" + Abilities[i].Id + ") " + Abilities[i].Name);

            return s;
        }
        #endregion

        #region XML Instance CRUD

        public void Save()
        {
            Console.WriteLine("\n\n Guardando cambios...");

            XDocument doc = XMLTools.CreateXMLDocument();
            XElement root = new XElement("abilities");

            for(int i = 0; i < Abilities.Count; ++i)
                root.Add(AddPokeabilityDataInElement(Abilities[i], root));

            doc.Add(root);

            doc.Save(FilePath);

            return;
        }

        public List<PokeAbility> Load()
        {
            XDocument doc = XMLTools.GetXMLDocument(filePath);
            XElement root = doc.Root;

            if (doc != null)
            {
                int i = 0;
                foreach (XElement e in root.Elements("ability"))
                {
                    i++;
                    try
                    {
                        PokeAbility newAbility = LoadDataInAbility(e);
                        Abilities.Add(newAbility);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ability in the position {0} could not be read", i);
                    }
                }
            }

            return Abilities;
        }
        #endregion

        #region XML Default CRUD
        public static void Save(List<PokeAbility> abilitiesList)
        {
            XDocument doc = XMLTools.CreateXMLDocument();
            XElement root = new XElement("abilities");

            foreach (PokeAbility a in abilitiesList)
                root.Add(AddPokeabilityDataInElement(a, root));

            doc.Add(root);

            doc.Save(defaultPath);

            return;
        }

        public static List<PokeAbility> DefaultLoad()
        {
            XDocument doc = XMLTools.GetXMLDocument(defaultPath);
            XElement root = doc.Root;
            List<PokeAbility> pokeAbilities = new List<PokeAbility>();
            if (doc != null)
            {
                int i = 0;
                foreach (XElement e in root.Elements("ability"))
                {
                    i++;
                    try
                    {
                        PokeAbility newAbility = LoadDataInAbility(e);
                        pokeAbilities.Add(newAbility);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ability in the position {0} could not be load", i);
                    }
                }
            }

            return pokeAbilities;
        }
        #endregion

        #region XML Methods

        private static XElement AddPokeabilityDataInElement(PokeAbility m, XElement root)
        {
            XElement move = new XElement("move");
            move.Add(new XAttribute("id", GenerateId(root)));
            move.Add(new XElement("name", m.Name));

            return move;
        }

        private static PokeAbility LoadDataInAbility(XElement e)
        {
            PokeAbility p = new PokeAbility();
            p.Id = Convert.ToInt32(e.Attribute("id").Value);
            p.Name = e.Element("name").Value;

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