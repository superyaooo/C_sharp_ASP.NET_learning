using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecifyingCaughtException
{
    public class Test 
    {
        public static void Main(string[] args)
        {
            Test t = new Test();
            t.TestFunc();

            Console.ReadLine();
        }

        public void TestFunc()
        {
            try
            {
                double a = 7;
                double b = 0;
                //double b=2;
                Console.WriteLine("{0}/{1}={2}",
                    a, b, DoDivide(a, b));
            }
            catch(System.DivideByZeroException)
            {
                Console.WriteLine(
                    "DividedByZeroException caught!");
            }
            catch(System.ArithmeticException)
            {
                Console.WriteLine(
                    "ArithmeticException caught!");
            }

            catch(Exception e)
            {
                Console.WriteLine("Log: " + e.ToString());
            }
        }

        public double DoDivide(double a,double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            if (a == 0)
                throw new System.ArithmeticException();
            // throw new ApplicationException();
            return a / b;
        }
    }
}
