using System;
using System.IO;
using System.Xml.Linq;

namespace Classes.Tools
{
    class XMLTools
    {
        public static string DefaultPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\saves";
        public static XDocument CreateXMLDocument()
        {

            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Saves"))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Saves");

            XDocument doc = new XDocument();

            doc.Add(new XProcessingInstruction("xml-stylesheet", "href = 'MyStyles.css' title = 'Compact' type = 'text/css'"));

            return doc;
        }

        public static XDocument GetXMLDocument(string path)
        {
            XDocument doc = null;
            try //Check if the XML Document exists
            {
                doc = XDocument.Load(path);
            }
            catch (Exception)
            { //If not, end Method
                return doc;
            }

            return doc;
        }
    }
}
