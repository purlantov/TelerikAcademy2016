using System;

namespace GenericList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var lis = new GenericList<double>();
            for (int i = 0; i < 28; i++)
            {
                lis.Add(i);
            }

            Console.WriteLine(lis[1]);
            Console.WriteLine(lis[10]);
            Console.WriteLine(lis[14]);
            Console.WriteLine($"Count:{lis.Count}");
            Console.WriteLine(lis);
            lis.RemoveAt(14);
            Console.WriteLine(lis);
            Console.WriteLine($"Count:{lis.Count}");
            Console.WriteLine($"Capacity:{lis.Capacity}");

            Console.WriteLine($"Min: {lis.Min()}");
            Console.WriteLine($"Max: {lis.Max()}");
        }
    }
}
