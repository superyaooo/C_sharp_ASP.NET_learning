using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UninitializedVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            myInt = 7;
            Console.WriteLine("Uninitialized, myInt: {0}", myInt);
            myInt = 5;
            Console.WriteLine("Assigned, myInt: {0}", myInt);

            Console.ReadLine();
        }
    }
}
