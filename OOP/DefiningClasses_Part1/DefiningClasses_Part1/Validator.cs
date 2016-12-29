using System;
namespace DefiningClasses_Part1
{
    public static class Validator
    {
        public static string ValidateString()
        {
            return null;
        }

        public static void ValidateInt(int number, string text)
        {
            if (number <= 0)
            {
                throw new ArgumentException($"{text} should be grater than 0!");
            }
        }

        public static void ValidateUInt(uint number, string text)
        {
            if (number <= 0)
            {
                throw new ArgumentException($"{text} should be grater than 0!");
            }
        }
    }
}
