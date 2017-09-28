using System;

namespace BigSorting
{
	public class MainClass
	{
		public static void Main()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] unsorted = new string[n];
			for (int i = 0; i < n; i++)
			{
				unsorted[i] = Console.ReadLine();
			}
			Array.Sort(unsorted, (string a, string b) =>
			{
				if (a.Length == b.Length)
					return string.Compare(a, b, StringComparison.Ordinal);
				return a.Length - b.Length;
			});
			Console.WriteLine(string.Join("\n", unsorted));
		}
	}
}
