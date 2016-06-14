using System;
using System.Text;

namespace SubstringInText
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string pattern = Console.ReadLine ().ToLower();
			StringBuilder text = new StringBuilder ();
			text.Append (Console.ReadLine ());
			int counter = 0;
			for (int position = 0; position <= text.Length; position++) {
				if (position + pattern.Length <= text.Length) {
					if (text.ToString (position, pattern.Length).ToLower() == pattern) {
						counter++;
						position += pattern.Length - 1;
					}
				}
			}
			Console.WriteLine (counter);
		}
	}
}