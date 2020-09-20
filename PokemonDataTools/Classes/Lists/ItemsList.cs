using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Classes.Attributes;
using Classes.Tools;

namespace Classes.Lists
{
    class ItemsList
    {
        #region Attributes
        private static string defaultPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\saves\\items.xml";
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set
            {
                filePath = value + "\\items.xml";
            }
        }

        public List<PokeItem> Items { get; set; }
        #endregion

        #region Constructors
        public ItemsList() 
        {
            Items = new List<PokeItem>();       
        }

        public ItemsList(List<PokeItem> items) 
        {

            Items = items;
        }
        #endregion

        #region CRUD Methods
        public bool AddPokeItem(PokeItem item)
        {
            try
            {
                Items.Add(item);
                return true;
            }
            catch (Exception) { return false; }
        }

        public PokeItem SearchPokeItem(string name)
        {
            for (int i = 0; i < Items.Count; ++i)
                if (Items[i].Name.ToUpper().Equals(name.ToUpper()))
                    return Items[i];

            return null;
        }

        public bool RemovePokeItem(string name)
        {
            for (int i = 0; i < Items.Count; ++i)
                if (Items[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    Items.RemoveAt(i);
                    return true;
                }

            return false;
        }

        public bool UpdatePokeItem(string name, PokeItem move)
        {
            for (int i = 0; i < Items.Count; ++i)
                if (Items[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    Items[i] = move;
                    return true;
                }

            return false;
        }

        public string ShowPokeItem(string name)
        {
            for (int i = 0; i < Items.Count; ++i)
                if (Items[i].Name.ToUpper().Equals(name.ToUpper()))
                {
                    return Items[i].Name;
                }

            return "Pokemon not finded";
        }

        public string ShowAllPokeItems()
        {
            string s = "---- MovesList ----";
            for (int i = 0; i < Items.Count; ++i)
                s += ("\n -" + Items[i].Id + ") " + Items[i].Name);

            return s;
        }
        #endregion

        #region XML Instance CRUD
        public void Save()
        {
            Console.WriteLine("\n\n Guardando cambios...");

            XDocument doc = XMLTools.CreateXMLDocument();
            XElement root = new XElement("moves");

            for(int i = 0; i < Items.Count; ++i)
                root.Add(AddPokeItemDataInElement(Items[i], root));               

            doc.Add(root);

            doc.Save(FilePath);

            return;
        }

        public List<PokeItem> Load()
        {
            XDocument doc = XMLTools.GetXMLDocument(filePath);
            XElement root = doc.Root;
            if (doc != null)
            {
                int i = 0;
                foreach (XElement e in root.Elements("move"))
                {
                    i++;
                    try
                    {
                        PokeItem newItem = LoadDataInItem(e);
                        Items.Add(newItem);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Movement in the position {0} could not be read", i);
                    }
                }
            }

            return Items;
        }
        #endregion

        #region XML Default CRUD
        public static void DefaultSave(List<PokeItem> itemsList)
        {
            XDocument doc = XMLTools.CreateXMLDocument();
            XElement root = new XElement("items");

            foreach (PokeItem i in itemsList)
                root.Add(AddPokeItemDataInElement(i, root));

            doc.Add(root);

            doc.Save(defaultPath);

            return;
        }

        public static List<PokeItem> DefaultLoad()
        {
            XDocument doc = XMLTools.GetXMLDocument(defaultPath);
            XElement root = doc.Root;
            List<PokeItem> items = new List<PokeItem>();
            if (doc != null)
            {
                int i = 0;
                foreach (XElement e in root.Elements("move"))
                {
                    i++;
                    try
                    {
                        PokeItem newItem = LoadDataInItem(e);
                        items.Add(newItem);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Movement in the position {0} could not be read", i);
                    }
                }
            }

            return items;
        }
        #endregion

        #region XML Methods
        private static XElement AddPokeItemDataInElement(PokeItem m, XElement root)
        {
            XElement item = new XElement("item");
            item.Add(new XAttribute("id", GenerateId(root)));
            item.Add(new XElement("name", m.Name));

            return item;
        }

        private static PokeItem LoadDataInItem(XElement e)
        {
            PokeItem p = new PokeItem();
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
                                                                       