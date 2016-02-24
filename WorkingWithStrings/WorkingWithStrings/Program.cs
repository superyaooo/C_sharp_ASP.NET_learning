using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main()
        {
            string s1 = "abcd";
            string s2 = "ABCD";
            string s3 = @"Liberty Associates, Inc.
                provides custom .NET development,
                on-site Training and Consulting";

            int result;

            result = string.Compare(s1, s2);
            Console.WriteLine(
                "compare s1: {0}, s2: {1}, result: {2}\n", s1, s2, result);

            result = string.Compare(s1, s2, true);
            Console.WriteLine("compare insensitive\n");
            Console.WriteLine("s4: {0}, s2: {1}, result: {2}\n", s1, s2, result);

            string s6 = string.Concat(s1, s2);
            Console.WriteLine("s6 concatenated from s1 and s2: {0}", s6);

            string s7 = s1 + s2;
            Console.WriteLine("s7 concatenated from s1 + s2: {0}", s7);

            string s8 = string.Copy(s7);
            Console.WriteLine("s8 copied from s7: {0}", s8);

            string s9 = s8;
            Console.WriteLine("s9 = s8: {0}", s9);

            Console.WriteLine(
                "\nDoes s9.Equals(s8)?: {0}",s9.Equals(s8));
            Console.WriteLine("Does Equals(s9,s8)?: {0}", string.Equals(s9, s8));
            Console.WriteLine("Does s9==s8?: {0}", s9 == s8);

            Console.WriteLine("\nString s9 is {0} characters long.", s9.Length);
            Console.WriteLine("The 5th character is {0}\n", s9[4]);

            Console.WriteLine("s3:{0}\nEnds with Training?: {1}\n", s3,
                s3.EndsWith("Training"));
            Console.WriteLine("Ends with Consulting?: {0}",
                s3.EndsWith("Consulting"));

            Console.WriteLine("\nThe first occurrence of Training ");
            Console.WriteLine("in s3 is {0}\n", s3.IndexOf("Training"));

            string s10 = s3.Insert(101, "excellent ");
            Console.WriteLine("s10: {0}\n", s10);

            string s11 = s3.Insert(s3.IndexOf("Training"), "excellent ");
            Console.WriteLine("s11: {0}\n", s11);

            Console.ReadKey();
        }
    }
}
