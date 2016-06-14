using System;

class MainClass
{
	public static void Main ()
	{
		int n = int.Parse (Console.ReadLine ());
		int count = 1;
		int last = 1;
		int max = 0;
		var arr = new int[n];

		for (int i = 0; i < n; i++) {
			arr [i] = int.Parse (Console.ReadLine ());
		}
		last = arr [0];
		for (int j = 1; j < n; j++) {
			if (arr [j] >= last) {
				count++;
//				if (count > max) {
//					max = count;
//				}
			} else {
				if (count > max) {
					max = count;
				}
				count = 1;
				last = arr [j];
			}

		}
		if (count > max) {
			max = count;
		}
		Console.WriteLine (max);


		//Previous solution gets 10 points
//		int n = int.Parse (Console.ReadLine ());
//		int count = 1;
//		int last = 1;
//		int max = 0;
//		var arr = new int[n];
//
//		for (int i = 0; i < n; i++) {
//			arr [i] = int.Parse (Console.ReadLine ());
//		}
//		last = arr [0];
//		for (int j = 1; j < n; j++) {
//			if (arr [j] >= last) {
//				count++;
//				if (count > max) {
//					max = count;
//				}
//			} else {
//				count = 1;
//			}
//			last = arr [j];
//		}
//
//		Console.WriteLine (max);
	}
}
