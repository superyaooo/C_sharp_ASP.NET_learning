using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InitializingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 7;
            Console.WriteLine("Initialized, myInt: {0}", myInt);

            myInt = 5;
            Console.WriteLine("After assignment, myInt: {0}", myInt);

            Console.ReadLine();
        }
    }
}
