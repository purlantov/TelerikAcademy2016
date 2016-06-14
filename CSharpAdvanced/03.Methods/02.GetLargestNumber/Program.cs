using System;

class MainClass
{
	public static void Main ()
	{
		string[] text = Console.ReadLine ().Split (' ');
		int[] input = new int[text.Length];
		for (int i = 0; i < text.Length; i++) {
			input [i] = int.Parse (text [i]);
		}

		int max = int.MinValue;
		int current = 0;
		for (int i = 1; i < input.Length; i++) {
			current = GetMax (input [i - 1], input [i]);
			if (current> max) {
				max = current;
			}
		}
		Console.WriteLine (max);
	}

	public static int GetMax(int value1, int value2)
	{
		if (value1 >= value2) {
			return value1;
		} else {
			return value2;
		}
	}
}