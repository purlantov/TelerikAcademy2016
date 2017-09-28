﻿using System;

namespace WoodenBoard
{
	public class MainClass
	{
		//public static bool isPalin(char[] str, int st, int end)
		//{
		//	while (st < end)
		//	{
		//		if (str[st] != str[end])
		//			return false;
		//		st++;
		//		end--;
		//	}
		//	return true;
		//}


		static int GetNumForPalindrome(string str)
		{
			int count = 0;
			for (int start = 0, end = str.Length - 1; start < end; ++start)
			{
				if (str[start] != str[end])
					++count;
				else --end;
			}
			return count;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(GetNumForPalindrome(Console.ReadLine()).ToString());
		}
	}
}
