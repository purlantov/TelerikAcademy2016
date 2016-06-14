using System;

class MainClass
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());

		var arr = Sieve (n+1);
		int position = 0;
		for (int i = 0; i < arr.Length; i++) {
			if (arr[i] == false) {
				position = i;
			}
		}
		Console.WriteLine (position);
	}

	//Sieve of Eratosthenes algorithm
	static bool[] Sieve (int upTo)
	{
		bool[] notPrime = new bool[upTo];
		notPrime [0] = notPrime [1] = true;
		for (int i = 2; i < Math.Sqrt (notPrime.Length); i++) {
			if (!notPrime [i]) {
				for (int j = i * 2; j < notPrime.Length; j += i) {
					notPrime [j] = true;
				}
			}
		}
		return notPrime;
	}
}
