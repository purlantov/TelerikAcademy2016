using System;

namespace AllocateArray
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int[] array = new int[n];
			for (int i = 0; i < n; i++) {
				array [i] = i * 5;
			}
			foreach (var item in array) {
				Console.WriteLine (item);
			}
		}
	}
}
