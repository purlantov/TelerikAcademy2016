using System;

namespace HQC_NamingIdentifiers
{
    public class StringConversion
    {
        public void ConvertToString(bool isString)
        {
            string convertedToString = isString.ToString();
            Console.WriteLine(convertedToString);
        }
    }
}
