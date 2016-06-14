using System;
using System.Text;

namespace CorrectBrackets
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StringBuilder sb = new StringBuilder ();
			string text = Console.ReadLine ();
			int left = 0;
			int right = 0;
			for (int i = 0; i < text.Length; i++) {
				if (text[i]=='(') {
					left++;
				}
				if (text[i]==')') {
					right++;
				}
			}
			if (left!=right) {
				Console.WriteLine ("Incorrect");
			} else {
				Console.WriteLine ("Correct");
			}

		}
	}
}
