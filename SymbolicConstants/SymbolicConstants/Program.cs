using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SymbolicConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FreezingPoint = 32; //degrees Fahrenheit
            const int BoilingPoint = 212;

            Console.WriteLine("Freezing point of water: {0}", FreezingPoint);
            Console.WriteLine("Boiling point of water: {0}", BoilingPoint);

            Console.ReadLine();
        }
    }
}
