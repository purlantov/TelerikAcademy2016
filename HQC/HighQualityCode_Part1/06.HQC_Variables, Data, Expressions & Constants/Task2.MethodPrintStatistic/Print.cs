using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.MethodPrintStatistic
{
    class Print
    {
        public void PrintStatistics(double[] staticticArray, int count)
        {
            PrintMax(staticticArray, count);

            PrintMinimum(staticticArray, count);

            PrintAverage(staticticArray, count);
        }

        private void PrintMax(double[] arr, int count)
        {
            double max = 0;
            for (int index = 0; index < count; index++)
            {
                if (arr[index] > max)
                {
                    max = arr[index];
                }
            }
            Print(max);
        }

        private void PrintMinimum(double[] arr, int count)
        {
            double min = 0;
            for (int index = 0; index < count; index++)
            {
                if (arr[index] < min)
                {
                    min = arr[index];
                }
            }
            Print(min);
        }

        private void PrintAverage(double[] arr, int count)
        {
            double sum = 0;
            for (int index = 0; index < count; index++)
            {
                sum += arr[index];
            }
            double avg = sum / count;
            Print(avg);
        }

        public void Print(double valueToPrint)
        {
            Console.WriteLine(valueToPrint);
        }
    }
}
