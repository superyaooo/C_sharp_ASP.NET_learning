﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo = 20;

            int maxValue = valueOne > valueTwo ? valueOne : valueTwo;

            Console.WriteLine("ValueOne: {0}, valueTwo: {1}, maxValue: {2}",
                valueOne, valueTwo, maxValue);

            Console.ReadLine();
        }
    }
}
