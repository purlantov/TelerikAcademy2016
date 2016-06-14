using System;

class MainClass
{
	public static void Main (string[] args)
	{
		int n = int.Parse (Console.ReadLine ());
		int[] arr = new int[n];
		for (int i = 0; i < n; i++) {
			arr [i] = int.Parse (Console.ReadLine ());
		}
		int count = 1;
		int last = 0;
		int max = 0;
		for (int i = 0; i < n; i++) {
			if (arr [i] == last) {
				count++;
				if (count > max) {
					max = count;
				}
			} else {
				count = 1;
			}
			last = arr [i];
		}
		Console.WriteLine (max);
	}
}