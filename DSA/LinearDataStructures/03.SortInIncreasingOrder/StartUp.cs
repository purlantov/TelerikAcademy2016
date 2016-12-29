using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortInIncreasingOrder
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>();

            GetNumbers(numbers);

            numbers.Sort();

            PrintNumbers(numbers);
        }

        public static void GetNumbers(List<int> numbers)
        {
            string input = null;

            while (input != "")
            {
                int number;

                input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    numbers.Add(number);
                }
            }
        }

        public static void PrintNumbers(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
