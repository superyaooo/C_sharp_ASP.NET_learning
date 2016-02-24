using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivisionModulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1, i2;
            float f1, f2;
            double d1, d2;
            decimal dec1, dec2;

            i1 = 17;
            i2 = 4;
            f1 = 17f;
            f2 = 4f;
            d1 = 17;
            d2 = 4;
            dec1 = 17;
            dec2 = 4;
            Console.WriteLine("Integer:\t{0}\nfloat:\t\t{1}",
                i1 / i2, f1 / f2);
            Console.WriteLine("double:\t\t{0}\ndecimal:\t{1}",
                d1 / d2, dec1 / dec2);
            Console.WriteLine("\nModulus:\t{0}", i1 % i2);

            Console.ReadLine();
        }
    }
}
