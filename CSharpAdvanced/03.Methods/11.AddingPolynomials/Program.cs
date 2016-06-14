using System;
using System.Linq;

class MainClass
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		int[] polynom1 = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
		int[] polynom2 = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
		int[] returnedPolynom = CalcPolynom (polynom1, polynom2);
		Print (returnedPolynom);
	}

	static int[] CalcPolynom(int[] polynom1, int[] polynom2)
	{
		int[] newArray = new int[polynom1.Length];
		for (int i = 0; i < polynom1.Length; i++) {
			newArray [i] = polynom1 [i] + polynom2 [i];
		}
		return newArray;
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
