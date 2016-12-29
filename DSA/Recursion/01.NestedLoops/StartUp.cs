using System;

namespace NestedLoops
{
	class MainClass
	{
		static void Main(string[] args)
		{
			const int n = 3;
			int[] array = new int[n];

			RecursiveLoop(0, n, array);

			Console.Read();
		}

		static void RecursiveLoop(int i, int limit, int[] array)
		{
			if (i >= limit)
			{
				Print(i, array);
				return;
			}

			for (int j = 0; j < limit; j++)
			{
				array[i] = j;
				RecursiveLoop(i + 1, limit, array);
			}
		}

		static void Print(int i, int[] array)
		{
			for (int l = 0; l < i; l++)
			{
				Console.Write($"{array[l] + 1} ");
			}
			Console.WriteLine();
		}
	}
}
