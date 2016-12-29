using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumAndAverage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            GetNumbers(numbers);

            double average = numbers.Average();
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
    }
}
