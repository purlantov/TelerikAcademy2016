using System;
using System.Linq;

class MainClass
{
	public static void Main ()
	{
		Console.ReadLine ();
		int[] array = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
		Sort (array);
		Print (array);
	}

	public static int[] Sort (int[] array)
	{
		//int[] newArray = new int[array.Length];
		int value = 0;
		int current = 0;
		for (int i = 0; i < array.Length; i++) {
			current = i;
			for (int j = i; j < array.Length; j++) {
				if (array [i] > array [j] && array[current] > array[j]) {
					current = j;
				}
			}
			value = array [i];
			array [i] = array [current];
			array [current] = value;
		}

		return array;
	}

	static void Print(int[] array)
	{
		for (int i = 0; i < array.Length; i++) {
			if (i == array.Length - 1) {
				Console.Write (array [i]);
			} else {
				Console.Write ("{0} ", array [i]);
			}
		}
	}
}
