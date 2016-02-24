using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayPractice
{
    class Program
    {
        static void Main()
        {
            string[] myArray = new string[3];
            Console.WriteLine("Input the 1st array element: ");
            var num1 = Console.ReadLine();
            

            Console.WriteLine("Input the 2nd array element: ");
            var num2 = Console.ReadLine();
          

            Console.WriteLine("Input the 3rd array element: ");
            var num3 = Console.ReadLine();
         

            myArray[0] = num1;
            myArray[1] = num2;
            myArray[2] = num3;

            Console.WriteLine("You just created this Array: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("myArray[{0}]: {1}",i,myArray[i]);
            }

            Console.ReadLine();
        }
    }
}
