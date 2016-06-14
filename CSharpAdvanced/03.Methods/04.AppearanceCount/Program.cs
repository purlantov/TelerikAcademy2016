using System;
using System.Linq;

class MainClass
{
	public static void Main (string[] args)
	{
		int n = int.Parse (Console.ReadLine ());
		int[] numbers = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
		int x = int.Parse (Console.ReadLine ());
		Console.WriteLine (AppearanceCount (numbers, x));
	}

	static int AppearanceCount	(int[] numbers, int x)
	{
		int count = 0;
		foreach (var item in numbers) {
			if (item == x) {
				count++;
			}
		}
		return count;
	}
}