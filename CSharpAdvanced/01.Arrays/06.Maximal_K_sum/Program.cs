using System;
using System.Collections.Generic;

namespace Maximal_K_sum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int k = int.Parse (Console.ReadLine ());
			var arr = new List<int> ();
			for (int i = 0; i < n; i++) {
				arr.Add (int.Parse (Console.ReadLine ()));
			}
			arr.Sort ();
			int sum = 0;
			for (int i = 0; i < k; i++) {
				sum += arr [arr.Count - i-1];
			}
			Console.WriteLine (sum);
		}
	}
}
