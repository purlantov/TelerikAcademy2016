using System;

class MainClass
{
	public static void Main (string[] args)
	{
		int year = int.Parse (Console.ReadLine ());
		if (DateTime.IsLeapYear (year)) {
			Console.WriteLine ("Leap");
		} else {
			Console.WriteLine ("Common");	
		}
	}
}