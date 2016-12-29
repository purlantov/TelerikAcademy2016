using System;
using System.IO;
using System.Xml.Linq;

namespace _07.CreateXML
{


    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("..\\..\\contacts.txt");
            XElement personXml = new XElement("contacts");

            while (!sr.EndOfStream)
            {

                string name = sr.ReadLine();
                string address = sr.ReadLine();
                string phone = sr.ReadLine();

                personXml.Add(
                    new XElement("contact",
                        new XElement("name", name),
                        new XElement("address", address),
                        new XElement("phone", phone)
                        ));
            }

            Console.WriteLine(personXml);
            personXml.Save("..\\..\\contacts.xml");
        }
    }
}
