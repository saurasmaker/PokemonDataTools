using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Classes.Tools;

namespace Classes.Lists
{
    class MovesList
    {
        #region Attributes
        private static string defaultPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\saves\\moves.xml";
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set
            {
                filePath = value + "\\moves.xml";
            }
        }

        public List<PokeMove> Moves { get; set; }
        #endregion

        #region Constructors
        public MovesList()
        {
            Moves = new List<PokeMove>();
        }

        public MovesList(List<PokeMove> moves)
        {
            Moves = moves;
        }
        #endregion

        #region CRUD Methods
        public bool AddPokeMove(PokeMove move)
        {
            try
            {
                Moves.Add(move);
                return true;
            }
            catch (Exception) { return false; }
        }

        public PokeMove SearchPokeMove(string name)
        {
            for (int i = 0; i < Moves.Count; ++i)
                if (Moves[i].Name.ToUpper().Equals(name.ToUpper()))
                    return Moves[i];

            return null;
        }

        public bool RemovePokeMove(string name)
        {
            for (int i = 0; i < Moves.Count; ++i)
                if (Moves[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    Moves.RemoveAt(i);
                    return true;
                }

            return false;
        }

        public bool UpdatePokeMove(string name, PokeMove move)
        {
            for (int i = 0; i < Moves.Count; ++i)
                if (Moves[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    Moves[i] = move;
                    return true;
                }

            return false;
        }

        public string ShowPokeMove(string name)
        {
            for (int i = 0; i < Moves.Count; ++i)
                if (Moves[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    return Moves[i].Name;
                }

            return "Pokemon not finded";
        }

        public string ShowAllPokeMoves()
        {
            string s = "---- MovesList ----";
            for (int i = 0; i < Moves.Count; ++i)
                s += ("\n -" + Moves[i].Id + ") " + Moves[i].Name);

            return s;
        }
        #endregion

        #region XML Instance CRUD
        public void Save()
        {
            Console.WriteLine("\n\n Guardando cambios...");

            XDocument doc = XMLTools.CreateXMLDocument();
            XElement root = new XElement("moves");

            foreach (PokeMove m in Moves)
                root.Add(AddPokemoveDataInElement(m, doc));

            doc.Add(root);

            doc.Save(defaultPath);

            return;
        }

        public List<PokeMove> Load()
        {
            XDocument doc = XMLTools.GetXMLDocument(filePath);
            XElement root = doc.Root;
            List<PokeMove> moves = new List<PokeMove>();
            if (doc != null)
            {
                int i = 0;
                foreach (XElement e in root.Elements("move"))
                {
                    i++;
                    try
                    {
                        PokeMove newMove = LoadDataInMove(e);
                        moves.Add(newMove);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Movement in the position {0} could not be read", i);
                    }
                }
            }

            return moves;
        }
        #endregion

        #region XML Default CRUD
        public static void DefaultSave(List<PokeMove> movesList)
        {
            XDocument doc = XMLTools.CreateXMLDocument();
            XElement root = new XElement("moves");

            foreach (PokeMove m in movesList)
                root.Add(AddPokemoveDataInElement(m, doc));

            doc.Add(root);

            doc.Save(defaultPath);

            return;
        }

        public static List<PokeMove> DefaultLoad()
        {
            XDocument doc = XMLTools.GetXMLDocument(defaultPath);
            XElement root = doc.Root;
            List<PokeMove> moves = new List<PokeMove>();
            if (doc != null)
            {
                int i = 0;
                foreach (XElement e in root.Elements("move"))
                {
                    i++;
                    try
                    {
                        PokeMove newMove = LoadDataInMove(e);
                        moves.Add(newMove);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Movement in the position {0} could not be read", i);
                    }
                }
            }

            return moves;
        }
        #endregion

        #region XML Methods
        private static XElement AddPokemoveDataInElement(PokeMove m, XDocument doc)
        {
            XElement move = new XElement("move");
            move.Add(new XAttribute("id", GenerateId(doc)));
            move.Add(new XElement("name", m.Name));
            move.Add(new XElement("description", m.Description));
            move.Add(new XElement("type", m.Type));
            move.Add(new XElement("category", m.Category));
            move.Add(new XElement("accuarcy", m.Accuracy));
            move.Add(new XElement("damage", m.Power));
            move.Add(new XElement("recover", m.Recover));
            move.Add(new XElement("repetitions", m.Repetitions));
            move.Add(new XElement("repetitionsInTurn", m.RepetitionsInTurn));
            move.Add(new XElement("target", m.Target));
            move.Add(new XElement("pp", m.PP));
            move.Add(new XElement("contact", m.Contact ? "true" : "false"));
            move.Add(new XElement("priority", m.Priority));
            move.Add(new XElement("effectCode", m.EffectCode));
            move.Add(new XElement("effectProbability", m.EffectProbability));

            return move;
        }

        private static PokeMove LoadDataInMove(XElement e)
        {
            PokeMove p = new PokeMove();
            p.Id = Convert.ToInt32(e.Attribute("id").Value);
            p.Name = e.Element("name").Value;
            p.Description = e.Element("description").Value;
            p.Type = Convert.ToByte(e.Element("type").Value);
            p.Category = Convert.ToByte(e.Element("category").Value);
            p.Accuracy = Convert.ToByte(e.Element("accuarcy").Value);
            p.Power = Convert.ToSByte(e.Element("power").Value);
            p.Recover = Convert.ToSByte(e.Element("recover").Value);
            p.Target = Convert.ToByte(e.Element("target").Value);
            p.PP = Convert.ToByte(e.Element("pp").Value);
            p.Contact = e.Element("contact").Value.Equals("true") ? true : false;
            p.Priority = Convert.ToByte(e.Element("priority").Value);
            p.EffectCode = e.Element("effectCode").Value;
            p.EffectProbability = Convert.ToByte(e.Element("effectProbability").Value);

            return p;
        }

        private static int GenerateId(XDocument doc)
        {
            IEnumerable<XElement> elements = doc.Root.Elements();

            return (Convert.ToInt32(elements.Last().Attribute("id").Value) + 1);
        }
        #endregion

    }
}
