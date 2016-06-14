using System;

namespace SelectionSort
{
	class MainClass
	{
		public static void Main ()
		{
			int n = int.Parse (Console.ReadLine ());
			int min_key = int.MaxValue;
			int tmp = int.MinValue;
			int[] arr = new int[n];
			//Fill the array
			for (int i = 0; i < n; i++) {
				arr [i] = int.Parse (Console.ReadLine ());
			}
			//Sorting algoritm
			for (int i = 0; i < n - 1; i++) {
				min_key = i;
				for (int j = i + 1; j < n; j++) {
					if (arr [j] < arr [min_key]) {
						min_key = j;
					}
				}
				tmp = arr [min_key];
				arr [min_key] = arr [i];
				arr [i] = tmp;	
			}

			foreach (var item in arr) {
				Console.WriteLine (item);
			}
		}
	}
}
