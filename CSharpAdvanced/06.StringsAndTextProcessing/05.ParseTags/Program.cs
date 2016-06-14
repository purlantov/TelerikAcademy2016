using System;
using System.Text;

namespace ParseTags
{
	class MainClass
	{
		public static void Main ()
		{
			string input = Console.ReadLine ();
			StringBuilder sb = new StringBuilder ();
			string openTag = "<upcase>";
			string closeTag = @"</upcase>";
			//Console.WriteLine (closeTag);
			int openTagLenght = openTag.Length;
			int closeTagLenght = closeTag.Length;
			int start = 0;
			int end = 0;

//			for (int i = 0; i < input.Length; i++) {
//				if (i + closeTagLenght < input.Length) {
//					if (input.Substring (i, openTagLenght) == openTag) {
//						start = i + openTagLenght;
//						i = start;
//					} else if (input.Substring (i, closeTagLenght) == closeTag) {
//						end = i;
//						sb.Append (input.Substring (start, end).ToUpper ());
//						i = end + closeTagLenght;
//					} else {
//						sb.Append (input [i]);
//					}
//				}
//			}
//			Console.WriteLine (sb);


			for (int i = 0; i < input.Length; i++) {
				if (input.IndexOf (openTag, i) != -1 && input.IndexOf (closeTag, i) != -1) {
					start = input.IndexOf (openTag, i);
					end = input.IndexOf (closeTag, i);
					string str = input.Substring (start + openTag.Length, end - openTag.Length - start).ToUpper ();
					sb.Append (str);
					i = end + closeTag.Length - 1;
				}
				if (i < input.IndexOf (openTag, i)) {
					sb.Append (input [i]);
				}
			}

			Console.WriteLine (sb);
		}
	}
}