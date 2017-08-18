using System;
using System.Collections.Generic;

namespace Application
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			var dic = new Dictionary<string, int>();

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');

				dic.Add(input[0], Convert.ToInt32(input[1]));
			}


			string query = null;
			while (true)
			{
				query = Console.ReadLine();
				if (string.IsNullOrEmpty(query))
				{
					break;
				}

				if (dic.ContainsKey(query))
				{
					int result = 0;
					dic.TryGetValue(query,out result);
					Console.WriteLine($"{query}={result}");
				}
				else
				{
					Console.WriteLine("Not found");
				}
			}
		}
	}
}
