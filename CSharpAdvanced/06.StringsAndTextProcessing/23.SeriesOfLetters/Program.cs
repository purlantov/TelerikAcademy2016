using System;
using System.Text;

namespace SeriesOfLetters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StringBuilder sb = new StringBuilder ();
			string text = Console.ReadLine ();
			sb.Append (text [0]);
			for (int i = 1; i < text.Length; i++) {
				//if (i + 1 < text.Length) {
					
					if (text [i] == text [i - 1]) {
						//if (i + 1 < text.Length) {
						continue;
						//}
					}
					sb.Append (text [i]);
				//}
			}
			Console.WriteLine (sb);
		}
	}
}
