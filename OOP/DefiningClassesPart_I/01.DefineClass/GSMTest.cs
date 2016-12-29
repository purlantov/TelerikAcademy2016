using System;

namespace DefineClass
{
    public static class GSMTest
    {
        public static void Test()
        {
            var gsmArray = new GSM[]
            {
                new GSM ("3310", "Nokia"),
                new GSM ("Galaxy S6", "Samsung"),
                new GSM ("Moto X Force", "Motorola"),
                new GSM ("A3", "Samsung", 360, "Ivan")
            };

            foreach (var item in gsmArray)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(GSM.IPhone4S);
        }
    }
}
