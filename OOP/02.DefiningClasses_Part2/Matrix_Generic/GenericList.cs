using System;
namespace Matrix_Generic
{
	public class GenericList<T>
	{
		private const int InitialCapacity = 4;
		//private int capacity;
		private int nextElement;
		private T[] elements;

		public int Count { get; private set; }

		public int Capacity
		{
			get { return elements.Length; }
		}

		public GenericList()
		{
			this.Count = 0;
			this.elements = new T[InitialCapacity];
		}

		public void Add(T item)
		{
			// resize if necessary
			if (this.Count == this.Capacity)
			{
				this.Grow();
			}

			elements[this.Count++] = item;
		}

		// indexer
		public T this[int index]
		{
			get
			{
				return this.elements[index];
			}
			set
			{
				this.elements[index] = value;
			}
		}

		public void RemoveElement(T item)
		{

		}

		public void RemoveAt(int index)
		{
			for (int i = index; i < this.Count - 1; i++)
			{
				this.elements[i] = this.elements[i + 1];
			}

			this.elements[this.Count - 1] = default(T);

			this.Count--;
		}

		private void Grow()
		{
			var newElements = new T[this.Capacity * 2];

			for (int i = 0; i < this.Count; i++)
			{
				newElements[i] = this.elements[i];
			}

			this.elements = newElements;
		}

		public void Print()
		{
			Console.WriteLine(string.Join(", ", this.elements));
		}
	}
}
