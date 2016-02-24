using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathProb1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = 20;
            decimal num2 = 30;
            Console.Write("What is {0} devided by {1}?", num1, num2);
            decimal result = Convert.ToDecimal(Console.ReadLine());
            decimal num3 = decimal.Round((num1/num2),2);

            if (result == num3)
            {
                Console.WriteLine("Correct!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Opps, wrong!");
                Console.WriteLine("The answer is: {0}",num3);
                Console.ReadLine();
            }
        }
    }
}
