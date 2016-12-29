using System;
using System.Collections.Generic;
using System.Linq;

namespace Trees_Graphs_HashTables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //var numbers = new long[n];
            //
            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = long.Parse(Console.ReadLine());
            //}
            //
            //var duplicateKeys = numbers.GroupBy(x => x)
            //            .Where(group => group.Count() % 2 != 0)
            //            .Select(group => group.Key);
            //
            //foreach (var item in duplicateKeys)
            //{
            //    Console.WriteLine(item);
            //}




            var arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[number] = arr[number] + 1;
            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
