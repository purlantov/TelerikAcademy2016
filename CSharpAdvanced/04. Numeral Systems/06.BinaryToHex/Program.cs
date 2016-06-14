using System;

namespace BinaryToHex
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string binary = Console.ReadLine ();
			long number = Convert.ToInt64(binary,2);
			Console.WriteLine (Convert.ToString(number,16).ToUpper());
		}
	}
}
