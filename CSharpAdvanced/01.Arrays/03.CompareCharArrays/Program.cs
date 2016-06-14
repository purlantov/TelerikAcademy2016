using System;

class MainClass
{
	public static void Main ()
	{
		string input1 = Console.ReadLine ();
		string input2 = Console.ReadLine ();

		if (input1.Length > input2.Length) {
			Console.WriteLine (">");
		} else if (input2.Length > input1.Length) {
			Console.WriteLine ("<");
		} else if (input1.Length == input2.Length) {
			string result = null;
			for (int i = 0; i < input1.Length; i++) {
				if (input1 [i] > input2 [i]) {
					result = ">";
				} else if (input2 [i] > input1 [i]) {
					result = "<";
				} else {
					result = "=";
				}
			}
			Console.WriteLine (result);
		}
	}
}
