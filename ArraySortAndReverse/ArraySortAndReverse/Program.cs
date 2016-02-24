using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraySortAndReverse
{
    public class Program
    {
        public static void PrintMyArray(object[] theArray)
        {
            foreach(object obj in theArray)
            {
                Console.WriteLine("Value: {0}", obj);
            }
            Console.WriteLine("\n");
        }

        static void Main()
        {
            String[] myArray = { "Who", "is", "Douglas", "Adams" };

            PrintMyArray(myArray);
            Array.Reverse(myArray);
            PrintMyArray(myArray);

            String[] myOtherArray =
                {
                    "We","Hold","These","Truths",
                    "To","Be","Self","Evident",
                };

            PrintMyArray(myOtherArray);
            Array.Sort(myOtherArray);
            PrintMyArray(myOtherArray);

            Console.ReadLine();
        }
    }
}
