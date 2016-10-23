using System;
using System.Collections.Generic;
using System.Xml;

namespace _03.XPath
{
    class XPath
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("..\\..\\catalog.xml");
            Dictionary<string, int> albumsCount = new Dictionary<string, int>();

            var artists = document.SelectNodes("music/artist");

            foreach (XmlElement artist in artists)
            {
                string album = artist.SelectSingleNode("album").InnerText;
                if (albumsCount.ContainsKey(album))
                {
                    albumsCount[album]++;
                }
                else
                {
                    albumsCount.Add(album, 1);
                }
            }

            foreach (var album in albumsCount)
            {
                Console.WriteLine("Artist: {0}, Albums: {1}", album.Key, album.Value);
            }
        }
    }
}
