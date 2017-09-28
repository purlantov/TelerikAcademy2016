using System;
using System.Linq;

namespace MinMaxSum
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				int m = Convert.ToInt32(input[0]);
				int groups = Convert.ToInt32(input[1]);

				var arr = Console.ReadLine().Split(' ').Select(v => Convert.ToInt32(v)).ToArray();


				for (int j = 0; j < arr.Length; j++)
				{
					int[] array1 = new int[m];
				}

				//var xs =
				//	from v in Enumerable.Range(0, arr.Length)
				//	from l in Enumerable.Range(1, arr.Length - v)
				//	let subseq = arr.Skip(v).Take(l)
				//	orderby subseq.Count() ascending
				//	orderby subseq.Sum() ascending
				//	select subseq;

				//var maxSumSubseq = xs.Last();

				//Console.WriteLine(string.Join(" ", maxSumSubseq));

			}

		}
	}
}
