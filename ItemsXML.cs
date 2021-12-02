using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace SpaceGame
{
    class Items_Creation
    {
        public List<string> ReadTextFile(string filePath)
        {
            List<string> result = new List<string>();
            return result;
        }

        public List<Dictionary<string,string>> ReadXMLFile(string filePath, string elementTag)
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            
            foreach (XElement level1Element in XElement.Load(filePath).Elements(elementTag))
            {
                Dictionary<string, string> item = new Dictionary<string, string>();
                item.Add("denotation", level1Element.Attribute("denotation").Value);
                foreach (XElement level2Element in level1Element.Elements())
                {
                    item.Add(level2Element.Name.ToString(), level2Element.Attribute("price").Value);
                }
                result.Add(item);
            }
            return result;
        }
    }
}