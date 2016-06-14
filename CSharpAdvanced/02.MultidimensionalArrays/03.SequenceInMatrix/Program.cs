using System;

class MainClass
{
	public static void Main ()
	{
		//Input trought TXT file
		using (System.IO.StreamReader sr = new System.IO.StreamReader ("TestFile.txt")) {
			string[] line = sr.ReadLine ().Split (' ');
			int rows = int.Parse (line [0]);
			int cols = int.Parse (line [1]);

			int[,] arr = new int[rows, cols];
			for (int i = 0; i < rows; i++) {
				line = sr.ReadLine ().Split (' ');
				for (int j = 0; j < cols; j++) {
					arr [i, j] = int.Parse (line [j]);
				}
			}

			//Input trouhgt console
//		string[] line = Console.ReadLine ().Split (' ');
//		int rows = int.Parse (line [0]);
//		int cols = int.Parse (line [1]);
//
//		int[,] arr = new int[rows, cols];
//		for (int i = 0; i < rows; i++) {
//			line = Console.ReadLine ().Split (' ');
//			for (int j = 0; j < cols; j++) {
//				arr [i, j] = int.Parse (line [j]);
//			}
//		}

			int counter = 0;
			int common = 0;
			int bestCount = 0;
			int[,] commonArray = new int[rows * 2, 2];
			for (int row = 0; row < rows; row++) {
				for (int col = 0; col < cols - 1; col++) {
					if (arr [row, col] == arr [row, col + 1]) {
						commonArray [row, 0] = arr [row, col];
					}
				}
			}

			int[,] commonArray2 = new int[rows * 2, 2];
			for (int col = 0; col < cols; col++) {
				for (int row = 0; row < rows - 1; row++) {
					if (arr [row, col] == arr [row + 1, col]) {
						commonArray2 [row, 0] = arr [row, col];
					}
				}
			}

			for (int i = 0; i < commonArray.GetLength (0) - 1; i++) {
				if (commonArray [i, 0] == commonArray [i + 1, 0] && commonArray [i, 0] > 0) {
					counter += 2;
					common = commonArray [i, 0];
				}
			}

			for (int i = 0; i < commonArray2.GetLength (0) - 1; i++) {
				if (commonArray [i, 0] == commonArray2 [i + 1, 0] && commonArray2 [i, 0] > 0) {
					counter += 2;
					common = commonArray2 [i, 0];
				}
			}

			Console.WriteLine (counter);
		}
	
	}
}