using System;
using System.IO;
using System.Xml.Linq;
using Tools;

namespace Classes.Tools
{
    static class XmlTools
    {
        public static readonly string DefaultPath = Directory.GetCurrentDirectory() + "\\..\\..\\Saves";
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
            XDocument doc;
            try //Check if the XML Document exists
            {
                doc = XDocument.Load(path);
            }
            catch (Exception)
            { //If not, end Method
                Log.Execute("Error to load the document: " + path);
                doc = null;
            }

            return doc;
        }
    }
}
