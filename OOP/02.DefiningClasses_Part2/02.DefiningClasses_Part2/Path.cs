using System;
using System.Collections.Generic;

namespace PointsAndPaths
{
    public class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(int index)
        {
            this.points.RemoveAt(index);
        }

        public void ClearAll()
        {
            this.points.Clear();
        }

        public void PrintPath()
        {
            foreach (var point in points)
            {
                Console.WriteLine($"({point.X}, {point.Y}, {point.Z})");
            }
        }

        public List<Point3D> Points
        {
            get { return this.points;}
        }

    }
}
