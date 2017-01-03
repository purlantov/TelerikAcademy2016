using System;
namespace PointsAndPaths
{
    public static class TestClass
    {
        public static void TestDistance()
        {
            Distance.CalculateDistance(new Point3D(1, 2, 3), Point3D.BasePoint);
        }

        public static void TestPath()
        {
            var path = new Path();
            path.AddPoint(new Point3D(0, 0, 0));
            path.AddPoint(new Point3D(1, 1, 1));
            path.AddPoint(new Point3D(2, 2, 2));
            path.AddPoint(new Point3D(3, 3, 3));
            path.AddPoint(new Point3D(1, 2, 3.2f));

            path.PrintPath();
        }

        public static void TestStorePathStore()
        {
            var path = new Path();
            path.AddPoint(new Point3D(0, 0, 0));
            path.AddPoint(new Point3D(1, 1, 1));
            path.AddPoint(new Point3D(2, 2, 2));
            path.AddPoint(new Point3D(3, 3, 3));
            path.AddPoint(new Point3D(1, 2, 3.2f));

            PathStorage.Store(path);

            PathStorage.Load();
        }

        public static void TestStorePathLoad()
        {
            var loadedPath = PathStorage.Load();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Loaded path:");
            loadedPath.PrintPath();
        }
    }
}
