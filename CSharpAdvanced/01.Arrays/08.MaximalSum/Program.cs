using System;

namespace MaximalSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int[] arr = new int[n];
			for (int i = 0; i < n; i++) {
				arr [i] = int.Parse (Console.ReadLine ());
			}

			//Kadane's algorithm
			int currentSum = arr[0];
			int maxSum = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				if (currentSum < 0)
				{
					currentSum = arr[i];
				}
				else
				{
					currentSum += arr[i];
				}
				if (currentSum > maxSum)
				{
					maxSum = currentSum;
				}
			}

			Console.WriteLine (maxSum);
		}
	}
}
