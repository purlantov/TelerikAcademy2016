using System;

class MainClass
{
	public static void Main ()
	{
		int number = int.Parse (Console.ReadLine ());
		Console.WriteLine (ToWord (number));
	}

	public static string ToWord (int number)
	{
		int digit = 0;
		digit = number % 10;
		string word = null;
			
		switch (digit) {
		case 0:
			word = "zero";
			break;
		case 1:
			word = "one";
			break;
		case 2:
			word = "two";
			break;
		case 3:
			word = "three";
			break;
		case 4:
			word = "four";
			break;
		case 5:
			word = "five";
			break;
		case 6:
			word = "six";
			break;
		case 7:
			word = "seven";
			break;
		case 8:
			word = "eight";
			break;
		case 9:
			word = "nine";
			break;
		}
		return word;
	}

//	public static int ReverseInt (int num)
//	{
//		int result = 0;
//		while (num > 0) {
//			result = result * 10 + num % 10;
//			num /= 10;
//		}
//		return result;
//	}
}