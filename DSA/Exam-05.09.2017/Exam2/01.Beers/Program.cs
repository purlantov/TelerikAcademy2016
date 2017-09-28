using System;

namespace Beers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var firstLine = Console.ReadLine().Split(' ');
			int r = Convert.ToInt32(firstLine[0]);
			int c = Convert.ToInt32(firstLine[1]);
			var array = new int[r, c];
			int n = Convert.ToInt32(firstLine[2]);

			for (int i = 0; i < n; i++)
			{
				var point = Console.ReadLine().Split(' ');
				int indexRow = Convert.ToInt32(point[0]);
				int indexColl = Convert.ToInt32(point[1]);

				array[indexRow, indexColl] = 1;
			}



			Console.WriteLine(MinCost(array, 5, 5));
		}

		public static int MinCost(int[,] arr, int m, int n)
		{
			int[,] tc = arr;

			for (int i = 1; i <= m; i++)
			{
				tc[i, 0] = tc[i - 1, 0] + arr[i, 0];
			}

			for (int j = 1; j <= n; j++)
			{
				tc[0, j] = tc[0, j - 1] + arr[0, j];
			}

			for (int i = 1; i <= m; i++)
			{
				for (int j = 1; j <= n; j++)
				{
					tc[i, j] = Max(tc[i - 1, j - 1], tc[i - 1, j], tc[i, j - 1] + arr[i, j]);
				}
			}

			return tc[m, n];
		}

		public static int Max(int x, int y, int z)
		{
			if (x > y)
				return (x > z) ? x : z;
			else
				return (y > z) ? y : z;
		}
	}
}
