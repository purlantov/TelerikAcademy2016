using System;

class MainClass
{
	public static void Main ()
	{
		string text = Console.ReadLine ();
		Console.WriteLine (ToDecimal (text));
	}

	static ulong ToDecimal (string text)
	{
		ulong toDecimal = 0;
		ulong bit = 1;
		for (int i = text.Length - 1; i >= 0; i--) {
			toDecimal = toDecimal + (ToDigit(text[i]) * bit);
			bit *= 2;
		}

		return toDecimal;
	}

	static ulong ToDigit(char symbol)
	{
		ulong n = 0;
		switch (symbol) {
		case '0':
			n = 0;
			break;
		case '1':
			n = 1;
			break;
		}
		return n;
	}
}