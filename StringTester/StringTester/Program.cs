using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTester
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "One Two Three Four";

            int ix;

            ix = s1.LastIndexOf(" ");

            string s2 = s1.Substring(ix + 1);

            s1 = s1.Substring(0, ix);

            ix = s1.LastIndexOf(" ");

            string s3 = s1.Substring(ix + 1);

            s1 = s1.Substring(0,ix);

            ix = s1.LastIndexOf(" ");

            string s4 = s1.Substring(ix + 1);

            s1 = s1.Substring(0, ix);

            ix = s1.LastIndexOf(" ");

            string s5 = s1.Substring(ix + 1);

            Console.WriteLine("s2: {0}\ns3: {1}", s2, s3);
            Console.WriteLine("s4: {0}\ns5: {1}\n", s4, s5);
            Console.WriteLine("s1: {0}\n", s1);

            Console.ReadLine();
        }
    }
}
