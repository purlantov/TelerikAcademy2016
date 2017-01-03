using System;

namespace PointsAndPaths
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TestClass.TestDistance();
            Console.WriteLine();

            TestClass.TestPath();
            Console.WriteLine();

            TestClass.TestStorePathStore();
            Console.WriteLine();

            TestClass.TestStorePathLoad();
        }
    }
}
