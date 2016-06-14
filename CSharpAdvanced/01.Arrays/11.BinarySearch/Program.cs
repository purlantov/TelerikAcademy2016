using System;

class MainClass
{
	public static void Main (string[] args)
	{
		//Input
		int n = int.Parse (Console.ReadLine ());
		int[] arr = new int[n];
		for (int i = 0; i < n; i++) {
			arr [i] = int.Parse (Console.ReadLine ());
		}
		int x = int.Parse (Console.ReadLine ());


		Console.WriteLine (BinarySearch (arr, x, 0, n));
	}


	//bynary search 
	//LINK: http://www.c-sharpcorner.com/blogs/binary-search-implementation-using-c-sharp1
	public static object BinarySearch (int[] inputArray, int key, int min, int max)
	{
		while (min <= max) {
			int mid = (min + max) / 2;
			if (key == inputArray [mid]) {
				return mid;
			} else if (key < inputArray [mid]) {
				max = mid - 1;
			} else {
				min = mid + 1;
			}
		}
		return "-1";
	}
}
