using System;
using System.Linq;

namespace MinMaxSumTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] arr = { 7, 2, 5, 10, 8 };

			//var result = LargestsubarrayMaxSum(arr);

			var result = new[] { 0 }
							 .Concat(arr.Select((x, i) => new { x, i })
							 .Where(a => a.x < 0).Select(a => a.i + 1))
							 .Select(i => arr.Skip(i).TakeWhile(a => a >= 0))
							 .OrderByDescending(a => a.Sum())
							 .OrderByDescending(a => a.Count()).First();

			Console.WriteLine(string.Join(" ", result));
		}





		public static int[] LargestsubarrayMaxSum(int[] arr)
		{
			int temp = 0;
			int[] resultArr = new int[arr.Length];

			for (int i = 0; i < arr.Length - 1; i++)
			{
				if (i != 0)
				{
					foreach (int item in resultArr)
					{
						temp += item;
					}

					if (temp + arr[i + 1] > 0)
					{
						resultArr[i + 1] = temp + arr[i + 1];
					}
				}
				else
				{
					if ((arr[i] + arr[i + 1]) >= 0)
					{
						resultArr[i] = arr[i];
						resultArr[i + 1] = arr[i] + arr[i + 1];
					}
					else
					{
						resultArr[i] = arr[i];
						resultArr[i + 1] = 0;
					}
				}
			}
			return resultArr;
		}

	}
}
