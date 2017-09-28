using System;
using System.Numerics;

class MainClass
{
	public static void Main(string[] args)
	{
		ulong n = ulong.Parse(Console.ReadLine());

		BigInteger sum = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));

		Console.WriteLine(sum);
	}

	public static BigInteger Factorial(BigInteger i)
	{
		if (i <= 1)
			return 1;
		return i * Factorial(i - 1);
	}
}
