using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumeratedConstants
{
    class Program
    {

        enum Temperatures
        { 
            WickedCold=0,
            FreezingPoint=32,
            LightJacketWeather=60,
            SwimmingWeather=72,
            BoilingPoint=212,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("freezing point of water: {0}",
                (int)Temperatures.FreezingPoint);
            Console.WriteLine("Boiling point of water: {0}",
                (int)Temperatures.BoilingPoint);

            Console.ReadLine();
        }
    }
}
