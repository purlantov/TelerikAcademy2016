using System;
using System.Linq;

class MainClass
{
	public static void Main(string[] args)
	{
		var firstInput = Console.ReadLine().Split(' ').Select(v => Convert.ToInt32(v)).ToArray();
		int n = firstInput[0];
		int mj = firstInput[1];
		int mh = firstInput[2];

		var trees = new int[n, 2];

		for (int i = 0; i < n; i++)
		{
			var input = Console.ReadLine().Split(' ').Select(v => Convert.ToInt32(v)).ToArray();
			trees[i, 0] = input[0];
			trees[i, 1] = input[1];


		}

		int counter = 0;
		int indexX = 0;
		int indexH = 0;

		for (int i = 0; i < n - 1; i++)
		{
			bool isValidX = Math.Abs(trees[i, 0] - trees[i + 1, 0]) <= mj;
			bool isValidH = Math.Abs(trees[i, 1] - trees[i + 1, 1]) <= mh;

			if (isValidX && isValidH)
			{
				continue;
			}
			if (isValidX || isValidH)
			{
				counter++;
				
			}
		}

		if (counter != 0)
		{
			Console.WriteLine(counter);
		}
		else
		{
			Console.WriteLine(-1);
		}
	}
}
