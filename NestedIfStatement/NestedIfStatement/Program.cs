using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 32;

            if (temp <= 32)
            {
                Console.WriteLine("Warning! Ice on road!");
                if (temp == 32)
                {
                    Console.WriteLine(
                        "Temp exactly freezing, beware of water.");
                }
                else
                {
                    Console.WriteLine("Watch for black ice! Temp: {0}", temp);
                }

                Console.ReadLine();
            }

        }
    }
}
