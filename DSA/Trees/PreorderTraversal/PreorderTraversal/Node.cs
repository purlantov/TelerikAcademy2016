using System;
namespace PreorderTraversal
{
	public class Node
	{
		int data;
		Node left;
		Node right;

		public Node(int data)
		{
			this.data = data;
			this.left = null;
			this.right = null;
		}

		public Node(int data, Node left, Node right)
		{
			this.data = data;
			this.left = left;
			this.right = right;
		}

		public int Data
		{
			get
			{
				return this.data;
			}
			set
			{
				this.data = value;
			}
		}

		public Node Left
		{
			get
			{
				return this.left;
			}
			set
			{
				this.left = value;
			}
		}

		public Node Right
		{
			get
			{
				return this.right;
			}
			set
			{
				this.right = value;
			}
		}
	}
}
