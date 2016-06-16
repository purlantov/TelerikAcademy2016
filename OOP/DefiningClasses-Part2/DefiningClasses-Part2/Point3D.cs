namespace DefiningClassesPart2
{
	using System;

	public struct Point3D
	{
		public double X{ get; set; }

		public double Y { get; set; }

		public double Z { get; set; }

		public static readonly Point3D basePoint = new Point3D (0, 0, 0);


		public Point3D (double x, double y, double z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

			
		public static Point3D BasePoint {
			get { return basePoint; }
		}


		//
		// ToString Override
		//
		public override string ToString ()
		{
			return String.Format ("({0}, {1}, {2})", X, Y, Z);
		}


	}
}

