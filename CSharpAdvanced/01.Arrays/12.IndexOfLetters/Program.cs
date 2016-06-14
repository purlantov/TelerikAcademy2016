using System;

class MainClass
{
	public static void Main ()
	{
		string input = Console.ReadLine ();
		string arr = "abcdefghijklmnopqrstuvwxyz";
		for (int i = 0; i < input.Length; i++) {
			for (int j = 0; j < arr.Length; j++) {
				if (input[i]==arr[j]) {
					Console.WriteLine (j);
				}
			}
		}
	}
}
