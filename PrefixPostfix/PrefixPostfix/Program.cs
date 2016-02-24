using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrefixPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo;
            valueTwo = valueOne++;
            Console.WriteLine("After postfix: {0},{1}", valueOne,
                valueTwo);
            valueOne = 20;
            valueTwo = ++valueOne;
            Console.WriteLine("After prefix: {0},{1}", valueOne,
                valueTwo);

            Console.ReadLine();
        }
    }
}
