namespace _01.StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
			StringBuilder sb = new StringBuilder ();
			sb.Append ("aide dede aide");
			var strBuild = sb.Substring (1, 3);
			Console.WriteLine (strBuild.ToString());
			Console.ReadLine ();
        }
    }
}
