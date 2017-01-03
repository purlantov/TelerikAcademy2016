using System;
namespace DefiningClasses_Part1
{
    public class GSMTest
    {
        public static void Test()
        {
            
            GSM gsm = new GSM("nokia", "3310");
            Console.WriteLine(gsm.Model);
            Console.WriteLine(gsm.Manufacturer);
            Console.WriteLine();

            var gsmList = new GSM[]
            {
                new GSM("Motorola", "MotoG2", 250, "Ivan"),
                new GSM("Motorola", "MotoG3", 310, "Dragan"),
                new GSM("Motorola", "MotoG4", 350, "Ivan"),
                new GSM("Motorola", "XPlay", 600, "Gosho",new Battery("OEM",BatteryType.LiIon),new Display()),
                new GSM("Motorola", "XForce", 950, "Pavel",new Battery("OEM", 99,25),new Display((float)5.4,16400000)),
                new GSM("Motorola", "XPlay2", 600, "Gosho",new Battery("OEM",BatteryType.NiCd),new Display())
            };

            foreach (var device in gsmList)
            {
                Console.WriteLine(device);
                Console.WriteLine();
            }
        }
    }
}
