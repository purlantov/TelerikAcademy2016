//Write a program that finds the most frequent number in an array of N elements.
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


		//Sorting the array
		for (int i = 0; i < n - 1; i++) {
			for (int j = i + 1; j < n; j++) {
				if (arr [i] >= arr [j]) {
					int tmp = arr [i];
					arr [i] = arr [j];
					arr [j] = tmp;
				}
			}
		}
		//find most repeat number
		int repeatElement = 0;
		int repeatTimes = 1;
		int counter = 1;
		for (int i = 0; i < n - 1; i++) {
			if (arr [i] == arr [i + 1]) {
				counter++;
				if (counter >= repeatTimes) {
					repeatElement = arr [i];
					repeatTimes = counter;
				}
			} else {
				counter = 1;
			}
		}

		Console.WriteLine ("{0} ({1} times)", repeatElement, repeatTimes);
	}
}