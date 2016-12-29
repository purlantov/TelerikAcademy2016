using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegative
{
	class StartUp
	{
		public static void Main()
		{
			List<int> numbers = new List<int>() { 1, 2, -3, -4, 5, 6 };

			Console.WriteLine("Initial Numbers: ");
			foreach (var number in numbers)
			{
				Console.Write($"{number} ");
			}

			//
			//One way
			//
			//int numbersLen = numbers.Count;
			//List<int> positiveNmbers = new List<int>();
			//for (int i = 0; i < numbersLen; i++)
			//{
			//	if (numbers[i] < 0)
			//	{
			//		continue;
			//	}
			//	positiveNmbers.Add(numbers[i]);
			//}

			//
			//Another Way
			//
			//List<int> positiveNumbers = (from number in numbers
			//							 where number > 0
			//							 select number).ToList();

			var positiveNumbers = numbers.Where(n => n > 0).ToArray();

			//
			//Another another way
			//
			//Console.WriteLine("\nOnly Positive Numbers: ");
			//for (int i = 0; i < positiveNmbers.Count; i++)
			//{
			//	Console.Write(positiveNmbers[i] + " ");
			//}

			foreach (var number in positiveNumbers)
			{
				Console.WriteLine(number);
			}
		}
	}
}
