using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatchingExceptionInCallingFunc
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Entering Main...");
            Test t = new Test();
            t.Func1();
            Console.WriteLine("Exit Main...");

            Console.ReadLine();
        }

        public void Func1()
        {
            Console.WriteLine("Enter Func1...");

            try
            {
                Console.WriteLine("Entering try block...");
                Func2();
                Console.WriteLine("Exiting try block...");
            }
            catch
            {
                Console.WriteLine(
                    "Unknown exception caught when calling Func2.");
            }

            Console.WriteLine("Exit Func1...");
        }

        public void Func2()
        {
            Console.WriteLine("Enter Func2...");
            throw new System.ApplicationException();
            Console.WriteLine("Exit Func2...");
        }
    }
}
