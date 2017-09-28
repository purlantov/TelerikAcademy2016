using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace Medians
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var list = new OrderedBag<int>();

			while (true)
			{
				var input = Console.ReadLine().Split(' ');

				if (input[0] == "ADD")
				{
					int number = Convert.ToInt32(input[1]);
					list.Add(number);
				}
				if (input[0] == "FIND")
				{
					var result = GetMedian(list);
					Console.WriteLine(result);
				}
				if (input[0] == "EXIT")
				{
					break;
				}


			}
		}

		public static double GetMedian(OrderedBag<int> arr)
		{
			double median = 0;
			int size = arr.Count;
			int middle = size / 2;



			if (size % 2 == 0)
			{
				median = (arr[middle - 1] + arr[middle]) / (double)2;

			}
			else
			{
				median = arr[middle];
			}


			return median;
		}

	}
}
