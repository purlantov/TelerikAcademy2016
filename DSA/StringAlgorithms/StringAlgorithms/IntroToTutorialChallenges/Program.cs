using System;

namespace IntroToTutorialChallenges
{
	public class MainClass
	{
		public static void Main()
		{
			int arraySize = Convert.ToInt32(Console.ReadLine());

			int[] array = new int[arraySize];

			String elements = Console.ReadLine();

			String[] splitElements = elements.Split(' ');

			for (int index = 0; index < arraySize; index++)
			{
				array[index] = Convert.ToInt32(splitElements[index]);
			}

			InsertionSort(array);
		}

		public static void InsertionSort(int[] array)
		{
			int lenght = array.Length - 1;

			for (int i = 0; i < lenght; i++)
			{
				if (array[lenght - i] > array[lenght - i + 1])
				{

				}
				else if (array[lenght - i] == array[lenght - i + 1])
				{
					
				}
			}
		}

		public void PrintArray(int[] array)
		{
			Console.WriteLine(string.Join(" ", array));
		}
	}
}
