using System;
using System.Numerics;

class MainClass
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		Console.WriteLine (Factorial(n));
	}

	static BigInteger Factorial (int n)
	{
		if (n == 0)
			return 1;
		return n * Factorial (n - 1);
	}
}