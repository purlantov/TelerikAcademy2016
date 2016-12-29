using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _04.DeleteAlbumsGratherThan20
{


    class DeleteAlbums
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("..\\..\\catalog.xml");

            var albums = doc.SelectNodes("catalogue/album");

            foreach (XmlNode item in albums)
            {
                if (decimal.Parse(item["price"].InnerText) > 20)
                {
                    item.ParentNode.RemoveChild(item);
                }
            }

            Console.WriteLine("New xml: ");
            Console.WriteLine(doc.OuterXml);

            doc.Save("..\\..\\newCatalogue.xml");
        }

    }
}
