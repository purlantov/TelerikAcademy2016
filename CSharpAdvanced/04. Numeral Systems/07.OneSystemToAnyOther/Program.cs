using System;

namespace OneSystemToAnyOther
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int fromBase = int.Parse (Console.ReadLine ());
			string text = Console.ReadLine ();
			int toBase = int.Parse (Console.ReadLine ());
			long number = Convert.ToInt64 (text, fromBase);
			Console.WriteLine (Convert.ToString(number,toBase));
		}
	}
}
