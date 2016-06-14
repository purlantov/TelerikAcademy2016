using System;

class MainClass
{
	public static void Main ()
	{
		decimal number = decimal.Parse (Console.ReadLine ());
		Console.WriteLine (ReverseNumber (number));
	}

	public static decimal ReverseNumber (decimal number)
	{
		return decimal.Parse (ReverseString (number.ToString ()));
	}

	public static string ReverseString (string s)
	{
		char[] charArray = s.ToCharArray ();
		Array.Reverse (charArray);
		return new string (charArray);
	}
}