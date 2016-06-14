using System;

class MainClass
{
	public static void Main (string[] args)
	{
		
		//PrintAswear ();
		CheckMethod ();
	}

	public static void PrintAswear ()
	{
		string name = Console.ReadLine ();
		Console.WriteLine ("Hello, {0}!", name);
	}

	public static void CheckMethod ()
	{
		Console.WriteLine ("Pavel");
		PrintAswear ();

	}
}