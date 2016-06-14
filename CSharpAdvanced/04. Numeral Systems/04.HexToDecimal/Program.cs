using System;

class MainClass
{
	public static void Main ()
	{
		string text = Console.ReadLine ();
		//Console.WriteLine (FromHexToDecimal (text));
		Console.WriteLine (Convert.ToUInt64(text,16));
	}

	static long FromHexToDecimal (string hex)
	{
		long number = 0;
		for (int i = 0; i < hex.Length; i++) {
			number += (ToDigit (hex [hex.Length - i - 1]) * (long)Math.Pow (i, 16));
		}
		return number;
	}

	static long ToDigit (char symbol)
	{
		long digit = 0;
		switch (symbol) {
		case '0':
			digit = 0;
			break;
		case '1':
			digit = 1;
			break;
		case '2':
			digit = 2;
			break;
		case '3':
			digit = 3;
			break;
		case '4':
			digit = 4;
			break;
		case '5':
			digit = 5;
			break;
		case '6':
			digit = 6;
			break;
		case '7':
			digit = 7;
			break;
		case '8':
			digit = 8;
			break;
		case '9':
			digit = 9;
			break;
		case 'A':
			digit = 10;
			break;
		case 'B':
			digit = 11;
			break;
		case 'C':
			digit = 12;
			break;
		case 'D':
			digit = 13;
			break;
		case 'E':
			digit = 14;
			break;
		case 'F':
			digit = 15;
			break;
		}

		return digit;
	}
}
