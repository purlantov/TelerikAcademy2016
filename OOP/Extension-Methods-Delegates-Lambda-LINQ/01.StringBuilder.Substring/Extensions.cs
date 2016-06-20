namespace _01.StringBuilder.Substring
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public static class Extensions
	{
		public static StringBuilder Substring (this StringBuilder input, int index, int length)
		{
			StringBuilder strBuilder = new StringBuilder ();
			for (int i = index; i < length; i++) {
				strBuilder.Append (input [i]);
			}
			return strBuilder;
		}

	}
}

