﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02.ExtractCatalog
{


    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("..\\..\\catalog.xml");
            Dictionary<string, int> albumsCount = new Dictionary<string, int>();

            foreach (XmlElement author in document.GetElementsByTagName("artist"))
            {
                if (albumsCount.ContainsKey(author.InnerText))
                {
                    albumsCount[author.InnerText]++;
                }
                else
                {
                    albumsCount.Add(author.InnerText, 1);
                }
            }

            foreach (var item in albumsCount)
            {
                Console.WriteLine("Artist: {0}, Albums: {1}", item.Key, item.Value);
            }
        }
    }
}
