using System;
using System.Linq;

class MainClass
{
	public static void Main ()
	{
		int[] numbers = Console.ReadLine ().Split ().Select (int.Parse).ToArray ();

		Console.WriteLine (Min (numbers));
		Console.WriteLine (Max (numbers));
		Console.WriteLine ("{0:F2}", Average (numbers));
		Console.WriteLine (Sum (numbers));
		Console.WriteLine (Product (numbers));

	}

	static long Sum (int[] numbers)
	{
		long sum = 0;
		for (int i = 0; i < numbers.Length; i++) {
			sum += numbers [i];
		}
		return sum;
	}

	static double Average (int[] numbers)
	{
		double sum = Sum (numbers);
		double average = sum / numbers.Length;
		return average;
	}

	static double Min (int[] numbers)
	{
		int min = int.MaxValue;
		foreach (var item in numbers) {
			if (item < min) {
				min = item;
			}
		}
		return min;

	}

	static double Max (int[] numbers)
	{
		int max = int.MinValue;
		foreach (var item in numbers) {
			if (item > max) {
				max = item;
			}
		}
		return max;
	}

	static long Product (int[] numbers)
	{
		long product = 1;
		foreach (var item in numbers) {
			product *= item;
		}
		return product;
	}
}