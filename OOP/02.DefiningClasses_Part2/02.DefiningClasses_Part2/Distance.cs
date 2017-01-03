using System;
namespace PointsAndPaths
{
    public static class Distance
    {
        //Distance formula in 3 dimension space
        //link:https://www.mathsisfun.com/algebra/distance-2-points.html
        public static void CalculateDistance(Point3D first, Point3D second)
        {
            var d = Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2) + Math.Pow(second.Z - first.Z, 2));

            Console.WriteLine($"Distance between {first} and {second}");
            Console.WriteLine($"is D= {d}");
        }
    }
}
