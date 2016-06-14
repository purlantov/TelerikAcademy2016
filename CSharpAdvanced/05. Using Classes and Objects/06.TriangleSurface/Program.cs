namespace TriangleSurface
{
	using System;

	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = double.Parse (Console.ReadLine ());
			double b = double.Parse (Console.ReadLine ());
			double angle = double.Parse (Console.ReadLine ());
			Triangle triangle = new Triangle (a, b, angle);
			Console.WriteLine ("{0:F2}", triangle.AreaBySidesAngle ());

		}
	}

	class Triangle
	{
		private double sideA;
		private double sideB;
		private double sideC;
		private double altitude;
		private double angle;

		public Triangle ()
		{

		}

		public Triangle (double a, double h)
		{
			this.altitude = h;
			this.sideA = a;
		}

		public Triangle (double a, double b, double angle)
		{
			this.sideA = a;
			this.sideB = b;
			this.angle = angle;
		}

		//		public Triangle (double a, double b, double c)
		//		{
		//			this.sideA = a;
		//			this.sideB = b;
		//			this.sideC = c;
		//		}

		public double AreaBySideH ()
		{
			double area = this.sideA * this.altitude / 2;
			return area;
		}

		public double AreaByTreeSide ()
		{
			double p = 0.5 * (sideA + sideB + sideC);
			double area = Math.Sqrt (p * (p - sideA) * (p - sideB) * (p - sideC));
			return area;
		}

		public double AreaBySidesAngle ()
		{
			double sin = Math.Sin(rad(angle));
			double area = (sideA * sideB * sin) / 2;
			return area;
		}

		public static double rad(double deg)
		{
			return deg * Math.PI / 180;
		}
	}
}
