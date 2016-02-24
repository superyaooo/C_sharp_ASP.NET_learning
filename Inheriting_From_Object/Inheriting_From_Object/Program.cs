using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheriting_From_Object
{
    public class SomeClass
    {
        private int val;

        public SomeClass(int someVal)
        {
            val = someVal;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    class Program
    {
        static void DisplayValue(object o)
        {
            Console.WriteLine(
                "The value of the object passed in is {0}", o);
        }

        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine("The value of i is: {0}", i.ToString());
            DisplayValue(i);

            SomeClass s = new SomeClass(7);
            Console.WriteLine("The value of s is {0}", s.ToString());
            DisplayValue(s);

            Console.ReadLine();
        }

        
    }
}
