﻿using System;

namespace TriangleSurface
{
	using System;

	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = double.Parse (Console.ReadLine ());
			double b = double.Parse (Console.ReadLine ());
			double c = double.Parse (Console.ReadLine ());
			Triangle triangle = new Triangle (a, b, c);
			Console.WriteLine ("{0:F2}", triangle.AreaByTreeSide ());

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

		//		public Triangle (double a, double b, double angle)
		//		{
		//			this.sideA = a;
		//			this.sideB = b;
		//			this.angle = angle;
		//		}

		public Triangle (double a, double b, double c)
		{
			this.sideA = a;
			this.sideB = b;
			this.sideC = c;
		}

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
			double area = 0.5 * (sideB * sideC) * Math.Sin (angle);
			return area;
		}
	}
}
