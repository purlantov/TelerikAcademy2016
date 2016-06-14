using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ReplaceТags
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			string text = Console.ReadLine ();
//			string regex = @"/<a href=""|\\|"">|\\|<\/a>/g";
//			MatchCollection matches = Regex.Matches (text, regex);
//			//Console.WriteLine ("Hello World!");
//
//			foreach (Match match in matches) {
//				Console.WriteLine (match.Value);
//			}



			string text = Console.ReadLine ();
			string href = @"<a href=""";
			string closeHref = ">\"";
			var list = new List<string> ();
			for (int i = 0; i < text.Length; i++) {
				if (text.IndexOf (href, i) != -1 || text.IndexOf (closeHref, i) != -1) {
					int n = text.IndexOf (href, i);
					int m = text.IndexOf (closeHref, i);

				}
			}
			Console.WriteLine (href);
		}
	}
}
