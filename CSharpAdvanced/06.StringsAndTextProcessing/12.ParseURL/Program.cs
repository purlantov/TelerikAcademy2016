using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ParseURL
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] format = new string[]
			{
				"[protocol] = {0}",
				"[server] = {0}",
				"[resource] = /{0}"
			};

			string toParse = Console.ReadLine();

			//var URLPattern = new Regex(@"(?<Protocol>\w+)://(?<Server>[\w\.]+)(?<Content>/.*)");

			// Expressions in Brackets are captured in groups.
			// Anything outside of the brackets is matched but 
			// not captured.
			// Optionally can name each group with <Name>
			// 
			string URLPattern = (@"(\w*)://(.*)/(.*)");

			var Match = Regex.Match(toParse, URLPattern, RegexOptions.RightToLeft);

			List<object> toPrint = new List<object>();

			foreach (var group in Match.Groups)
			{
				if (group.ToString() != toParse)
				{
					toPrint.Add(group);
				}
			}

			for (int index = 0; index < 3; index++)
			{
				Console.WriteLine(string.Format(format[index], toPrint[index]));
			}
		}
	}
}
