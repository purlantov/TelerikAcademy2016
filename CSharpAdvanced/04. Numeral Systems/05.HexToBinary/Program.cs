using System;

class MainClass
{
	public static void Main ()
	{
		string text = Console.ReadLine ();
		long number = Convert.ToInt64 (text, 16);
		Console.WriteLine (Convert.ToString(number,2));
	}
}