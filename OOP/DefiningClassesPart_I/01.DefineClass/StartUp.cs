﻿namespace DefineClass
{
	using System;

	class StartUp
	{
		public static void Main (string[] args)
		{
			
			GSMTest.Test (); //Tetsing GSM class

			Console.WriteLine (new String ('-', 70)); //Delimeter

			GSMCallHistoryTest.CallHistoryTest (); //CallHistoryTest class
		}
	}
}