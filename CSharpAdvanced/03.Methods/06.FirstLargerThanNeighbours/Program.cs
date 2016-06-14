using System;
using System.Linq;

class MainClass
{
	public static void Main ()
	{
		Console.ReadLine ();
		int[] numbers = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
		Console.WriteLine (IndexFirstElement (numbers));
	}

	public static int IndexFirstElement (int[] numbers)
	{
		int index = -1;
		for (int i = 1; i < numbers.Length - 1; i++) {
			if (numbers [i - 1] < numbers [i] && numbers [i + 1] < numbers [i]) {
				index = i;
				break;
			}
		}
		return index;
	}
}
