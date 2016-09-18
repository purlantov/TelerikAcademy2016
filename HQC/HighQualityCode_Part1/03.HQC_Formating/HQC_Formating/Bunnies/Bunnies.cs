﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace High.Quality.Code.BadExample
{
    using HQC_Formating.Bunnies;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading.Tasks;

    public class Bunnies
    {
        static void Main(string[] args)
        {
            var bunnies = new List<Bunny>
            {
                new Bunny { Name = "Leonid" , Age= 1, FurType = FurType.NotFluffy },
                new Bunny { Age= 2, Name = "Rasputin" , FurType = FurType.ALittleFluffy },
                new Bunny { FurType = FurType.ALittleFluffy, Name = "Tiberii" , Age= 3, },
                new Bunny { Name = "Neron" , FurType = FurType.ALittleFluffy, Age= 1 },
                new Bunny { Name = "Klavdii" , Age= 3, FurType = FurType.Fluffy },
                new Bunny { Name = "Vespasian" , Age= 3, FurType = FurType.Fluffy },
                new Bunny { Name = "Domician" , Age = 4, FurType = FurType.FluffyToTheLimit },
                new Bunny { Name = "Tit" , Age= 2,FurType = FurType.FluffyToTheLimit }
            };


            var consoleWriter = new HQC_Formating.Bunnies.ConsoleWriter();

            // Introduce all bunnies

            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            // Create bunnies text file
            var bunniesFilePath = @"..\..\bunnies.txt";
            var fileStream = File.Create(bunniesFilePath); fileStream.Close();

            // Save bunnies to a text file
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}

