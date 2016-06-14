using System;

namespace StringLength
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			string str = Console.ReadLine ();
//			if (str.Length <= 20) {
//				int dots = 20 - str.Length;
//				Console.WriteLine (str + new string ('*', dots));
//			} else {
//				Console.WriteLine (str);
//			}

			Console.WriteLine(Console.ReadLine().PadRight(20, '*'));
		}
	}
}
