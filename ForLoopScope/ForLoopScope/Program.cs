using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForLoopScope
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0}", i);

                if(i%10==0)
                {
                    Console.WriteLine("\t{0}", i);
                }
                Console.WriteLine("\n Final value of i: {0}", i);
            }

            Console.ReadLine();
            
        }
    }
}
