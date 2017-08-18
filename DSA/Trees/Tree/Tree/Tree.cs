using System;

namespace Tree
{
	public class Tree<T>
	{
		private T value;
		private Tree<T> left;
		private Tree<T> right;
		public T leftValue;
		public T rightValue;

		public Tree(T value)
			: this(value, null, null)
		{

		}

		public Tree(T value, Tree<T> left, Tree<T> right)
		{
			this.value = value;
			this.left = left;
			this.right = right;
		}

		public Tree(T value,char x, T right)
		{
			this.value = value;
			this.rightValue = right;
		}

		public Tree(T value, T left)
		{
			this.value = value;
			this.leftValue = left;
		}

		public bool IsLeaf => left == null && right == null;

		public T Value => value;

		public Tree<T> Left { get; set;}

		public Tree<T> Right { get; set;}
	}
}
