using System;

class MainClass
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		int[] arr = new int[n];
		for (int i = 0; i < n; i++) {
			arr [i] = int.Parse (Console.ReadLine ());
		}

		arr = SplitArray (arr);

		foreach (var item in arr) {
			Console.WriteLine (item);
		}
	}

	public static int[] SplitArray (int[] arr)
	{
		if (arr.Length == 1) {
			return arr;
		}

		int middle = arr.Length / 2;
		int[] leftArr = new int[middle];
		int[] rigthArr = new int[arr.Length - middle];

		for (int i = 0; i < arr.Length; i++) {
			if (i < middle) {
				leftArr [i] = arr [i];
			} else {
				rigthArr [i - middle] = arr [i];
			}
		}

		leftArr = SplitArray (leftArr); //recursive
		rigthArr = SplitArray (rigthArr);//recursive

		return MergeArrays (leftArr, rigthArr);
	}

	public static int[] MergeArrays (int[] left, int[] right)
	{
		int leftIndex = 0;
		int rightIndex = 0;
		int[] arr = new int[left.Length + right.Length];

		for (int i = 0; i < arr.Length; i++) {
			if (rightIndex == right.Length
			    || (leftIndex < left.Length
			    && left [leftIndex] <= right [rightIndex])) {
				arr [i] = left [leftIndex];
				leftIndex++;
			} else if (leftIndex == left.Length
			           || (rightIndex < right.Length
			           && left [leftIndex] >= right [rightIndex])) {
				arr [i] = right [rightIndex];
				rightIndex++;
			}
		}

		return arr;
	}


}
