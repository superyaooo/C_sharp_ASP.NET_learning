using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo = 20;

            if (valueOne>valueTwo)
            {
                Console.WriteLine(
                "ValueOne: {0} larger than ValueTwo: {1}", 
                valueOne,valueTwo);
            }
            else
            {
                Console.WriteLine(
                "ValueTwo: {0} larger than valueOne: {1}", 
                valueTwo,valueOne);
            }

            valueOne = 30;

            if (valueOne > valueTwo)
            {
                valueTwo = valueOne + 1;

                Console.WriteLine("\nSetting valueTwo to valueOne value, ");
                Console.WriteLine("and incrementing ValueOne.\n");
                Console.WriteLine("ValueOne: {0} ValueTwo: {1}",
                    valueOne, valueTwo);
            }
            else
            {
                valueOne = valueTwo;
                Console.WriteLine("Setting them equal. ");
                Console.WriteLine("ValueOne: {0} ValueTwo: {1}",
                    valueOne, valueTwo);
            }

            Console.ReadLine();
        }
    }
}
