namespace DefineClass
{
	using System;

	public class GSMTest
	{
		public static void Test ()
		{
			var gsmArray = new GSM[] {
				new GSM ("3310", "Nokia"),
				new GSM ("Galaxy S6", "Samsung"),
				new GSM ("Moto G", "Motorola")
			};

			foreach (var item in gsmArray) {
				Console.WriteLine (item);
			}

			Console.WriteLine (GSM.IPhone4S); 
		}
	}
}
	