using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallingAMethod
{
    class CallingAMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Main! Calling SomeMethod()...");
            SomeMethod();
            Console.WriteLine("Back in Main().");

            Console.ReadLine();
        }
        static void SomeMethod()
        {
            Console.WriteLine("Greetings from SomeMethod!");
        }
    }
}
