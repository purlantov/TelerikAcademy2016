using System;

namespace Flies
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			var inputA = Console.ReadLine().Split(' ');
			var pointA = new Point();
			pointA.X = Convert.ToInt32(inputA[0]);
			pointA.Y = Convert.ToInt32(inputA[1]);

			var inputB = Console.ReadLine().Split(' ');
			var pointB = new Point();
			pointB.X = Convert.ToInt32(inputB[0]);
			pointB.Y = Convert.ToInt32(inputB[1]);

			var inputC = Console.ReadLine().Split(' ');
			var pointC = new Point();
			pointC.X = Convert.ToInt32(inputC[0]);
			pointC.Y = Convert.ToInt32(inputC[1]);

			if (pointA.X )
			{

			}
			var ma = (pointB.Y - pointA.Y) / (pointB.X - pointA.X);
			var mb = (pointC.Y - pointB.Y) / (pointC.X - pointB.X);

			var x = (ma * mb * (pointA.Y - pointC.Y) + mb * (pointA.X + pointB.X) - ma * (pointB.X + pointC.X)) / (2 * (mb - ma));


			Console.WriteLine(x);
		}
	}

	struct Point
	{
		public int X;
		public int Y;
	}
}
