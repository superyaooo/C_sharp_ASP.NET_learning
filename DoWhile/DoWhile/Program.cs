using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            do
            {
                Console.WriteLine("i: {0}", i);
                i++;
            } while (i < 10);
            Console.ReadLine();
            return;
        }
    }
}
