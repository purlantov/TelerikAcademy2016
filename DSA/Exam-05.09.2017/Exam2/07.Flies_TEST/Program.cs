using System;

namespace Flies_TEST
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


			var circle = new Circle(pointA, pointB, pointC);

			var center = circle.Center;

			Console.WriteLine("{0:F4} {1:F4}", center.X, center.Y);

		}
	}

	public class Point
	{
		public double X { get; set; }
		public double Y { get; set; }
		public Point Center { get; set; }

		public Point()
		{

		}

		public Point(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}
	}


	public class Circle
	{
		public Point Center { get; set; }
		public double Radius { get; set; }

		public Circle()
		{

		}

		public Circle(Point p1, Point p2, Point p3) : this()
		{
			double t = p2.X * p2.X + p2.Y * p2.Y;
			double bc = (p1.X * p1.X + p1.Y * p1.Y - t) / 2.0;
			double cd = (t - p3.X * p3.X - p3.Y * p3.Y) / 2.0;
			double det = (p1.X - p2.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p2.Y);

			if (Math.Abs(det) > 1.0e-6) // Determinant was found. Otherwise, radius will be left as zero.
			{
				det = 1 / det;
				double x = (bc * (p2.Y - p3.Y) - cd * (p1.Y - p2.Y)) * det;
				double y = ((p1.X - p2.X) * cd - (p2.X - p3.X) * bc) * det;
				double r = Math.Sqrt((x - p1.X) * (x - p1.X) + (y - p1.Y) * (y - p1.Y));

				this.Center = new Point(x, y);
				this.Radius = r;
			}
		}
	}

}
