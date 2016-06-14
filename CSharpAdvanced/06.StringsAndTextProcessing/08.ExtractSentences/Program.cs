using System;

namespace ExtractSentences
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string separator = Console.ReadLine();
			string[] inputText = Console.ReadLine().Split('.');
			for (int i = 0; i < inputText.GetLength(0); i++)
			{
				if (inputText[i].IndexOf(" "+separator+" ") > -1)
				{
					Console.Write(inputText[i]+'.');
				}
			}
		}
	}
}
