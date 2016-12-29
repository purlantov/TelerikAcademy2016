using System;

namespace CombinationsWithDuplicates
{
	class MainClass
	{
		static void Main(string[] args)
		{
			int n = 3;
			int k = 2;
			int[] array = new int[k];
			RecursiveLoop(1, 1, n, k, array);
		}

		static void RecursiveLoop(int i, int after, int limit, int kElements, int[] array)
		{
			if (i > kElements)
			{
				return;
			}

			for (int j = after; j <= limit; j++)
			{
				array[i - 1] = j;
				if (i == kElements)
				{
					Print(i, array);
				}
				RecursiveLoop(i + 1, j, limit, kElements, array);
			}
		}

		static void Print(int i, int[] array)
		{
			for (int l = 0; l < i; l++)
			{
				Console.Write($"{array[l]} ");
			}
			Console.WriteLine();
		}
	}
}
