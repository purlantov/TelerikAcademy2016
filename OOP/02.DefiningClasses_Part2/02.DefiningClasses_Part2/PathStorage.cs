using System;
using System.IO;

namespace PointsAndPaths
{
    public static class PathStorage
    {
        public static void Store(Path path)
        {
            string filePath = "../../ Path.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                try
                {
                    foreach (var point in path.Points)
                    {
                        writer.WriteLine(point);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The new path was saved successfuly!");
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public static Path Load()
        {
            string filePath = "../../ Path.txt";
            
            var loadPath = new Path();

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader(filePath))
            {
                try
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        //string line = reader.ReadLine();
                        var splittedLine = line.Split(new char[] { ' ', '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        loadPath.AddPoint(new Point3D(float.Parse(splittedLine[0]), float.Parse(splittedLine[1]), float.Parse(splittedLine[2])));
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Path loaded successfuly!");
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return loadPath;
        }
    }
}
