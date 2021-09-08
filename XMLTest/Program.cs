using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLTest
{
    class Program
    {
        static void Main()
        {
            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.IgnoreComments = true;
            xrs.IgnoreWhitespace = true;
            XmlReader reader = XmlReader.Create(@"..\..\v4.xml", xrs);
            reader.MoveToContent();
            String rootTagName = reader.Name;
            reader.Read();
            while (reader.Name != rootTagName)
            {
                Console.WriteLine(reader.Name);
                reader.ReadStartElement();
                Console.WriteLine(reader.ReadString());
                reader.ReadEndElement();
            }
        }
    }
}