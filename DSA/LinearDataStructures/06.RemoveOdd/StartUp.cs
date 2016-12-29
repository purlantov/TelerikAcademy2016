using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveOdd
{
	class StartUp
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>
			{ 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

			List<int> even = RemoveOddInList(numbers);

			Print(even);
		}

		private static List<int> RemoveOddInList(List<int> numbers)
		{
			Dictionary<int, int> even = new Dictionary<int, int>();

			foreach (var number in numbers)
			{
				if (even.ContainsKey(number))
				{
					even[number] += 1;
				}
				else
				{
					even.Add(number, 1);
				}
			}

			List<int> result = new List<int>();
			foreach (var number in even.Keys)
			{
				if ((even[number] & 1) == 0)
				{
					result.AddRange(Enumerable.Repeat(number, even[number]));
				}
			}

			return result;
		}

		public static void Print(List<int> numbers)
		{
			foreach (var number in numbers)
			{
				Console.Write($"{number} ");
			}
		}
	}
}
