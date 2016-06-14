//https://www.youtube.com/watch?v=CE2b_-XfVDk

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MainClass
{
	public static void Main ()
	{
//		//Input
//		int n = int.Parse (Console.ReadLine ());
//		int[] arr = new int[n];
//		for (int i = 0; i < n; i++) {
//			arr [i] = int.Parse (Console.ReadLine ());
//		}

		int n = 0;
		var arr = new List<int> ();
		try
		{   // Open the text file using a stream reader.
			using (StreamReader sr = new StreamReader("TestFile.txt"))
			{
				// Read the stream to a string, and write the string to the console.
				//String line = sr.ReadToEnd();
				//Console.WriteLine(line);
				n = int.Parse(sr.ReadLine());
				for (int i = 0; i < n; i++) {
					arr.Add(int.Parse(sr.ReadLine()));
				}
			}
		}
		catch (Exception e)
		{
			Console.WriteLine("The file could not be read:");
			Console.WriteLine(e.Message);
		}

		// Longest Increasing Subsequence algorithm
		int[] longestIncreasingSequence = new int[n];
		for (int i = 0; i < n; i++)
		{
			longestIncreasingSequence[i] = 1;
		}

		for (int i = 1; i < n; i++)
		{
			for (int j = 0; j < i; j++)
			{
				if (arr[j] <= arr[i])
				{
					longestIncreasingSequence[i] = Math.Max(longestIncreasingSequence[i], longestIncreasingSequence[j] + 1);
				}
			}
		}

		Console.WriteLine(n - longestIncreasingSequence.Max());
	}
		
}
