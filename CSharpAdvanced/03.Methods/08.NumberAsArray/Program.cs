using System;
using System.Linq;

class MainClass
{
	public static void Main ()
	{
		Console.ReadLine ();
		int[] array1 = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
		int[] array2 = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
		Print(SumArrays (array1, array2));

	}

	public static int[] SumArrays (int[] arr1, int[] arr2)
	{
		int sum = 0;
		int lenght = Math.Max (arr1.Length, arr2.Length);
		int[] sumArray = new int[lenght];
		//fing larger array and fill smaller with zeroes
		if (arr1.Length > arr2.Length) {
			arr2 = FillArray (arr2, lenght);
		} else if (arr1.Length == arr2.Length) {
			//Do nothing
		} else {
			arr1 = FillArray (arr1,lenght);
		}
		//sums the arrays
		for (int i = 0; i < lenght; i++) {
			sum += arr1 [i] + arr2 [i];
			if (sum > 9) {
				sumArray [i] = sum % 10;
				sum = 1;
			} else {
				sumArray [i] = sum % 10;
				sum = 0;
			}

			//sumArray[i] = arr1 [i] + arr2 [i];
		}

		return sumArray;
	}

	public static int[] FillArray (int[] arr, int lenght)
	{
		int[] newArr = new int[lenght];
		for (int i = 0; i < lenght; i++) {
			if (i >= arr.Length) {
				newArr [i] = 0;
			} else {
				newArr [i] = arr [i];
			}
		}

		return newArr;
	}

	public static void Print(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++) {
			if (i == arr.Length-1) {
				Console.Write (arr [i]);
			} else {
				Console.Write ("{0} ", arr [i]); 
			}
		}
	}
}