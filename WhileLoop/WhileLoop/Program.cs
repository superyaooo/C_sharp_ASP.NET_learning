using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<10)
            {
                Console.WriteLine("i: {0}", i);
                i++;
            }
            Console.ReadLine();
            return;
        }
    }
}
