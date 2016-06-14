using System;
using System.Linq;

namespace SumIntegers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numbers = Read ();
			Console.WriteLine (CalculateSum(numbers));
		}

		static int[] Read()
		{
			int[] numbers = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			return numbers;
		}

		static int CalculateSum(int[] arr)
		{
			int sum = 0;
			foreach (var item in arr) {
				sum += item;
			}
			return sum;
		}
	}
}
