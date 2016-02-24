using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatchingAnException
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Enter Main...");
            Test t=new Test();
            t.Func1();
            Console.WriteLine("Exit Main...");

            Console.ReadLine();
        }

        public void Func1()
        {
            Console.WriteLine("Enter Func1...");
            Func2();
            Console.WriteLine("Exit Func1...");
        }

        public void Func2()
        {
            Console.WriteLine("Enter Func2...");

            try 
            {
                Console.WriteLine("Entering try block...");
                throw new System.ApplicationException();
                Console.WriteLine("Exiting try block...");
            }
            catch 
            {
                Console.WriteLine("Exception caught and handled.");
            }

            Console.WriteLine("Exit Func2...");
        }
    }
}
