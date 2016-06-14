using System;
using System.Text;

namespace UnicodeCharacters
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Console.WriteLine(GetUnicodeRepresentation(input));
		}

		private static string GetUnicodeRepresentation(string input)
		{
			StringBuilder result = new StringBuilder();
			foreach (char c in input)
			{
				result.Append("\\u" + ((int)c).ToString("X").PadLeft(4,'0'));
			}

			return result.ToString();
		}
	}
}
