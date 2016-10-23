using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExtrSongsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("..\\..\\..\\..\\catalog.xml");
            var songs = from song in document.Descendants("song")
                        select new
                        {
                            Title = song.Element("name").Value,
                        };

            foreach (var song in songs)
            {
                Console.WriteLine(song.Title);
            }
        }
    }
}
