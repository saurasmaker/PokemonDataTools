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
        private static string path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\saves\\moves.xml";

        #endregion


        #region Static Methods
        public static void CreateMovesListXML()
        {
            try
            {
                XDocument doc = PreparedXMLDocument();
                XElement root = new XElement("moves");
                root.Add(AddDataMoveElement(PokeMove.Zero()));
                doc.Add(root);
                doc.Save(path);

                Console.WriteLine("Moves list created succesfully." + root);
            }
            catch (Exception t)
            {
                Console.WriteLine(t.Message);
            }
        }

        public static void SaveMovesListInXML(List<PokeMove> movesList)
        {
            XDocument doc = PreparedXMLDocument();
            XElement root = new XElement("moves");

            foreach (PokeMove m in movesList)
                root.Add(AddDataMoveElement(m));

            doc.Add(root);

            doc.Save(path);

            return;
        }

        public static void SaveMoveInPokedexXML(PokeMove m)
        {
            XDocument doc = GetXMLDocument();

            if (doc == null)
                doc = PreparedXMLDocument();

            doc.Root.Add(AddDataMoveElement(m));
            doc.Save(path);

            return;
        }

        public static List<PokeMove> LoadMovesListFromXML()
        {
            XDocument doc = GetXMLDocument();
            List<PokeMove> moves = null;

            if (doc != null)
            {
                int i = 0;
                foreach (XElement e in doc.Elements("move"))
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



        public static PokeMove LoadMoveFromMovesListXML(string name)
        {
            XDocument doc = GetXMLDocument();
            PokeMove m = null;

            if (doc != null)
                foreach (XElement e in doc.Root.Elements())
                    if (e.Element("name").Value.ToUpper().Equals(name.ToUpper()))
                        m = LoadDataInMove(e);

            return m;
        }

        public static void EditMoveFromMovesListXML(int id, PokeMove p)
        {
            XDocument doc = GetXMLDocument();
            XElement f = null;

            if (doc != null)
                foreach (XElement e in doc.Root.Elements())
                    if (Convert.ToInt32(e.Attribute("id").Value).Equals(id))
                        f = e;

            if (f != null && p != null)
                EditDataInMove(f, p);

            doc.Save(path);

            return;
        }

        public static void RemoveMoveFromMovesListXML(string name)
        {
            XDocument doc = XMLTools.GetXMLDocument(path);
            XElement p = null;

            if (doc != null)
                foreach (XElement e in doc.Root.Elements())
                    if (e.Element("name").Value.ToUpper().Equals(name.ToUpper()))
                    {
                        p = e;
                        break;
                    }

            p.Remove();

            doc.Save(path);

            return;
        }


        #region XML Methods
        private static XDocument GetXMLDocument()
        {
            XDocument doc = null;
            try //Check if the XML Document exists
            {
                doc = XDocument.Load(path);
            }
            catch (Exception e)
            { //If not, end Method
                Console.WriteLine(e.Message);
                return null;
            }

            return doc;
        }

        private static XDocument PreparedXMLDocument()
        {
            XDocument doc = new XDocument();

            doc.Add(new XDeclaration("1.0", "utf-8", "yes"));
            doc.Add(new XComment("Pokedex"));
            doc.Add(new XProcessingInstruction("xml-stylesheet", "href = 'MyStyles.css' title = 'Compact' type = 'text/css'"));

            return doc;
        }

        private static XElement AddDataMoveElement(PokeMove m)
        {
            XElement move = new XElement("move");
            move.Add(new XAttribute("id", GenerateId()));
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

        private static XElement EditDataInMove(XElement move, PokeMove m)
        {
            move.Attribute("id").Value = m.Id.ToString();
            move.Element("name").Value = m.Name;
            move.Element("description").Value = m.Description;
            move.Element("type").Value = m.Type.ToString();
            move.Element("category").Value = m.Category.ToString();
            move.Element("accuarcy").Value = m.Accuracy.ToString();
            move.Element("power").Value = m.Power.ToString();
            move.Element("recover").Value = m.Recover.ToString();
            move.Element("repetitions").Value = m.Repetitions.ToString();
            move.Element("repetitionsInTurn").Value = m.RepetitionsInTurn.ToString();
            move.Element("target").Value = m.Target.ToString();
            move.Element("pp").Value = m.PP.ToString();
            move.Element("contact").Value = m.Contact ? "true" : "false";
            move.Element("priority").Value = m.Priority.ToString();
            move.Element("effectCode").Value = m.EffectCode;
            move.Element("effectProbability").Value = m.EffectProbability.ToString();

            return move;
        }

        private static int GenerateId()
        {
            XDocument doc = GetXMLDocument();
            IEnumerable<XElement> elements = doc.Root.Elements();

            return (Convert.ToInt32(elements.Last().Attribute("id").Value) + 1);
        }
        #endregion

        #endregion
    }
}
