using System;
using System.Collections.Generic;
using System.Linq;

namespace CokiSkoki
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			var array = Console.ReadLine().Split(' ').Select(v => Convert.ToInt32(v)).ToArray();

			int counter = 0;
			int max = array.Max();
			int last = array[n - 1];
			var list = new int[n];
			int building = 0;

			int longestSeaquense = 0;

			for (int i = 0; i < n; i++)
			{
				building = i+1;
				for (int j = i + 1; j < n; j++)
				{
					if (array[j] == max)
					{
						break;
					}
					else if (array[j] > array[i])
					{
						counter++;
						if (counter > longestSeaquense)
						{
							longestSeaquense = counter;
						}
						i = j;
						j++;
					}
					else
					{
						j++;
					}
				}

				list[i] = counter;
				i = building;
				counter = 0;
			}

			Console.WriteLine(longestSeaquense);
			Console.WriteLine(string.Join(" ", list));
		}
	}
}

//  Input
//  6
//  1 4 2 6 3 4
//  Output
//  2
//  2 1 1 0 1 0