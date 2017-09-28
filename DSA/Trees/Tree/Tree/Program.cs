using System;
using System.Linq;
using System.Collections.Generic;

namespace Tree
{
	using Node = Tree<int>;

	class MainClass
	{
		public static void Main(string[] args)
		{
			var x = PopulateTree();
			for (int i = 0; i < x.Length; i++)
			{
				if (x[i].rightValue == x[i + 1].Value)
				{
					x[i].Right = x[i + 1];
					x[i + 1].Left = x[i];
				}
				if (x[i].leftValue == x[i - 1].Value)
				{
					x[i].Left = x[i - 1];
					x[i - 1].Right = x[i];
				}
			}
		}

		public static Node[] PopulateTree()
		{

			int n = int.Parse(Console.ReadLine());
			Tree<int>[] arr = new Tree<int>[n];
			for (int i = 0; i < n; i++)
			{
				var token = Console.ReadLine().Split(' ');
				var input = Array.ConvertAll(token, int.Parse);
				Tree<int> item = new Tree<int>(input[0], 'a', input[1]);
				arr[i] = item;
			}
			return arr;
		}
	}
}
