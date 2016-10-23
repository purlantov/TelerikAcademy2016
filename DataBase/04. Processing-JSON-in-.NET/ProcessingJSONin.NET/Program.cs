using System;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace ProcessingJSONin.NET
{
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Reflection;

    using Newtonsoft.Json.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //
            // One way
            //
            //string path = @"https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";

            //var rssFeed = XDocument.Load(path);

            //string json = JsonConvert.SerializeXNode(rssFeed, Newtonsoft.Json.Formatting.Indented);

            //Console.WriteLine(json);

            //File.WriteAllText("..\\..\\RSS.json", json);
            //rssFeed.Save("..\\..\\RSS.xml");


            //
            // Recommend way
            //
            WebClient wb = new WebClient();
            wb.DownloadFile(
                "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw",
                "..\\..\\test.xml");

            XDocument doc = XDocument.Load("..\\..\\test.xml");
            var toJson = JsonConvert.SerializeXNode(doc, Newtonsoft.Json.Formatting.Indented);
            //Console.WriteLine(toJson);
            File.WriteAllText("..\\..\\test.json", toJson);

            var jObject = JObject.Parse(toJson)["feed"];

            string videoTag = jObject.Value<string>("title");

            var sdhkjs = jObject.Where(v => v.Value<string>("title") == "title");

            var dsds = jObject.Any(v => v.Value<string>("title")=="title");

            Console.WriteLine();

        }
    }
}
