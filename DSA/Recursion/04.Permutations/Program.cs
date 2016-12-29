using System;

namespace Permutations
{
	class MainClass
	{

        static void Main(string[] args)
		{
			Console.WriteLine("Enter value for n: ");
			int n = int.Parse(Console.ReadLine());
			int[] used = new int[n];
			int[] mp = new int[n];

			Permute(0, n, mp, used);
		}

		static void Permute(int i, int n, int[] mp, int[] used)
		{
			if (i >= n)
			{
				Print(n, mp);
				return;
			}

			for (int k = 0; k < n; k++)
			{
				if (used[k] == 0)
				{
					used[k] = 1;
					mp[i] = k;
					Permute(i + 1, n, mp, used);
					used[k] = 0;
				}
			}

		}

		static void Print(int n, int[] mp)
		{
			for (int i = 0; i < n; i++)
			{
				Console.Write($"{mp[i] + 1} ");
			}
			Console.WriteLine();
		}
	}
}
