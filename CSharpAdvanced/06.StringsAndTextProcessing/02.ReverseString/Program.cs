using System;
using System.Text;

namespace ReverseString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text = Console.ReadLine ();
			StringBuilder reversedText = new StringBuilder ();
			for (int i = 0; i < text.Length; i++) {
				reversedText.Append (text [text.Length - 1 - i]);
			}
			Console.WriteLine (reversedText);
		}
	}
}
