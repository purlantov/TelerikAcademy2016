using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceTags2
{
	class MainClass
	{
		static void Main (string[] args)
		{

			string text = Console.ReadLine ();

			var URLs = FindURLs (text);

			var inside = GetInside (text);

			string text2 = null;

			string closeHref = "\">";
			string aTag = @"</a>";
			var middleText = new List<string> ();
			int count = 0;
			for (int i = 0; i < text.Length; i++) {
				if (text.IndexOf (closeHref, i) != -1 && text.IndexOf (aTag, i) != -1) {
					int n = text.IndexOf (closeHref, i);
					int m = text.IndexOf (aTag, i);
					int l = text.IndexOf ("<a href=", i);
					int k = text.IndexOf ("\">", i);
					text2 = text;
					text2 = text.Remove (l, m - l + aTag.Length);
					string insert = '[' + inside [count] + ']' + '(' + URLs [count] + ')';
					text2 = text2.Insert (l, insert);

					text = text2;
					i = m + aTag.Length;
					count++;
				}
			}

			Console.WriteLine (text);
		}

		private static List<string> GetInside (string text)
		{
			string closeHref = "\">";
			string aTag = @"</a>";
			var middleText = new List<string> ();
			for (int i = 0; i < text.Length; i++) {
				if (text.IndexOf (closeHref, i) != -1 && text.IndexOf (aTag, i) != -1) {
					int n = text.IndexOf (closeHref, i);
					int m = text.IndexOf (aTag, i);
					middleText.Add (text.Substring (n + closeHref.Length, m - n - closeHref.Length));
					i = m + aTag.Length;
				}
			}
			return middleText;
		}

		private static List<string> FindURLs (string text)
		{
			var urls = new List<string> ();
			for (int i = 0; i < text.Length; i++) {
				string href = null;
				if (text.IndexOf ("<a href=", i) != -1 && text.IndexOf ("\">", i) != -1) {
					int n = text.IndexOf ("<a href=", i);
					int m = text.IndexOf ("\">", i);
					href = text.Substring (n + 9, m - n - 9);
					i = m + 2;
					urls.Add (href);
				}

			}
			return urls;
		}
	}
}
