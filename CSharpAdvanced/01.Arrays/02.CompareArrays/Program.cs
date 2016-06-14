using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		int[] firstArr = new int[n];
		int[] secondArr = new int[n];

		for (int i = 0; i < n; i++) {
			firstArr [i] = int.Parse (Console.ReadLine ());
		}

		for (int j = 0; j < n; j++) {
			secondArr [j] = int.Parse (Console.ReadLine ());
		}

		//Another WAY to do it
//		if (ArraysEqual(firstArr,secondArr)) {
//			Console.WriteLine ("Equal");
//
//		} else {
//			Console.WriteLine ("Not equal");
//		}

		var arraysAreEqual = Enumerable.SequenceEqual (firstArr, secondArr);
		if (arraysAreEqual) {
			Console.WriteLine ("Equal");
			
		} else {
			Console.WriteLine ("Not equal");
		}
	}

	static bool ArraysEqual<T> (T[] a1, T[] a2)
	{
		if (ReferenceEquals (a1, a2))
			return true;

		if (a1 == null || a2 == null)
			return false;

		if (a1.Length != a2.Length)
			return false;

		EqualityComparer<T> comparer = EqualityComparer<T>.Default;
		for (int i = 0; i < a1.Length; i++) {
			if (!comparer.Equals (a1 [i], a2 [i]))
				return false;
		}
		return true;
	}
}