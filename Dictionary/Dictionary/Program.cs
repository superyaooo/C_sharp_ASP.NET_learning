using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Dictionary =
                new Dictionary<string, string>();
            Dictionary.Add("000440312", "Jesse Liberty");
            Dictionary.Add("000123933", "Stacey Liberty");
            Dictionary.Add("000145938", "Douglas Adams");
            Dictionary.Add("000773394", "Ayn Rand");

            Console.WriteLine("myDictionary[\"000145938\"]: {0}",
                Dictionary["000145938"]);

            Console.ReadLine();
        }
    }
}
