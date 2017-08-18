using System;
using System.Collections.Generic;
using System.Linq;

namespace PreorderTraversal
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();

			//Console.WriteLine(string.Join(" ", input));
			Node root = new Node(input[0]);
			root.Left = new Node(input[1]);

			PreorderTraversal(root);
		}

		public static void PreorderTraversal(Node root)
		{
			Node pre;

			if (root == null)
			{
				return;
			}

			Node current = root;

			while (current != null)
			{
				if (current.Left == null)
				{
					Console.Write(current.Data + " ");
					current = current.Right;
				}
				else
				{
					pre = current.Left;
					while (pre.Right != null && pre.Right != current)
						pre = pre.Right;
					if (pre.Right == null)
					{
						pre.Right = current;
						Console.Write(current.Data + " ");
						current = current.Left;
					}
					else {
						pre.Right = null;
						current = current.Right;
					}
				}
			}
		}
	}
}
