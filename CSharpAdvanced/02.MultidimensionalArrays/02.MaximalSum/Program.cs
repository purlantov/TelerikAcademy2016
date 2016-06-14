using System;

class MainClass
{
	public static void Main ()
	{
		string[] nm = Console.ReadLine ().Split (' ');
		UInt16 n = UInt16.Parse (nm [0]);
		UInt16 m = UInt16.Parse (nm [1]);
		Int16[,] matrix = new Int16[n, m];
		string[] textSplit = null;
		for (Int16 i = 0; i < n; i++) {
			textSplit = Console.ReadLine ().Split (' ');
			for (Int16 j = 0; j < textSplit.Length; j++) {
				matrix [i, j] = Int16.Parse (textSplit [j]);
			}
		}

		Int32 maxSum = Int32.MinValue;
		Int32 sum = 0;
		for (Int16 row = 0; row < n - 2; row++) {
			for (Int16 col = 0; col < m - 2; col++) {
				sum = matrix [row, col] + matrix [row, col + 1] + matrix [row, col + 2] +
				          matrix [row + 1, col] + matrix [row + 1, col + 1] + matrix [row + 1, col + 2] +
				          matrix [row + 2, col] + matrix [row + 2, col + 1] + matrix [row + 2, col + 2];
				if (sum > maxSum) {
					maxSum = sum;
				}
			}
		}
		Console.WriteLine (maxSum);
	}
}