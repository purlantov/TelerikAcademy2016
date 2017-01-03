using System;
namespace PointsAndPaths
{
    public struct Point3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        private static readonly Point3D basePoint = new Point3D(0, 0, 0);

        public Point3D(float x, float y, float z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format($"({X}, {Y}, {Z})");
        }

        public static Point3D BasePoint
        {
            get { return basePoint;}
        }
    }
}
