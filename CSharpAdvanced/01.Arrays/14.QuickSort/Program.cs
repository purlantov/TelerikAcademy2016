using System;

class MainClass
{
	public static void Main ()
	{
		//INPUT
		int n = int.Parse (Console.ReadLine ());
		int[] arr = new int[n];
		for (int i = 0; i < n; i++) {
			arr [i] = int.Parse (Console.ReadLine ());
		}

		QuickSortAlg (arr, 0, n-1);
		foreach (var item in arr) {
			Console.WriteLine (item);
		}
	}

	static void QuickSortAlg (int[] arr, int left, int right)
	{
		int originalLeft = left;
		int originalRight = right;
		int pivot = arr [(left + right) / 2];

		while (left < right) {
			while (pivot > arr [left]) {
				left++;
			}
			while (pivot < arr [right]) {
				right--;
			}
			if (left <= right) {
				int temp = arr [left];
				arr [left] = arr [right];
				arr [right] = temp;

				left++;
				right--;
			}
		}
		if (originalLeft < right) {
			QuickSortAlg (arr, originalLeft, right);
		}
		if (left < originalRight) {
			QuickSortAlg (arr, left, originalRight);
		}
	}
}
