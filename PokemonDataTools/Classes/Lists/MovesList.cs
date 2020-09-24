using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Classes.Tools;

namespace Classes.Lists
{
    public class MovesList
    {
        #region Attributes
        private static string defaultPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\saves\\moves.xml";

        public string FilePath { get; set; }

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
            XDocument doc = XMLTools.CreateXMLDocument();
            XElement root = new XElement("moves");

            for(int i = 0; i < Moves.Count; ++i)
                root.Add(AddPokemoveDataInElement(Moves[i], root));

            doc.Add(root);

            doc.Save(FilePath + "\\moves.xml");

            return;
        }

        public void Load()
        {
            XDocument doc = XMLTools.GetXMLDocument(FilePath);

            if (doc != null)
            {

                XElement root = doc.Root;

                if (doc != null)
                {
                    int i = 0;
                    foreach (XElement e in root.Elements("move"))
                    {
                        i++;
                        try
                        {
                            PokeMove newMove = LoadDataInMove(e);
                            Moves.Add(newMove);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Movement in the position {0} could not be read", i);
                        }
                    }
                }
            }
            return;
        }
        #endregion

        #region XML Default CRUD
        public static void DefaultSave(List<PokeMove> movesList)
        {
            XDocument doc = XMLTools.CreateXMLDocument();
            XElement root = new XElement("moves");

            foreach (PokeMove m in movesList)
                root.Add(AddPokemoveDataInElement(m, root));

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
        private static XElement AddPokemoveDataInElement(PokeMove m, XElement root)
        {
            XElement move = new XElement("move");
            move.Add(new XAttribute("id", GenerateId(root)));
            move.Add(new XElement("name", m.Name));
            move.Add(new XElement("internalName", m.InternalName));
            move.Add(new XElement("description", m.Description));
            move.Add(new XElement("type", m.Type));
            move.Add(new XElement("category", m.Category));
            move.Add(new XElement("accuarcy", m.Accuracy));
            move.Add(new XElement("power", m.Power));
            move.Add(new XElement("repetitions", m.Repetitions));
            move.Add(new XElement("repetitionsInTurn", m.RepetitionsInTurn));
            move.Add(new XElement("recoverByDamage", m.RecoverByDamage));
            move.Add(new XElement("pp", m.PP));
            move.Add(new XElement("target", m.Target));
            move.Add(new XElement("priority", m.Priority));
            move.Add(new XElement("effectCode", m.EffectCode));

            move.Add(new XElement("contact", m.Contact ? "true" : "false"));
            move.Add(new XElement("isDance", m.IsDance ? "true" : "false"));
            move.Add(new XElement("canBeProtected", m.CanBeProtected ? "true" : "false"));
            move.Add(new XElement("affectedByBounceEffect", m.AffectedByBounceEffect ? "true" : "false"));
            move.Add(new XElement("canSteal", m.CanSteal ? "true" : "false"));
            move.Add(new XElement("canCopy", m.CanCopy ? "true" : "false"));
            move.Add(new XElement("affectedByKingsRock", m.AffectedByKingsRock ? "true" : "false"));
            move.Add(new XElement("canDefrost", m.CanDefrost ? "true" : "false"));
            move.Add(new XElement("isPerforation", m.IsPerforation ? "true" : "false"));
            move.Add(new XElement("isSound", m.IsSound ? "true" : "false"));
            move.Add(new XElement("affectedByGravity", m.AffectedByGravity ? "true" : "false"));

            move.Add(new XElement("effectProbability", m.EffectProbability));
            move.Add(new XElement("criticalProbability", m.CriticalProbability));

            return move;
        }

        private static PokeMove LoadDataInMove(XElement e)
        {
            PokeMove p = new PokeMove();
            p.Id = Convert.ToInt32(e.Attribute("id").Value);
            p.Name = e.Element("name").Value;
            p.InternalName = e.Element("internalName").Value;
            p.Description = e.Element("description").Value;
            p.Type = Convert.ToByte(e.Element("type").Value);
            p.Category = Convert.ToByte(e.Element("category").Value);
            p.Accuracy = Convert.ToByte(e.Element("accuarcy").Value);
            p.Power = Convert.ToSByte(e.Element("power").Value);
            p.Repetitions = Convert.ToByte(e.Element("repetitions").Value);
            p.RepetitionsInTurn = Convert.ToByte(e.Element("repetitionsInTurn").Value);
            p.RecoverByDamage = Convert.ToSByte(e.Element("recoverByDamage").Value);
            p.PP = Convert.ToByte(e.Element("pp").Value);
            p.Target = Convert.ToByte(e.Element("target").Value);
            p.Priority = Convert.ToSByte(e.Element("priority").Value);
            p.EffectCode = e.Element("effectCode").Value;

            p.Contact = e.Element("contact").Value.Equals("true") ? true : false;
            p.IsDance = e.Element("isDance").Value.Equals("true") ? true : false;
            p.CanBeProtected = e.Element("canBeProtected").Value.Equals("true") ? true : false;
            p.AffectedByBounceEffect = e.Element("affectedByBounceEffect").Value.Equals("true") ? true : false;
            p.CanSteal = e.Element("canSteal").Value.Equals("true") ? true : false;
            p.AffectedByKingsRock = e.Element("affectedByKingsRock").Value.Equals("true") ? true : false;
            p.CanDefrost = e.Element("canDefrost").Value.Equals("true") ? true : false;
            p.IsPerforation = e.Element("isPerforation").Value.Equals("true") ? true : false;
            p.IsSound = e.Element("isSound").Value.Equals("true") ? true : false;
            p.AffectedByGravity = e.Element("affectedByGravity").Value.Equals("true") ? true : false;
            
            p.EffectProbability = Convert.ToByte(e.Element("effectProbability").Value);
            p.CriticalProbability = Convert.ToByte(e.Element("criticalProbability").Value);

            return p;
        }

        private static int GenerateId(XElement root)
        {
            IEnumerable<XElement> elements;
            try
            {
                elements = root.Elements();
            }
            catch (Exception)
            {
                return 0;
            }

            if(elements.Any())
                return (Convert.ToInt32(elements.Last().Attribute("id").Value) + 1);
            else
                return 0;
        }
        #endregion

    }
}
